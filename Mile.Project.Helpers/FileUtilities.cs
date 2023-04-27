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
    }
}
