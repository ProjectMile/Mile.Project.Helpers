using System.IO;
using System.Text;

namespace Mile.Project.Helpers
{
    public class FileUtilities
    {
        public static void ConvertFileEncoding(
            string FilePath,
            Encoding InputEncoding,
            Encoding OutputEncoding)
        {
            File.WriteAllText(
                FilePath,
                File.ReadAllText(FilePath, InputEncoding),
                OutputEncoding);
        }

        public static void ConvertFileToUtf8(
            string FilePath,
            Encoding InputEncoding)
        {
            ConvertFileEncoding(FilePath, InputEncoding, new UTF8Encoding());
        }

        public static void ConvertFileFromUtf8BomToUtf8(
            string FilePath)
        {
            ConvertFileToUtf8(FilePath, Encoding.UTF8);
        }

        public static void ConvertFileToUtf8Bom(
            string FilePath,
            Encoding InputEncoding)
        {
            ConvertFileEncoding(FilePath, InputEncoding, Encoding.UTF8);
        }

        public static void ConvertFileFromUtf8ToUtf8Bom(
            string FilePath)
        {
            ConvertFileToUtf8Bom(FilePath, Encoding.UTF8);
        }

        public static void SaveTextToFileAsUtf8(
            string FilePath,
            string Contents)
        {
            File.WriteAllText(FilePath, Contents, new UTF8Encoding());
        }
    }
}
