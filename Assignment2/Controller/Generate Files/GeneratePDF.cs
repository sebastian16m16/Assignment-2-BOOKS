using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
namespace Assignment2.Controller
{
    class GeneratePDF
    {
        internal Interact.AdminInteract AdminInteract
        {
            get => default;
            set
            {
            }
        }

        internal Interact.UserInteract UserInteract
        {
            get => default;
            set
            {
            }
        }

        public void createPDF(String filename, String text)
        {
            filename = filename + ".pdf";
            Document document = new Document(PageSize.B8, 20f, 20f, 30f, 30f);

            var projectFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            var path = Path.Combine(projectFolder, @"Out Of Stock\" + filename);

            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(path, FileMode.Create));

            document.Open();

            Paragraph paragraph = new Paragraph(text);
            document.Add(paragraph);
            document.Close();
        }

       public bool deleteFile(String filename)
        {
            filename = filename + ".pdf";

            var projectFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            var path = Path.Combine(projectFolder, @"Out Of Stock\" + filename);

            if (File.Exists(path))
            {
                File.Delete(path);
                return true;
            }
            else
                return false;
        } 
    }
}
