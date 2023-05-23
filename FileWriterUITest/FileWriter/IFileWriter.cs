using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileWriter {
    public interface IFileWriter 
        
        {
        void WriteFile(string path, string fileName, object[] content);
        string GetFormat();

        }
}
