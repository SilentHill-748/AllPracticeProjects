using System;
using System.IO;
using System.Diagnostics;

using Spire.Doc;
using Spire.Doc.Collections;

using Archive.Exceptions;
using System.Text;

namespace Archive.Documents.Word
{
    public class WordDocumentInfo : TextDocumentInfo
    {



        public WordDocumentInfo(FileInfo documentFileInfo)
            : base(documentFileInfo)
        {
            using Document document = documentFileInfo.Extension switch
            {
                ".rtf" => new Document(documentFileInfo.FullName, FileFormat.Rtf),
                ".doc" or
                ".docx" => new Document(documentFileInfo.FullName, FileFormat.Docx2013),
                ".odt" => new Document(documentFileInfo.FullName, FileFormat.Odt),
                _ => new Document(documentFileInfo.FullName)
            };

            //string text = document.GetText();

            //byte[] textBytes = Encoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(text));

            //Text = Encoding.UTF8.GetString(textBytes);

            Text = document.GetText();

            Summary = GetParagraphText(document.Sections[0].Paragraphs);
        }



        public override string Summary { get; }

        public override string Text { get; }


        //private string SetupSummary()
        //{
        //    try
        //    {
        //        using Document document = new(_file.FullName);

        //        _text = document.GetText();

        //        ParagraphCollection paragraphs = document.Sections[0].Paragraphs;
        //        return GetParagraphText(paragraphs);
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(
        //            "Can't read word-file and throws exception with message:\n{0}",
        //            ex.Message);
        //        return string.Empty;
        //    }
        //}

        private string GetParagraphText(ParagraphCollection paragraphs)
        {
            for (var i = 0; i < paragraphs.Count; i++)
            {
                string paragraphText = paragraphs[i].Text;
                if (paragraphText.Contains("Описание:"))
                {
                    if (paragraphText.Length > 10)
                        return paragraphText.Replace("Описание:", "").Trim();
                    else
                        return paragraphs[i + 1].Text;
                }
            }

            return string.Empty;

            //throw new ParagraphTextException("Not found paragraph which containsed \'Описание:\'!");
        }
    }
}
