using Dominio;
using Negocio;
using Sistema_de_pedidos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using PdfSharp.Pdf;
using Microsoft.Win32;

namespace Presentacion
{
    public partial class Registros : Form
    {

        public List<int> idsSeleccionados;



        public Registros()
        {
            InitializeComponent();
        }
       

        public Registros(List<int> idsSeleccionados)
        {
            InitializeComponent();
            this.idsSeleccionados = idsSeleccionados;
        }

      

        private void Registros_Load(object sender, EventArgs e)
        {

            RegistroNegocio nuevo = new RegistroNegocio();
            List<Registro> registros = nuevo.Registros();

            if (idsSeleccionados != null && idsSeleccionados.Count > 0)
            {
                var listaFiltrada = registros.Where(registro => idsSeleccionados.Contains(registro.IdPedido)).ToList();
                dgvRegistros.DataSource = listaFiltrada;
            }
            else
            {
                dgvRegistros.DataSource = registros;
            }

            dgvRegistros.Columns["ClienteId"].Visible = false;


        }


        private void btnImprimir_Click(object sender, EventArgs e)
        {
            GenerarPedidosPDF();

            GenerarPedidosSemanalPDF();
        }



        private void btnImprimirVendidos_Click(object sender, EventArgs e)
        {
            GenerarPedidosPDF();

            GenerarPDFPorCategoria();

        }



        private void GenerarPedidosSemanalPDF()
        {
            Document document = new Document();
            Section section = document.AddSection();

            MigraDoc.DocumentObjectModel.Font titleFont = new MigraDoc.DocumentObjectModel.Font("Arial", 14);
            MigraDoc.DocumentObjectModel.Font infoFont = new MigraDoc.DocumentObjectModel.Font("Arial", 10);
            MigraDoc.DocumentObjectModel.Font headerFont = new MigraDoc.DocumentObjectModel.Font("Arial", 12);
            MigraDoc.DocumentObjectModel.Font textFont = new MigraDoc.DocumentObjectModel.Font("Arial", 10);
            headerFont.Bold = true;

            Paragraph paragraph = section.AddParagraph();
            paragraph.Format.Alignment = ParagraphAlignment.Center;
            paragraph.AddFormattedText("IL GABINETTO", titleFont);
            paragraph.AddLineBreak();
            paragraph.AddFormattedText("Teléfono: (123) 456-7890\nFecha: " + DateTime.Now.ToString("dd/MM/yyyy"), infoFont);

            var registros = dgvRegistros.Rows.Cast<DataGridViewRow>()
                            .Where(r => !r.IsNewRow)
                            .Select(r => new Registro
                            {
                                IdPedido = (int)r.Cells["idPedido"].Value,
                                NombreCliente = (string)r.Cells["NombreCliente"].Value,
                                Fecha = (DateTime)r.Cells["fecha"].Value,
                                Cantidad = (int)r.Cells["cantidad"].Value,
                                NombreArticulo = (string)r.Cells["nombreArticulo"].Value,
                                Categoria = (string)r.Cells["Categoria"].Value,
                                localidad = (string)r.Cells["localidad"].Value,
                                Perforacion = (string)r.Cells["perforacion"].Value,
                                Tipo = (string)r.Cells["Tipo"].Value,
                                Observacion = r.Cells["observacion"].Value != DBNull.Value ? (string)r.Cells["observacion"].Value : string.Empty
                            })
                            .Where(r => r.Categoria == "Mesada") 
                            .OrderBy(r => r.NombreCliente)
                            .ThenBy(r => r.IdPedido)
                            .ToList();

            var registrosAgrupados = registros.GroupBy(r => new { r.NombreCliente, r.IdPedido });

            // Crea una tabla con dos columnas
            Table table = section.AddTable();
            table.Borders.Width = 0.75;

            // Definir columnas de la tabla
            Column column1 = table.AddColumn(Unit.FromCentimeter(8));
            Column column2 = table.AddColumn(Unit.FromCentimeter(8));

            // Agrega una fila para los cuadros
            Row tableRow = table.AddRow();
            tableRow.TopPadding = 5;
            tableRow.BottomPadding = 5;

            int cuadroCount = 0;

            foreach (var grupo in registrosAgrupados)
            {
                // Agrega una nueva fila para cada par de cuadros
                if (cuadroCount % 2 == 0 && cuadroCount > 0)
                {
                    tableRow = table.AddRow();
                    tableRow.TopPadding = 5;
                    tableRow.BottomPadding = 5;
                }

                Cell cell = (cuadroCount % 2 == 0) ? tableRow.Cells[0] : tableRow.Cells[1];

                // Configura el color de fondo y los bordes de las celdas
                cell.Shading.Color = Colors.White; // Fondo blanco
                cell.Borders.Width = 1; // bordes

                Paragraph pedidoBox = cell.AddParagraph();
                pedidoBox.Format.SpaceBefore = "2mm";
                pedidoBox.Format.SpaceAfter = "5mm";

                pedidoBox.AddFormattedText($"{grupo.First().NombreCliente} - {grupo.First().localidad} - Pedido: {grupo.First().IdPedido}", headerFont);
                pedidoBox.AddLineBreak();

                foreach (var registro in grupo)
                {
                    string line = $"{registro.Cantidad} {registro.NombreArticulo}";

                    if (!string.IsNullOrWhiteSpace(registro.Perforacion) && registro.Perforacion != "No corresponde")
                    {
                        line += $" {registro.Perforacion}";
                    }
                    if (!string.IsNullOrWhiteSpace(registro.Observacion))
                    {
                        line += $" {registro.Observacion}";
                    }
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        pedidoBox.AddFormattedText(line + "\n", textFont);
                    }
                }

                cuadroCount++;
            }


