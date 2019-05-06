using CsvHelper;
using IrregularVerbsFormGenerator.DTOs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrregularVerbsFormGenerator
{
    /// <summary>
    /// Reference : https://joshclose.github.io/CsvHelper/
    /// </summary>
    public class Reader
    {
        public static List<Verb> ReadFields()
        {
            List<Verb> records = new List<Verb>();

            using (var reader = new StreamReader(@".\Resources\irregular-verbs.csv"))
            using (var csv = new CsvReader(reader))
            {
                records = csv.GetRecords<Verb>().ToList();
            }

            return records;
        }
    }
}