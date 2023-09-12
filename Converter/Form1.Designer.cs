namespace Converter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btConvert = new Button();
            label1 = new Label();
            label2 = new Label();
            tbDbFormat = new TextBox();
            tbUUID = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            cbSex = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            tbCNP = new TextBox();
            tbNume = new TextBox();
            tbPrenume = new TextBox();
            btGenerate = new Button();
            label8 = new Label();
            cbJudet = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // btConvert
            // 
            btConvert.Location = new Point(427, 23);
            btConvert.Name = "btConvert";
            btConvert.Size = new Size(75, 23);
            btConvert.TabIndex = 2;
            btConvert.Text = "CONVERT";
            btConvert.UseVisualStyleBackColor = true;
            btConvert.Click += btConvert_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 27);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 1;
            label1.Text = "UUID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(524, 27);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 2;
            label2.Text = "DB_FORMAT";
            // 
            // tbDbFormat
            // 
            tbDbFormat.Location = new Point(617, 23);
            tbDbFormat.Name = "tbDbFormat";
            tbDbFormat.Size = new Size(303, 23);
            tbDbFormat.TabIndex = 3;
            // 
            // tbUUID
            // 
            tbUUID.Location = new Point(118, 23);
            tbUUID.Name = "tbUUID";
            tbUUID.Size = new Size(303, 23);
            tbUUID.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(118, 57);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(105, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // cbSex
            // 
            cbSex.FormattingEnabled = true;
            cbSex.Location = new Point(118, 86);
            cbSex.Name = "cbSex";
            cbSex.Size = new Size(105, 23);
            cbSex.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 61);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 7;
            label3.Text = "Data nasterii:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 90);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 8;
            label4.Text = "Sex:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 177);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 9;
            label5.Text = "CNP:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 202);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 10;
            label6.Text = "Nume:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 227);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 11;
            label7.Text = "Prenume";
            // 
            // tbCNP
            // 
            tbCNP.Location = new Point(118, 173);
            tbCNP.Name = "tbCNP";
            tbCNP.ReadOnly = true;
            tbCNP.Size = new Size(303, 23);
            tbCNP.TabIndex = 12;
            // 
            // tbNume
            // 
            tbNume.Location = new Point(118, 198);
            tbNume.Name = "tbNume";
            tbNume.ReadOnly = true;
            tbNume.Size = new Size(303, 23);
            tbNume.TabIndex = 13;
            // 
            // tbPrenume
            // 
            tbPrenume.Location = new Point(118, 223);
            tbPrenume.Name = "tbPrenume";
            tbPrenume.ReadOnly = true;
            tbPrenume.Size = new Size(303, 23);
            tbPrenume.TabIndex = 14;
            // 
            // btGenerate
            // 
            btGenerate.Location = new Point(118, 144);
            btGenerate.Name = "btGenerate";
            btGenerate.Size = new Size(75, 23);
            btGenerate.TabIndex = 7;
            btGenerate.Text = "GENERATE";
            btGenerate.UseVisualStyleBackColor = true;
            btGenerate.Click += btGenerateClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(25, 121);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 16;
            label8.Text = "Judet:";
            // 
            // cbJudet
            // 
            cbJudet.FormattingEnabled = true;
            cbJudet.Location = new Point(118, 115);
            cbJudet.Name = "cbJudet";
            cbJudet.Size = new Size(105, 23);
            cbJudet.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(926, 22);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 17;
            button1.Text = "COPY";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 293);
            Controls.Add(button1);
            Controls.Add(cbJudet);
            Controls.Add(label8);
            Controls.Add(btGenerate);
            Controls.Add(tbPrenume);
            Controls.Add(tbNume);
            Controls.Add(tbCNP);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cbSex);
            Controls.Add(dateTimePicker1);
            Controls.Add(tbUUID);
            Controls.Add(tbDbFormat);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btConvert);
            Name = "Form1";
            Text = "Converter";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btConvert;
        private Label label1;
        private Label label2;
        private TextBox tbDbFormat;
        private TextBox tbUUID;
        private DateTimePicker dateTimePicker1;
        private ComboBox cbSex;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox tbCNP;
        private TextBox tbNume;
        private TextBox tbPrenume;
        private Button btGenerate;
        private Label label8;
        private ComboBox cbJudet;
        private Button button1;
    }
}