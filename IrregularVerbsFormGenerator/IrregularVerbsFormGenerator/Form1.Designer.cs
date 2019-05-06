namespace IrregularVerbsFormGenerator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.infinitiveBox = new System.Windows.Forms.TextBox();
            this.pastBox = new System.Windows.Forms.TextBox();
            this.participleBox = new System.Windows.Forms.TextBox();
            this.meaningBox = new System.Windows.Forms.TextBox();
            this.GetVerbBtnControl = new System.Windows.Forms.Button();
            this.ClearBtnControl = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.CheckVerbsBtnControl = new System.Windows.Forms.Button();
            this.infinitivePicture = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.infinitivePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Infinitive";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Past";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Participle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Meaning";
            // 
            // infinitiveBox
            // 
            this.infinitiveBox.Location = new System.Drawing.Point(12, 34);
            this.infinitiveBox.Name = "infinitiveBox";
            this.infinitiveBox.Size = new System.Drawing.Size(100, 20);
            this.infinitiveBox.TabIndex = 4;
            // 
            // pastBox
            // 
            this.pastBox.Location = new System.Drawing.Point(12, 85);
            this.pastBox.Name = "pastBox";
            this.pastBox.Size = new System.Drawing.Size(100, 20);
            this.pastBox.TabIndex = 5;
            // 
            // participleBox
            // 
            this.participleBox.Location = new System.Drawing.Point(12, 148);
            this.participleBox.Name = "participleBox";
            this.participleBox.Size = new System.Drawing.Size(100, 20);
            this.participleBox.TabIndex = 6;
            // 
            // meaningBox
            // 
            this.meaningBox.Location = new System.Drawing.Point(12, 214);
            this.meaningBox.Name = "meaningBox";
            this.meaningBox.Size = new System.Drawing.Size(100, 20);
            this.meaningBox.TabIndex = 7;
            // 
            // GetVerbBtnControl
            // 
            this.GetVerbBtnControl.Location = new System.Drawing.Point(326, 85);
            this.GetVerbBtnControl.Name = "GetVerbBtnControl";
            this.GetVerbBtnControl.Size = new System.Drawing.Size(75, 23);
            this.GetVerbBtnControl.TabIndex = 8;
            this.GetVerbBtnControl.Text = "Get Verb";
            this.GetVerbBtnControl.UseVisualStyleBackColor = true;
            this.GetVerbBtnControl.Click += new System.EventHandler(this.GetVerbBtnControl_Click);
            // 
            // ClearBtnControl
            // 
            this.ClearBtnControl.Location = new System.Drawing.Point(326, 34);
            this.ClearBtnControl.Name = "ClearBtnControl";
            this.ClearBtnControl.Size = new System.Drawing.Size(75, 23);
            this.ClearBtnControl.TabIndex = 9;
            this.ClearBtnControl.Text = "Clear";
            this.ClearBtnControl.UseVisualStyleBackColor = true;
            this.ClearBtnControl.Click += new System.EventHandler(this.Clear_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // CheckVerbsBtnControl
            // 
            this.CheckVerbsBtnControl.Enabled = false;
            this.CheckVerbsBtnControl.Location = new System.Drawing.Point(325, 321);
            this.CheckVerbsBtnControl.Name = "CheckVerbsBtnControl";
            this.CheckVerbsBtnControl.Size = new System.Drawing.Size(75, 23);
            this.CheckVerbsBtnControl.TabIndex = 10;
            this.CheckVerbsBtnControl.Text = "Check";
            this.CheckVerbsBtnControl.UseVisualStyleBackColor = true;
            this.CheckVerbsBtnControl.Click += new System.EventHandler(this.CheckVerbs_Click);
            // 
            // infinitivePicture
            // 
            this.infinitivePicture.Image = ((System.Drawing.Image)(resources.GetObject("infinitivePicture.Image")));
            this.infinitivePicture.Location = new System.Drawing.Point(118, 19);
            this.infinitivePicture.Name = "infinitivePicture";
            this.infinitivePicture.Size = new System.Drawing.Size(50, 50);
            this.infinitivePicture.TabIndex = 11;
            this.infinitivePicture.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(118, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(118, 131);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 356);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.infinitivePicture);
            this.Controls.Add(this.CheckVerbsBtnControl);
            this.Controls.Add(this.ClearBtnControl);
            this.Controls.Add(this.GetVerbBtnControl);
            this.Controls.Add(this.meaningBox);
            this.Controls.Add(this.participleBox);
            this.Controls.Add(this.pastBox);
            this.Controls.Add(this.infinitiveBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Irregular Verbs Form Generator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.infinitivePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox infinitiveBox;
        private System.Windows.Forms.TextBox pastBox;
        private System.Windows.Forms.TextBox participleBox;
        private System.Windows.Forms.TextBox meaningBox;
        private System.Windows.Forms.Button GetVerbBtnControl;
        private System.Windows.Forms.Button ClearBtnControl;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button CheckVerbsBtnControl;
        private System.Windows.Forms.PictureBox infinitivePicture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

