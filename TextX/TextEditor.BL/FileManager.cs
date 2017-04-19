using System;
using System.IO;
using System.Text;


public interface IFileManager
{
    bool IsExist(string filePath);
    string GetContent(string filePath);
    string GetContent(string filePath, Encoding encoding);
    void SaveContent(string content, string filePath);
    void SaveContent(string content, string filePath, Encoding encoding);
    int GetSymbolCount(string content);
    

}

namespace TextEditor.BL
{
    public class FileManager: IFileManager
    {
        public readonly Encoding _defaultEncoding =  Encoding.GetEncoding(1251);

        public bool IsExist(string filePath)
        {
            bool isExist = File.Exists(filePath);
            return isExist;
        }

        public string GetContent(string filePath)
        {
            return File.ReadAllText(filePath, _defaultEncoding);
        }

        public string GetContent(string filePath, Encoding encoding)
        {
            string content = File.ReadAllText(filePath, encoding);
            return content;
        }

        public void SaveContent(string content, string filePath)
        {
            SaveContent(content, filePath, _defaultEncoding);
        }

        public void SaveContent (string content, string filePath, Encoding encoding)
        {
            File.WriteAllText(content, filePath, encoding);
        }

        public int GetSymbolCount (string content)
        {
            int count = content.Length;
            return count; 
        }

    }
}