            // Obtener la ruta al escritorio
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Definir la ruta completa: Escritorio/pedidos/semanal
            string folderPath = Path.Combine(desktopPath, "pedidos", "Semanal");

            // Verificar si la carpeta existe; si no, crearla
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            // Generar el nombre del archivo con timestamp
            string timestamp = DateTime.Now.ToString("yyyyMMddHHmmss");
            string pdfPath = Path.Combine(folderPath, $"PedidosSemanal_{timestamp}.pdf");

            // Renderizar y guardar el PDF
            PdfDocumentRenderer pdfRenderer = new PdfDocumentRenderer(true)
            {
                Document = document
            };
            pdfRenderer.RenderDocument();
            pdfRenderer.PdfDocument.Save(pdfPath);

            MessageBox.Show("PDF generado exitosamente en la carpeta 'pedidos/Semanal' del escritorio.");


        }





        private void GenerarPedidosPDF()
        {
             
             Document document = new Document();
             Section section = document.AddSection();


            MigraDoc.DocumentObjectModel.Font titleFont = new MigraDoc.DocumentObjectModel.Font("Arial", 14);
            MigraDoc.DocumentObjectModel.Font infoFont = new MigraDoc.DocumentObjectModel.Font("Arial", 10);
            MigraDoc.DocumentObjectModel.Font headerFont = new MigraDoc.DocumentObjectModel.Font("Arial", 12);
            MigraDoc.DocumentObjectModel.Font textFont = new MigraDoc.DocumentObjectModel.Font("Arial", 10);
            headerFont.Bold = true;

           
            Paragraph paragraph = section.AddParagraph();
            paragraph.Format.Alignment = ParagraphAlignment.Center;
            paragraph.AddFormattedText("IL GABINETTO", titleFont);
            paragraph.AddLineBreak();
            paragraph.AddFormattedText("Teléfono: (123) 456-7890\nFecha: " + DateTime.Now.ToString("dd/MM/yyyy"), infoFont);

           
            var registros = dgvRegistros.Rows.Cast<DataGridViewRow>()
                            .Where(r => !r.IsNewRow)
                            .Select(r => new Registro
                            {
                                IdPedido = (int)r.Cells["idPedido"].Value,
                                NombreCliente = (string)r.Cells["NombreCliente"].Value,
                                Fecha = (DateTime)r.Cells["fecha"].Value,
                                Cantidad = (int)r.Cells["cantidad"].Value,
                                NombreArticulo = (string)r.Cells["nombreArticulo"].Value,
                                localidad = (string)r.Cells["localidad"].Value,
                                Perforacion = (string)r.Cells["perforacion"].Value,
                                Tipo = (string)r.Cells["Tipo"].Value,
                                Observacion = r.Cells["observacion"].Value != DBNull.Value ? (string)r.Cells["observacion"].Value : string.Empty
                            })
                            .OrderBy(r => r.NombreCliente)
                            .ThenBy(r => r.IdPedido)
                            .ToList();

            var registrosAgrupados = registros.GroupBy(r => new { r.NombreCliente, r.IdPedido });

            // Crea una tabla con dos columnas
            Table table = section.AddTable();
            table.Borders.Width = 0.75;

            // Definir columnas de la tabla
            Column column1 = table.AddColumn(Unit.FromCentimeter(8)); 
            Column column2 = table.AddColumn(Unit.FromCentimeter(8)); 

            // Agrega una fila para los cuadros
            Row tableRow = table.AddRow();
            tableRow.TopPadding = 5;
            tableRow.BottomPadding = 5;

            int cuadroCount = 0;

            foreach (var grupo in registrosAgrupados)
            {
                // Agrega una nueva fila para cada par de cuadros
                if (cuadroCount % 2 == 0 && cuadroCount > 0)
                {
                    tableRow = table.AddRow();
                    tableRow.TopPadding = 5;
                    tableRow.BottomPadding = 5;
                }

                Cell cell = (cuadroCount % 2 == 0) ? tableRow.Cells[0] : tableRow.Cells[1];

                // Configura el color de fondo y los bordes de las celdas
                cell.Shading.Color = Colors.White; 
                cell.Borders.Width = 1; // bordes

                Paragraph pedidoBox = cell.AddParagraph();
                pedidoBox.Format.SpaceBefore = "2mm";
                pedidoBox.Format.SpaceAfter = "5mm";

                pedidoBox.AddFormattedText($"{grupo.First().NombreCliente} - {grupo.First().localidad} - Pedido: {grupo.First().IdPedido}", headerFont);
                pedidoBox.AddLineBreak();

                foreach (var registro in grupo)
                {
                    string line = $"{registro.Cantidad} {registro.NombreArticulo}";

                    if (!string.IsNullOrWhiteSpace(registro.Perforacion) && registro.Perforacion != "No corresponde")
                    {
                        line += $" {registro.Perforacion}";
                    }
                    if (!string.IsNullOrWhiteSpace(registro.Observacion))
                    {
                        line += $" {registro.Observacion}";
                    }
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        pedidoBox.AddFormattedText(line + "\n", textFont);
                    }
                }

                cuadroCount++;
            }

