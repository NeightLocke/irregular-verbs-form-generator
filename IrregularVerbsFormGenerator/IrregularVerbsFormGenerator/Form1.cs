using IrregularVerbsFormGenerator.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IrregularVerbsFormGenerator
{
    public partial class MainForm : Form
    {
        private List<Verb> records;

        public MainForm()
        {
            InitializeComponent();
            records = Reader.Read();

            foreach (Verb verb in records)
            {
                Console.WriteLine(verb.Infinitive + " - " + verb.Past + " " + verb.Participle + " " + verb.Meaning);
            }
        }
    }
}