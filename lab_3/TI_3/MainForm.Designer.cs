namespace TI_3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileCipher = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFilePlain = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFilePlain = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileCipher = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.LabelP = new System.Windows.Forms.Label();
            this.TextBoxP = new System.Windows.Forms.TextBox();
            this.TextBoxQ = new System.Windows.Forms.TextBox();
            this.LabelQ = new System.Windows.Forms.Label();
            this.TextBoxR = new System.Windows.Forms.TextBox();
            this.LabelR = new System.Windows.Forms.Label();
            this.ButtonR = new System.Windows.Forms.Button();
            this.LabelD = new System.Windows.Forms.Label();
            this.TextBoxD = new System.Windows.Forms.TextBox();
            this.EulerLabel = new System.Windows.Forms.Label();
            this.TextBoxEuler = new System.Windows.Forms.TextBox();
            this.RadioButtonCipher = new System.Windows.Forms.RadioButton();
            this.RadioButtonDecipher = new System.Windows.Forms.RadioButton();
            this.TextBoxE = new System.Windows.Forms.TextBox();
            this.LabelE = new System.Windows.Forms.Label();
            this.PlainText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelCipher = new System.Windows.Forms.Label();
            this.CipherText = new System.Windows.Forms.TextBox();
            this.ResultButton = new System.Windows.Forms.Button();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.ClearStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(869, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFile,
            this.SaveFile});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // OpenFile
            // 
            this.OpenFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFileCipher,
            this.OpenFilePlain});
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(217, 26);
            this.OpenFile.Text = "Открыть файл";
            // 
            // OpenFileCipher
            // 
            this.OpenFileCipher.Enabled = false;
            this.OpenFileCipher.Name = "OpenFileCipher";
            this.OpenFileCipher.Size = new System.Drawing.Size(283, 26);
            this.OpenFileCipher.Text = "С зашифрованным текстом";
            this.OpenFileCipher.Click += new System.EventHandler(this.OpenFileCipher_Click);
            // 
            // OpenFilePlain
            // 
            this.OpenFilePlain.Name = "OpenFilePlain";
            this.OpenFilePlain.Size = new System.Drawing.Size(283, 26);
            this.OpenFilePlain.Text = "С исходным текстом";
            this.OpenFilePlain.Click += new System.EventHandler(this.OpenFilePlain_Click);
            // 
            // SaveFile
            // 
            this.SaveFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveFilePlain,
            this.SaveFileCipher});
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(217, 26);
            this.SaveFile.Text = "Сохранить в файл";
            // 
            // SaveFilePlain
            // 
            this.SaveFilePlain.Enabled = false;
            this.SaveFilePlain.Name = "SaveFilePlain";
            this.SaveFilePlain.Size = new System.Drawing.Size(326, 26);
            this.SaveFilePlain.Text = "Сохранить исходный текст";
            this.SaveFilePlain.Click += new System.EventHandler(this.SaveFilePlain_Click);
            // 
            // SaveFileCipher
            // 
            this.SaveFileCipher.Name = "SaveFileCipher";
            this.SaveFileCipher.Size = new System.Drawing.Size(326, 26);
            this.SaveFileCipher.Text = "Сохранить зашифрованный текст";
            this.SaveFileCipher.Click += new System.EventHandler(this.SaveFileCipher_Click);
            // 
            // ClearStrip
            // 
            this.ClearStrip.Name = "ClearStrip";
            this.ClearStrip.Size = new System.Drawing.Size(125, 24);
            this.ClearStrip.Text = "Очистить поля";
            this.ClearStrip.Click += new System.EventHandler(this.ClearStrip_Click);
            // 
            // LabelP
            // 
            this.LabelP.Location = new System.Drawing.Point(5, 19);
            this.LabelP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelP.Name = "LabelP";
            this.LabelP.Size = new System.Drawing.Size(122, 27);
            this.LabelP.TabIndex = 1;
            this.LabelP.Text = "P:";
            // 
            // TextBoxP
            // 
            this.TextBoxP.Location = new System.Drawing.Point(38, 16);
            this.TextBoxP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextBoxP.Name = "TextBoxP";
            this.TextBoxP.Size = new System.Drawing.Size(270, 30);
            this.TextBoxP.TabIndex = 2;
            this.TextBoxP.TextChanged += new System.EventHandler(this.ClearStrip_Click);
            // 
            // TextBoxQ
            // 
            this.TextBoxQ.Location = new System.Drawing.Point(38, 54);
            this.TextBoxQ.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextBoxQ.Name = "TextBoxQ";
            this.TextBoxQ.Size = new System.Drawing.Size(270, 30);
            this.TextBoxQ.TabIndex = 4;
            this.TextBoxQ.TextChanged += new System.EventHandler(this.ClearStrip_Click);
            // 
            // LabelQ
            // 
            this.LabelQ.Location = new System.Drawing.Point(5, 58);
            this.LabelQ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelQ.Name = "LabelQ";
            this.LabelQ.Size = new System.Drawing.Size(32, 27);
            this.LabelQ.TabIndex = 3;
            this.LabelQ.Text = "Q:";
            // 
            // TextBoxR
            // 
            this.TextBoxR.Location = new System.Drawing.Point(391, 16);
            this.TextBoxR.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextBoxR.Multiline = true;
            this.TextBoxR.Name = "TextBoxR";
            this.TextBoxR.ReadOnly = true;
            this.TextBoxR.Size = new System.Drawing.Size(239, 31);
            this.TextBoxR.TabIndex = 5;
            // 
            // LabelR
            // 
            this.LabelR.Location = new System.Drawing.Point(359, 16);
            this.LabelR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelR.Name = "LabelR";
            this.LabelR.Size = new System.Drawing.Size(31, 31);
            this.LabelR.TabIndex = 6;
            this.LabelR.Text = "R:";
            // 
            // ButtonR
            // 
            this.ButtonR.Location = new System.Drawing.Point(9, 177);
            this.ButtonR.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonR.Name = "ButtonR";
            this.ButtonR.Size = new System.Drawing.Size(214, 35);
            this.ButtonR.TabIndex = 7;
            this.ButtonR.Text = "Рассчитать параметры";
            this.ButtonR.UseVisualStyleBackColor = true;
            this.ButtonR.Click += new System.EventHandler(this.ButtonR_Click);
            // 
            // LabelD
            // 
            this.LabelD.Location = new System.Drawing.Point(5, 101);
            this.LabelD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelD.Name = "LabelD";
            this.LabelD.Size = new System.Drawing.Size(211, 27);
            this.LabelD.TabIndex = 8;
            this.LabelD.Text = "Закрытая константа D:";
            // 
            // TextBoxD
            // 
            this.TextBoxD.Location = new System.Drawing.Point(38, 131);
            this.TextBoxD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextBoxD.Name = "TextBoxD";
            this.TextBoxD.Size = new System.Drawing.Size(270, 30);
            this.TextBoxD.TabIndex = 9;
            this.TextBoxD.TextChanged += new System.EventHandler(this.ClearStrip_Click);
            // 
            // EulerLabel
            // 
            this.EulerLabel.Location = new System.Drawing.Point(332, 54);
            this.EulerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EulerLabel.Name = "EulerLabel";
            this.EulerLabel.Size = new System.Drawing.Size(57, 31);
            this.EulerLabel.TabIndex = 10;
            this.EulerLabel.Text = "φ(R):";
            // 
            // TextBoxEuler
            // 
            this.TextBoxEuler.Location = new System.Drawing.Point(391, 54);
            this.TextBoxEuler.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextBoxEuler.Multiline = true;
            this.TextBoxEuler.Name = "TextBoxEuler";
            this.TextBoxEuler.ReadOnly = true;
            this.TextBoxEuler.Size = new System.Drawing.Size(239, 31);
            this.TextBoxEuler.TabIndex = 11;
            // 
            // RadioButtonCipher
            // 
            this.RadioButtonCipher.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RadioButtonCipher.Checked = true;
            this.RadioButtonCipher.Location = new System.Drawing.Point(13, 16);
            this.RadioButtonCipher.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RadioButtonCipher.Name = "RadioButtonCipher";
            this.RadioButtonCipher.Size = new System.Drawing.Size(141, 30);
            this.RadioButtonCipher.TabIndex = 12;
            this.RadioButtonCipher.TabStop = true;
            this.RadioButtonCipher.Text = "Шифрация";
            this.RadioButtonCipher.UseVisualStyleBackColor = true;
            this.RadioButtonCipher.CheckedChanged += new System.EventHandler(this.RadioButtonCipher_CheckedChanged);
            // 
            // RadioButtonDecipher
            // 
            this.RadioButtonDecipher.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RadioButtonDecipher.Location = new System.Drawing.Point(11, 54);
            this.RadioButtonDecipher.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RadioButtonDecipher.Name = "RadioButtonDecipher";
            this.RadioButtonDecipher.Size = new System.Drawing.Size(143, 31);
            this.RadioButtonDecipher.TabIndex = 13;
            this.RadioButtonDecipher.Text = "Дешифрация";
            this.RadioButtonDecipher.UseVisualStyleBackColor = true;
            this.RadioButtonDecipher.CheckedChanged += new System.EventHandler(this.RadioButtonDecipher_CheckedChanged);
            // 
            // TextBoxE
            // 
            this.TextBoxE.Location = new System.Drawing.Point(391, 131);
            this.TextBoxE.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextBoxE.Multiline = true;
            this.TextBoxE.Name = "TextBoxE";
            this.TextBoxE.ReadOnly = true;
            this.TextBoxE.Size = new System.Drawing.Size(239, 31);
            this.TextBoxE.TabIndex = 14;
            // 
            // LabelE
            // 
            this.LabelE.Location = new System.Drawing.Point(332, 99);
            this.LabelE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelE.Name = "LabelE";
            this.LabelE.Size = new System.Drawing.Size(213, 29);
            this.LabelE.TabIndex = 15;
            this.LabelE.Text = "Открытая константа E:";
            // 
            // PlainText
            // 
            this.PlainText.Location = new System.Drawing.Point(40, 45);
            this.PlainText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PlainText.Multiline = true;
            this.PlainText.Name = "PlainText";
            this.PlainText.ReadOnly = true;
            this.PlainText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PlainText.Size = new System.Drawing.Size(590, 121);
            this.PlainText.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 27);
            this.label1.TabIndex = 17;
            this.label1.Text = "Исходный текст:";
            // 
            // LabelCipher
            // 
            this.LabelCipher.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCipher.Location = new System.Drawing.Point(7, 181);
            this.LabelCipher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelCipher.Name = "LabelCipher";
            this.LabelCipher.Size = new System.Drawing.Size(264, 27);
            this.LabelCipher.TabIndex = 18;
            this.LabelCipher.Text = "Зашифрованный текст:";
            // 
            // CipherText
            // 
            this.CipherText.Location = new System.Drawing.Point(40, 211);
            this.CipherText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CipherText.Multiline = true;
            this.CipherText.Name = "CipherText";
            this.CipherText.ReadOnly = true;
            this.CipherText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CipherText.Size = new System.Drawing.Size(590, 130);
            this.CipherText.TabIndex = 19;
            // 
            // ResultButton
            // 
            this.ResultButton.Enabled = false;
            this.ResultButton.Location = new System.Drawing.Point(13, 94);
            this.ResultButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ResultButton.Name = "ResultButton";
            this.ResultButton.Size = new System.Drawing.Size(141, 30);
            this.ResultButton.TabIndex = 20;
            this.ResultButton.Text = "Зашифровать";
            this.ResultButton.UseVisualStyleBackColor = true;
            this.ResultButton.Click += new System.EventHandler(this.ResultButton_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.RadioButtonCipher);
            this.panel1.Controls.Add(this.ResultButton);
            this.panel1.Controls.Add(this.RadioButtonDecipher);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 576);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PeachPuff;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.TextBoxP);
            this.panel2.Controls.Add(this.LabelP);
            this.panel2.Controls.Add(this.LabelQ);
            this.panel2.Controls.Add(this.TextBoxQ);
            this.panel2.Controls.Add(this.TextBoxR);
            this.panel2.Controls.Add(this.LabelR);
            this.panel2.Controls.Add(this.LabelE);
            this.panel2.Controls.Add(this.ButtonR);
            this.panel2.Controls.Add(this.TextBoxE);
            this.panel2.Controls.Add(this.LabelD);
            this.panel2.Controls.Add(this.TextBoxEuler);
            this.panel2.Controls.Add(this.TextBoxD);
            this.panel2.Controls.Add(this.EulerLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(669, 225);
            this.panel2.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.PlainText);
            this.panel3.Controls.Add(this.LabelCipher);
            this.panel3.Controls.Add(this.CipherText);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(200, 253);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(669, 351);
            this.panel3.TabIndex = 23;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(869, 604);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ТИ Лаб №3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;

        private System.Windows.Forms.Button ResultButton;

        private System.Windows.Forms.TextBox PlainText;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelCipher;

        private System.Windows.Forms.TextBox CipherText;

        private System.Windows.Forms.Label LabelD;

        private System.Windows.Forms.TextBox TextBoxD;

        private System.Windows.Forms.RadioButton RadioButtonCipher;
        private System.Windows.Forms.RadioButton RadioButtonDecipher;

        private System.Windows.Forms.Label EulerLabel;

        private System.Windows.Forms.TextBox TextBoxE;

        private System.Windows.Forms.Label LabelE;
        private System.Windows.Forms.TextBox TextBoxEuler;

        private System.Windows.Forms.Button ButtonR;
        private System.Windows.Forms.ToolStripMenuItem SaveFile;
        private System.Windows.Forms.ToolStripMenuItem SaveFilePlain;
        private System.Windows.Forms.ToolStripMenuItem SaveFileCipher;
        private System.Windows.Forms.ToolStripMenuItem OpenFile;
        private System.Windows.Forms.ToolStripMenuItem OpenFileCipher;
        private System.Windows.Forms.ToolStripMenuItem OpenFilePlain;
        private System.Windows.Forms.Label LabelP;
        private System.Windows.Forms.TextBox TextBoxP;
        private System.Windows.Forms.TextBox TextBoxQ;
        private System.Windows.Forms.Label LabelQ;
        private System.Windows.Forms.TextBox TextBoxR;
        private System.Windows.Forms.Label LabelR;

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClearStrip;

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}