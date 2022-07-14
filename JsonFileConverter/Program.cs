
using Aspose.Cells;
using Aspose.Cells.Utility;
using System;
using System.IO;

namespace JsonFileConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            JsonConverter convert = new();
            convert.Convert();
        }
    }
}
