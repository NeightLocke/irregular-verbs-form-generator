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
        private Image check = Image.FromFile(@".\Resources\check.png");
        private Image wrong = Image.FromFile(@".\Resources\wrong.png");
        private Image question = Image.FromFile(@".\Resources\question-mark.png");

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
            infinitivePicture.Image = question;
            pastPicture.Image = question;
            participlePicture.Image = question;

            infinitiveBox.Clear();
            pastBox.Clear();
            participleBox.Clear();
            meaningBox.Clear();
            resultMeaning.Clear();

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
            KeyBtnControl.Enabled = true;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            infinitiveBox.Clear();
            pastBox.Clear();
            participleBox.Clear();
            meaningBox.Clear();
            resultMeaning.Clear();
            CheckVerbsBtnControl.Enabled = false;
            KeyBtnControl.Enabled = false;
            infinitivePicture.Image = question;
            pastPicture.Image = question;
            participlePicture.Image = question;
            currentVerb = null;
        }

        private void CheckVerbs_Click(object sender, EventArgs e)
        {
            infinitivePicture.Image = infinitiveBox.Text.Equals(currentVerb.Infinitive) ? check : wrong;
            pastPicture.Image = pastBox.Text.Equals(currentVerb.Past) ? check : wrong;
            participlePicture.Image = participleBox.Text.Equals(currentVerb.Participle) ? check : wrong;

            resultMeaning.Text = currentVerb.Meaning;
        }

        private void KeyBtnControl_Click(object sender, EventArgs e)
        {
            if (currentVerb != null)
            {
                infinitiveBox.Text = currentVerb.Infinitive;
                pastBox.Text = currentVerb.Past;
                participleBox.Text = currentVerb.Participle;
                meaningBox.Text = currentVerb.Meaning;
            }
        }
    }
}