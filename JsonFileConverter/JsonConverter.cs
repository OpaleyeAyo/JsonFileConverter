using Aspose.Cells;
using Aspose.Cells.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonFileConverter
{
    public class JsonConverter
    {
        public void Convert()
        {
            try
            {
                Workbook workbook = new();
                Worksheet worksheet = workbook.Worksheets[0];

                string jsonInput = File.ReadAllText(@"C:\Users\babatunde\Desktop\DammyFile\users.json");

                if (string.IsNullOrEmpty(jsonInput))
                {
                    JsonLayoutOptions options = new();
                    options.ArrayAsTable = true;

                    JsonUtility.ImportData(jsonInput, worksheet.Cells, 0, 0, options);

                    workbook.Save("users.xlsx");
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