            // Obtener el tipo 

            string tipo = registros.FirstOrDefault()?.Tipo ?? "Otro";


            string subcarpeta = tipo == "Viaje" ? "Viaje" : tipo == "Semanal" ? "Semanal" : "otros";

          
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Definir la ruta completa: Escritorio/pedidos/[tipo]
            string folderPath = Path.Combine(desktopPath, "pedidos", subcarpeta);

            // Verificar si la carpeta existe; si no, crearla
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            // Generar el nombre
            string timestamp = DateTime.Now.ToString("yyyyMMddHHmmss");
            string pdfPath = Path.Combine(folderPath, $"Pedidos_{timestamp}.pdf");


            PdfDocumentRenderer pdfRenderer = new PdfDocumentRenderer(true)
            {
                Document = document
            };
            pdfRenderer.RenderDocument();
            pdfRenderer.PdfDocument.Save(pdfPath);

            MessageBox.Show($"PDF generado exitosamente en la carpeta 'pedidos/{subcarpeta}' del escritorio.");


        }


        public void GenerarPDFPorCategoria()
        {
            var registros = dgvRegistros.Rows.Cast<DataGridViewRow>()
                .Where(r => !r.IsNewRow)
                .Select(r => new Registro
                {
                    IdPedido = (int)r.Cells["idPedido"].Value,
                    NombreCliente = (string)r.Cells["NombreCliente"].Value,
                    Fecha = (DateTime)r.Cells["fecha"].Value,
                    Cantidad = (int)r.Cells["cantidad"].Value,
                    NombreArticulo = (string)r.Cells["nombreArticulo"].Value,
                    Categoria = (string)r.Cells["Categoria"].Value,
                    Perforacion = (string)r.Cells["perforacion"].Value,
                    Tipo = (string)r.Cells["Tipo"].Value,
                    Observacion = r.Cells["observacion"].Value != DBNull.Value ? (string)r.Cells["observacion"].Value : string.Empty
                })
                .ToList();

            
            var registrosMueble = registros.Where(r => r.Categoria == "Mueble").ToList();
            var registrosMesada = registros.Where(r => r.Categoria == "Mesada").ToList();

           
            if (registrosMueble.Any())
            {
                GenerarPDF("Mueble", registrosMueble);
            }

            
            if (registrosMesada.Any())
            {
                GenerarPDF("Mesada", registrosMesada);
            }

        }

        private void GenerarPDF(string categoria, List<Registro> registros)
        {
            Document document = new Document();
            Section section = document.AddSection();

            MigraDoc.DocumentObjectModel.Font titleFont = new MigraDoc.DocumentObjectModel.Font("Arial", 14);
            MigraDoc.DocumentObjectModel.Font infoFont = new MigraDoc.DocumentObjectModel.Font("Arial", 10);
            MigraDoc.DocumentObjectModel.Font headerFont = new MigraDoc.DocumentObjectModel.Font("Arial", 10);
            MigraDoc.DocumentObjectModel.Font textFont = new MigraDoc.DocumentObjectModel.Font("Arial", 10);

            Paragraph paragraph = section.AddParagraph();
            paragraph.Format.Alignment = ParagraphAlignment.Center;
            paragraph.AddFormattedText("IL GABINETTO", titleFont);
            paragraph.AddLineBreak();
            paragraph.AddFormattedText("Teléfono: (123) 456-7890\nFecha: " + DateTime.Now.ToString("dd/MM/yyyy"), infoFont);
            paragraph.AddLineBreak();
            paragraph.AddFormattedText($"{categoria}", infoFont);


            var registrosAgrupados = registros
                .GroupBy(r => r.NombreArticulo)
                .Select(g => new
                {
                    NombreArticulo = g.Key,
                    CantidadTotal = g.Sum(r => r.Cantidad),
                    Observaciones = g.Select(r => r.Observacion).Where(o => !string.IsNullOrWhiteSpace(o)).Distinct().ToList(),
                    Perforacion =  g.Select(r => r.Perforacion).Where(o => !string.IsNullOrWhiteSpace (o)).Distinct().ToList()
        })
                .OrderBy(g => g.NombreArticulo)
                .ToList();

            Table table = section.AddTable();
            table.Borders.Width = 0.75;
            Column column = table.AddColumn(Unit.FromCentimeter(16));

            foreach (var grupo in registrosAgrupados)
            {
                Row tableRow = table.AddRow();
                Cell cell = tableRow.Cells[0];
                cell.Shading.Color = Colors.White;
                cell.Borders.Width = 1;

                Paragraph pedidoBox = cell.AddParagraph();
                pedidoBox.Format.SpaceBefore = "1mm";
                pedidoBox.Format.SpaceAfter = "1mm";


                
                bool esPerforacionNoCorresponde = grupo.Perforacion == null || grupo.Perforacion.Count == 0 || grupo.Perforacion.Contains("No corresponde");

                pedidoBox.AddFormattedText($"{grupo.CantidadTotal}    {grupo.NombreArticulo} {(esPerforacionNoCorresponde ? "" : string.Join(", ", grupo.Perforacion))}", headerFont);
                pedidoBox.AddLineBreak();
               
                foreach (var observacion in grupo.Observaciones)
                {
                    pedidoBox.AddFormattedText($"Observación: {observacion}\n", textFont);
                }


            }


            // Obtener la ruta al escritorio
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Definir la ruta completa
            string folderPath = Path.Combine(desktopPath, "pedidos", "Viaje");

            // Verificar si la carpeta existe; si no, crearla
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            // Generar el nombre del archivo con timestamp
            string timestamp = DateTime.Now.ToString("yyyyMMddHHmmss");
            string pdfPath = Path.Combine(folderPath, $"{categoria}_PedidosViaje_{timestamp}.pdf");

            // Renderizar y guardar el PDF
            PdfDocumentRenderer pdfRenderer = new PdfDocumentRenderer(true)
            {
                Document = document
            };
            pdfRenderer.RenderDocument();
            pdfRenderer.PdfDocument.Save(pdfPath);

            MessageBox.Show("PDF generado exitosamente en la carpeta 'pedidos/viaje' del escritorio.");


        }


    }
    

}
