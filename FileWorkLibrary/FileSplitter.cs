using System.IO;

namespace FileWorkLibrary
{
    public class FileSplitter
    {
        readonly string fileUrl;

        public FileSplitter(string fileUrl)
        {
            this.fileUrl = fileUrl;
        }

        public string[] GetSplitedTextBySentence()
        {
            string text = File.ReadAllText(string.Concat("@",fileUrl));

            return text.Split('.');
        }
    }
}
