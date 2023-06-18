using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using System.Xml.Linq;

namespace LR26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void createButton_Click(object sender, EventArgs e)
        {
            string path = "C:\\Users\\admin\\Desktop\\ООП\\конверт.docx";
            string output = "C:\\Users\\admin\\Desktop\\ООП";
            string senderName = sendername.Text; 
            string adresSender = adressender.Text;
            string recipientName = namerecipient.Text;
            string adresRecipient = adresrecipient.Text;
            int indexRecipient = int.Parse(index.Text);


            Microsoft.Office.Interop.Word.Application wordTemplate = new Microsoft.Office.Interop.Word.Application();
            Documents documents = wordTemplate.Documents;


            Document templateDocument = documents.Open(path);

            Document outputDocument = wordTemplate.Documents.Add();


            foreach(Table table in templateDocument.Tables)
            {
                table.Range.Copy();
                WdParagraphAlignment aligment = table.Range.ParagraphFormat.Alignment;
                Paragraph paragraph = outputDocument.Content.Paragraphs.Add();
                paragraph.Range.Paste();
                paragraph.Range.ParagraphFormat.Alignment = aligment;
            }


            foreach (Range range in outputDocument.StoryRanges)
            {
                Find findObject = range.Find;
                findObject.Text = "[Відправник_П.І.Б.]";
                findObject.Replacement.Text = senderName;
                findObject.Execute(Replace: WdReplace.wdReplaceAll);


                findObject.Text = "[Відправник_Адреса]";
                findObject.Replacement.Text = adresSender;
                findObject.Execute(Replace: WdReplace.wdReplaceAll);

                findObject.Text = "[Одержувач_П.І.Б.]";
                findObject.Replacement.Text = recipientName;
                findObject.Execute(Replace: WdReplace.wdReplaceAll);

                findObject.Text = "[Одержувач_Адреса]";
                findObject.Replacement.Text = adresRecipient;
                findObject.Execute(Replace: WdReplace.wdReplaceAll);

                findObject.Text = "[Індекс]";
                findObject.Replacement.Text = indexRecipient.ToString();
                findObject.Execute(Replace: WdReplace.wdReplaceAll);
            }

            string outputFilesNeme = $"{senderName}'s_letter";
            string pathOutput = System.IO.Path.Combine(output, outputFilesNeme);
            outputDocument.SaveAs2(pathOutput);


            templateDocument.Close();
            outputDocument.Close();
            wordTemplate.Quit();


            MessageBox.Show("Згенеровано!");
        }
    }
}
