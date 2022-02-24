using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

using Archive.Documents.Attributes;

namespace Archive.Documents
{
    /// <summary>
    /// Исследует конфиг файл формата txt и парсит из него данные в коллекцию <see cref="DocumentAttributes"/>.
    /// </summary>
    public class ConfigParser
    {
        private readonly string _rootDir;
        private readonly FileInfo _configFile;


        public ConfigParser(string filename)
        {
            if (string.IsNullOrEmpty(filename))
                throw new ArgumentException($"{nameof(filename)} was null or empty!");

            if (!File.Exists(filename))
                throw new FileNotFoundException($"File by path like '{filename}' wasn't found!");

            _configFile = new FileInfo(filename);
            _rootDir = _configFile.Directory!.FullName;
        }

        public ConfigParser(FileInfo file)
        {
            if (file is null)
                throw new ArgumentNullException(nameof(file));

            _configFile = file;
            _rootDir = file.Directory!.FullName;
        }


        public int DocumentCount
        {
            get
            {
                return File.ReadAllLines(_configFile.FullName).Length;
            }
        }


        /// <summary>
        /// Считывает файл конфигурации и возвращает коллекцию атрибутов документа.
        /// </summary>
        /// <returns>Готовая к работе коллекция атрибутов.</returns>
        public List<DocumentAttributes> GetDocumentsWithAttributes()
        {
            string[] lines = File.ReadAllLines(_configFile.FullName);
            List<DocumentAttributes> result = new(lines.Length);

            for (int i = 0; i < lines.Length; i++)
            {
                string[] attrs = Regex.Replace(lines[i], @"[\[\]]", "")
                    .Split(':');

                attrs[0] = _rootDir + "\\" + attrs[0];

                attrs[2] = string.Join(',', attrs[2].Split(',')
                        .Select(str => _rootDir + "\\" + str.Trim()));

                result.Add(new(attrs));
            }

            return result;
        }
    }
}
