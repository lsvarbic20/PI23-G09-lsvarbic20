using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileWriter {
    public class CsvFileWriter : IFileWriter {
        public string GetFormat() {
            return "CSV";
        }

        public void WriteFile(string path, string fileName, object[] content) {
            string finalContent = "";
            List<string> properties = new List<string>();

            foreach (var property in content[0].GetType().GetProperties())
                
                {
                    if (property.CanRead) {
                    finalContent += $"{property.Name};";
                        properties.Add(property.Name);
                }
            }
            foreach (var item in content) {

                finalContent += "\n";
                foreach ( var propertyName in properties) {
                    var value = item.GetType().GetProperty(propertyName).GetValue(item);
                    finalContent += $"{value};";
                }
            }
    }
}

    File.WriteAllText($@"{path}\{fileName}).{GetFormat()}",finalContent));
