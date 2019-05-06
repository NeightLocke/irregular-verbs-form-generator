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
        private static Random rnd = new Random();
        private Verb currentVerb;

        public MainForm()
        {
            InitializeComponent();
            records = Reader.ReadFields();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void GetVerbBtnControl_Click(object sender, EventArgs e)
        {
            infinitiveBox.Clear();
            pastBox.Clear();
            participleBox.Clear();
            meaningBox.Clear();

            int r = rnd.Next(records.Count);
            currentVerb = records[r];
            int position = rnd.Next(3); // Se hace sobre 3 xq solo se rellenarán las columnas de infinitivo, pasado y participio

            switch (position)
            {
                case 0:
                    infinitiveBox.Text = currentVerb.Infinitive;
                    break;

                case 1:
                    pastBox.Text = currentVerb.Past;
                    break;

                case 2:
                    participleBox.Text = currentVerb.Participle;
                    break;

                default:
                    MessageBox.Show("Something went wrong");
                    break;
            }

            CheckVerbsBtnControl.Enabled = true;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            infinitiveBox.Clear();
            pastBox.Clear();
            participleBox.Clear();
            meaningBox.Clear();
            CheckVerbsBtnControl.Enabled = false;
        }

        private void CheckVerbs_Click(object sender, EventArgs e)
        {
            if ((infinitiveBox.Text.Equals(currentVerb.Infinitive)) &&
                (pastBox.Text.Equals(currentVerb.Past)) &&
                (participleBox.Text.Equals(currentVerb.Participle)))
            {
                MessageBox.Show("The answer is correct");
            }
            else
            {
                MessageBox.Show("The answer is wrong");
            }
        }
    }
}