using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrregularVerbsFormGenerator.DTOs
{
    public class Result
    {
        public Verb Verb { get; set; }

        public int NumAttempts { get; set; }

        public int WrongAttempts { get; set; }

        public bool ClueUsed { get; set; }
    }
}