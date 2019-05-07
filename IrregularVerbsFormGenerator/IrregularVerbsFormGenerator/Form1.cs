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
        private Image checkImage = Image.FromFile(@".\Resources\check.png");
        private Image wrongImage = Image.FromFile(@".\Resources\wrong.png");
        private Image questionImage = Image.FromFile(@".\Resources\question-mark.png");
        private Dictionary<string, Result> results = new Dictionary<string, Result>();

        public MainForm()
        {
            InitializeComponent();
            try
            {
                records = Reader.ReadFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void GetVerbBtnControl_Click(object sender, EventArgs e)
        {
            infinitivePicture.Image = questionImage;
            pastPicture.Image = questionImage;
            participlePicture.Image = questionImage;

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
            infinitivePicture.Image = questionImage;
            pastPicture.Image = questionImage;
            participlePicture.Image = questionImage;
            currentVerb = null;
            SummaryBox.Clear();
        }

        private void CheckVerbs_Click(object sender, EventArgs e)
        {
            bool wrongAttempt = false;
            infinitivePicture.Image = infinitiveBox.Text.Equals(currentVerb.Infinitive) ? checkImage : wrongImage;
            pastPicture.Image = pastBox.Text.Equals(currentVerb.Past) ? checkImage : wrongImage;
            participlePicture.Image = participleBox.Text.Equals(currentVerb.Participle) ? checkImage : wrongImage;

            resultMeaning.Text = currentVerb.Meaning;

            if (!infinitiveBox.Text.Equals(currentVerb.Infinitive) ||
                !pastBox.Text.Equals(currentVerb.Past) ||
                !participleBox.Text.Equals(currentVerb.Participle))
            {
                wrongAttempt = true;
            }

            if (results.ContainsKey(currentVerb.Infinitive))
            {
                results[currentVerb.Infinitive].NumAttempts++;
                if (wrongAttempt)
                {
                    results[currentVerb.Infinitive].WrongAttempts++;
                }
            }
            else
            {
                Result verbResult = new Result()
                {
                    Verb = currentVerb,
                    NumAttempts = 1,
                };
                if (wrongAttempt)
                {
                    verbResult.WrongAttempts = 1;
                }
                results.Add(currentVerb.Infinitive, verbResult);
            }
        }

        private void KeyBtnControl_Click(object sender, EventArgs e)
        {
            if (currentVerb != null)
            {
                infinitiveBox.Text = currentVerb.Infinitive;
                pastBox.Text = currentVerb.Past;
                participleBox.Text = currentVerb.Participle;
                resultMeaning.Text = currentVerb.Meaning;

                if (results.ContainsKey(currentVerb.Infinitive))
                {
                    results[currentVerb.Infinitive].NumAttempts++;
                    results[currentVerb.Infinitive].WrongAttempts++;
                    results[currentVerb.Infinitive].ClueUsed = true;
                }
                else
                {
                    Result verbResult = new Result()
                    {
                        Verb = currentVerb,
                        NumAttempts = 1,
                        WrongAttempts = 1,
                        ClueUsed = true,
                    };
                    results.Add(currentVerb.Infinitive, verbResult);
                }
            }
        }

        private void DoneBtnControl_Click(object sender, EventArgs e)
        {
            SummaryBox.Clear();
            foreach (var currentResult in results)
            {
                SummaryBox.Text +=
                    "Verb : " + currentResult.Key + "\r\n" +
                    "NumAttempts : " + currentResult.Value.NumAttempts + "\r\n" +
                    "WrongAttempts : " + currentResult.Value.WrongAttempts + "\r\n" +
                    "ClueUsed : " + currentResult.Value.ClueUsed.ToString().ToUpper() + "\r\n" + "\r\n";
            }

            if (results.Count > 0)
            {
                try
                {
                    Reader.WriteFields(results);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DeleleAllBtnControl_Click(object sender, EventArgs e)
        {
            infinitiveBox.Clear();
            pastBox.Clear();
            participleBox.Clear();
            meaningBox.Clear();
            resultMeaning.Clear();
            CheckVerbsBtnControl.Enabled = false;
            KeyBtnControl.Enabled = false;
            infinitivePicture.Image = questionImage;
            pastPicture.Image = questionImage;
            participlePicture.Image = questionImage;
            currentVerb = null;
            SummaryBox.Clear();
            currentVerb = null;
            results = new Dictionary<string, Result>();
            // En el DeleteAll tengo que volver a cargar la lista original de verbos
            try
            {
                records = Reader.ReadFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}