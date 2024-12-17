using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace ProyectoFinal_PapasDonuteria
{
    public partial class FormPagoTarjeta : Form
    {
        double pagoTotal;
        public FormPagoTarjeta(double pagoTotal)
        {
            InitializeComponent();
            this.pagoTotal = pagoTotal;
        }

        private void buttonPagar_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNom.Text;
            string numTarjeta = textBoxNumTarj.Text;
            string mes = textBoxMes.Text;
            string anio = textBoxAnio.Text;
            string PIN = textBoxPin.Text;

            crearDocumento(nombre, numTarjeta, mes, anio,pagoTotal);
            
        }

        private void crearDocumento(string nombre, string numTar, string mes, string anio, double pago)
        {
            string outputFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "CompraTarjeta.pdf");

            //Create a standard .Net FileStream for the file, setting various flags
            using (FileStream fs = new FileStream(outputFile, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                //Create a new PDF document setting the size to A4
                using (Document doc = new Document(PageSize.LETTER))
                {
                    //Bind the PDF document to the FileStream using an iTextSharp PdfWriter
                    using (PdfWriter w = PdfWriter.GetInstance(doc, fs))
                    {
                        //Open the document for writing
                        doc.Open();

                        iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance(ProyectoFinal_PapasDonuteria.Properties.Resources.Logo, System.Drawing.Imaging.ImageFormat.Png);
                        imagen.BorderWidth = 0;
                        imagen.Alignment = Element.ALIGN_LEFT;
                        float percentage = 0.0f;
                        percentage = 150 / imagen.Width;
                        imagen.ScalePercent(percentage * 100);

                        // Insertamos la imagen en el documento
                        doc.Add(imagen);
                        doc.Add(new Paragraph($"Elige, personaliza y disfruta\nDatos de pago:\nPrecio Total: {pago}\nDatos de tarjeta\nNumero: {numTar}\nFecha de vencimiento: {mes}/{anio}"));

                        //Close our document
                        doc.Close();
                    }
                }
            }
        }
    }
}
