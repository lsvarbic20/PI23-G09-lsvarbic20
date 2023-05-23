using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileWriter {
    internal class JsonFileWriter : IFileWriter {
        public string GetFormat() => "JSON";

        public void WriteFile(string path, string fileName, object[] content) {
            var finalContent = JsonConvert.SerializeObject(content);
            File.WriteAllText("$@"{ path}\{ filename}.GetFormat()}", finalContent)
        }
    }
}
