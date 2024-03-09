using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game2048.Common
{
    public class FileProvider
    {
        public static void Append(string fileName, string value)
        {
            var textString = value;
            using (StreamWriter textWriter = new StreamWriter(fileName, true, System.Text.Encoding.Default))
            {
                textWriter.WriteLine(textString);
            }
        }
        public static void Replace(string fileName, string value)
        {
            var textString = value;
            using (StreamWriter textWriter = new StreamWriter(fileName, false, System.Text.Encoding.Default))
            {
                textWriter.WriteLine(textString);
            }
        }

        public static string GetValue(string fileName)
        {
            var value = "";
            using (StreamReader textReader = new StreamReader(fileName))
            {
                value = textReader.ReadToEnd();
            }
            return value;
        }

        public static bool Exists(string path)
        {
            return File.Exists(path);
        }

        public static void Clear(string path)
        {
            File.WriteAllText(path, string.Empty);
        }
        public static bool CheckFileNotEmpty(string path)
        {
            string jsonFileEmptyValue = "[]\r\n";
            string value = File.ReadAllText(path);
            if (value.Length > jsonFileEmptyValue.Length)
                return true;
            else
                return false;
        }
    }
}