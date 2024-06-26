﻿namespace Converter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btConvert = new Button();
            label1 = new Label();
            label2 = new Label();
            tbDbFormat = new TextBox();
            tbUUID = new TextBox();
            datePickerDataNasterii = new DateTimePicker();
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
            btnCopySupId = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnCopyPrenume = new Button();
            btnCopyCNP = new Button();
            btnCopyNUme = new Button();
            Length = new Label();
            btnCopyCUI = new Button();
            cbCUILength = new ComboBox();
            tbCui = new TextBox();
            label10 = new Label();
            lblAgeValue = new Label();
            label9 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btConvert
            // 
            btConvert.Location = new Point(408, 15);
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
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 1;
            label1.Text = "UUID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 48);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 2;
            label2.Text = "DB_FORMAT";
            // 
            // tbDbFormat
            // 
            tbDbFormat.Location = new Point(99, 44);
            tbDbFormat.Name = "tbDbFormat";
            tbDbFormat.Size = new Size(303, 23);
            tbDbFormat.TabIndex = 3;
            // 
            // tbUUID
            // 
            tbUUID.Location = new Point(99, 15);
            tbUUID.Name = "tbUUID";
            tbUUID.Size = new Size(303, 23);
            tbUUID.TabIndex = 1;
            // 
            // datePickerDataNasterii
            // 
            datePickerDataNasterii.Location = new Point(102, 22);
            datePickerDataNasterii.Name = "datePickerDataNasterii";
            datePickerDataNasterii.Size = new Size(105, 23);
            datePickerDataNasterii.TabIndex = 4;
            datePickerDataNasterii.Value = new DateTime(2006, 6, 3, 13, 29, 9, 824);
            datePickerDataNasterii.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // cbSex
            // 
            cbSex.FormattingEnabled = true;
            cbSex.Location = new Point(102, 50);
            cbSex.Name = "cbSex";
            cbSex.Size = new Size(105, 23);
            cbSex.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 26);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 7;
            label3.Text = "Data nasterii:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 54);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 8;
            label4.Text = "Sex:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 182);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 9;
            label5.Text = "CNP:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 206);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 10;
            label6.Text = "Nume:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 232);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 11;
            label7.Text = "Prenume";
            // 
            // tbCNP
            // 
            tbCNP.Location = new Point(98, 176);
            tbCNP.Name = "tbCNP";
            tbCNP.ReadOnly = true;
            tbCNP.Size = new Size(303, 23);
            tbCNP.TabIndex = 12;
            // 
            // tbNume
            // 
            tbNume.Location = new Point(98, 201);
            tbNume.Name = "tbNume";
            tbNume.ReadOnly = true;
            tbNume.Size = new Size(303, 23);
            tbNume.TabIndex = 13;
            // 
            // tbPrenume
            // 
            tbPrenume.Location = new Point(98, 225);
            tbPrenume.Name = "tbPrenume";
            tbPrenume.ReadOnly = true;
            tbPrenume.Size = new Size(303, 23);
            tbPrenume.TabIndex = 14;
            // 
            // btGenerate
            // 
            btGenerate.Location = new Point(102, 107);
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
            label8.Location = new Point(9, 82);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 16;
            label8.Text = "Judet:";
            // 
            // cbJudet
            // 
            cbJudet.FormattingEnabled = true;
            cbJudet.Location = new Point(102, 78);
            cbJudet.Name = "cbJudet";
            cbJudet.Size = new Size(105, 23);
            cbJudet.TabIndex = 6;
            // 
            // btnCopySupId
            // 
            btnCopySupId.Location = new Point(408, 43);
            btnCopySupId.Name = "btnCopySupId";
            btnCopySupId.Size = new Size(75, 23);
            btnCopySupId.TabIndex = 17;
            btnCopySupId.Text = "COPY";
            btnCopySupId.UseVisualStyleBackColor = true;
            btnCopySupId.Click += btnCopySuoId_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnCopySupId);
            groupBox1.Controls.Add(btConvert);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbDbFormat);
            groupBox1.Controls.Add(tbUUID);
            groupBox1.Location = new Point(25, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(490, 76);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "SupervisionID";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnCopyPrenume);
            groupBox2.Controls.Add(tbCNP);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(btnCopyCNP);
            groupBox2.Controls.Add(btnCopyNUme);
            groupBox2.Controls.Add(Length);
            groupBox2.Controls.Add(btnCopyCUI);
            groupBox2.Controls.Add(cbCUILength);
            groupBox2.Controls.Add(tbCui);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(lblAgeValue);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(datePickerDataNasterii);
            groupBox2.Controls.Add(cbSex);
            groupBox2.Controls.Add(cbJudet);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(btGenerate);
            groupBox2.Controls.Add(tbPrenume);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(tbNume);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(25, 94);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(490, 260);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Random data";
            // 
            // btnPrenumeCopy
            // 
            btnCopyPrenume.Location = new Point(406, 225);
            btnCopyPrenume.Name = "btnPrenumeCopy";
            btnCopyPrenume.Size = new Size(75, 23);
            btnCopyPrenume.TabIndex = 26;
            btnCopyPrenume.Text = "COPY";
            btnCopyPrenume.UseVisualStyleBackColor = true;
            btnCopyPrenume.Click += btnPrenumeCopy_Click;
            // 
            // btnCNPCopy
            // 
            btnCopyCNP.Location = new Point(406, 177);
            btnCopyCNP.Name = "btnCNPCopy";
            btnCopyCNP.Size = new Size(75, 23);
            btnCopyCNP.TabIndex = 24;
            btnCopyCNP.Text = "COPY";
            btnCopyCNP.UseVisualStyleBackColor = true;
            btnCopyCNP.Click += btnCNPCopy_Click;
            // 
            // btnNumeCopy
            // 
            btnCopyNUme.Location = new Point(406, 201);
            btnCopyNUme.Name = "btnNumeCopy";
            btnCopyNUme.Size = new Size(75, 23);
            btnCopyNUme.TabIndex = 25;
            btnCopyNUme.Text = "COPY";
            btnCopyNUme.UseVisualStyleBackColor = true;
            btnCopyNUme.Click += btnNumeCopy_Click;
            // 
            // Length
            // 
            Length.AutoSize = true;
            Length.Location = new Point(98, 151);
            Length.Name = "Length";
            Length.Size = new Size(58, 15);
            Length.TabIndex = 23;
            Length.Text = "Length = ";
            // 
            // btnCopyCUI
            // 
            btnCopyCUI.Location = new Point(406, 147);
            btnCopyCUI.Name = "btnCopyCUI";
            btnCopyCUI.Size = new Size(75, 23);
            btnCopyCUI.TabIndex = 22;
            btnCopyCUI.Text = "COPY";
            btnCopyCUI.UseVisualStyleBackColor = true;
            btnCopyCUI.Click += btnCopyCUI_Click;
            // 
            // cbCUILength
            // 
            cbCUILength.FormattingEnabled = true;
            cbCUILength.Location = new Point(162, 147);
            cbCUILength.Name = "cbCUILength";
            cbCUILength.Size = new Size(41, 23);
            cbCUILength.TabIndex = 21;
            // 
            // tbCui
            // 
            tbCui.Location = new Point(209, 147);
            tbCui.Name = "tbCui";
            tbCui.ReadOnly = true;
            tbCui.Size = new Size(192, 23);
            tbCui.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(9, 151);
            label10.Name = "label10";
            label10.Size = new Size(29, 15);
            label10.TabIndex = 19;
            label10.Text = "CUI:";
            // 
            // lblAgeValue
            // 
            lblAgeValue.AutoSize = true;
            lblAgeValue.Location = new Point(260, 26);
            lblAgeValue.Name = "lblAgeValue";
            lblAgeValue.Size = new Size(105, 15);
            lblAgeValue.TabIndex = 18;
            lblAgeValue.Text = "18 ani, 0 luni, 6 zile";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(213, 26);
            label9.Name = "label9";
            label9.Size = new Size(41, 15);
            label9.TabIndex = 17;
            label9.Text = "Varsta:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 377);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Converter";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btConvert;
        private Label label1;
        private Label label2;
        private TextBox tbDbFormat;
        private TextBox tbUUID;
        private DateTimePicker datePickerDataNasterii;
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
        private Button btnCopySupId;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label lblAgeValue;
        private Label label9;
        private Label label10;
        private TextBox tbCui;
        private ComboBox cbCUILength;
        private Button btnCopyCUI;
        private Label Length;
        private GroupBox groupBox3;
        private Button btnCopyCNP;
        private Button button2;
        private Button btnCopyNUme;
        private Button btnCopyPrenume;
    }
}