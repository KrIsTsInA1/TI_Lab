namespace theory_information_lab2
{
    partial class fMain
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
            this.btnEncryption = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.lResultKey = new System.Windows.Forms.Label();
            this.tbResultKey = new System.Windows.Forms.TextBox();
            this.tbSourceData = new System.Windows.Forms.TextBox();
            this.lSourceData = new System.Windows.Forms.Label();
            this.tbResultData = new System.Windows.Forms.TextBox();
            this.lResultData = new System.Windows.Forms.Label();
            this.lKey = new System.Windows.Forms.Label();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.btnClearKey = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEncryption
            // 
            this.btnEncryption.BackColor = System.Drawing.Color.Moccasin;
            this.btnEncryption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncryption.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnEncryption.Location = new System.Drawing.Point(968, 173);
            this.btnEncryption.Name = "btnEncryption";
            this.btnEncryption.Size = new System.Drawing.Size(165, 47);
            this.btnEncryption.TabIndex = 4;
            this.btnEncryption.Text = "Выполнить";
            this.btnEncryption.UseVisualStyleBackColor = false;
            this.btnEncryption.Click += new System.EventHandler(this.btnEncryption_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearAll.BackColor = System.Drawing.Color.Moccasin;
            this.btnClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnClearAll.Location = new System.Drawing.Point(968, 226);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(165, 47);
            this.btnClearAll.TabIndex = 3;
            this.btnClearAll.Text = "Очистить всё";
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.BackColor = System.Drawing.Color.Moccasin;
            this.btnSaveFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveFile.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnSaveFile.Location = new System.Drawing.Point(16, 570);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(165, 47);
            this.btnSaveFile.TabIndex = 1;
            this.btnSaveFile.Text = "Сохранить";
            this.btnSaveFile.UseVisualStyleBackColor = false;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.BackColor = System.Drawing.Color.Moccasin;
            this.btnOpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFile.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnOpenFile.Location = new System.Drawing.Point(968, 32);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(165, 47);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "Открыть файл";
            this.btnOpenFile.UseVisualStyleBackColor = false;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "enc";
            // 
            // lResultKey
            // 
            this.lResultKey.AutoSize = true;
            this.lResultKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lResultKey.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lResultKey.Location = new System.Drawing.Point(12, 148);
            this.lResultKey.Name = "lResultKey";
            this.lResultKey.Size = new System.Drawing.Size(234, 20);
            this.lResultKey.TabIndex = 7;
            this.lResultKey.Text = "Сгенерированный ключ:";
            // 
            // tbResultKey
            // 
            this.tbResultKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbResultKey.BackColor = System.Drawing.Color.SeaShell;
            this.tbResultKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbResultKey.ForeColor = System.Drawing.Color.SaddleBrown;
            this.tbResultKey.Location = new System.Drawing.Point(16, 173);
            this.tbResultKey.Multiline = true;
            this.tbResultKey.Name = "tbResultKey";
            this.tbResultKey.ReadOnly = true;
            this.tbResultKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbResultKey.Size = new System.Drawing.Size(946, 100);
            this.tbResultKey.TabIndex = 8;
            // 
            // tbSourceData
            // 
            this.tbSourceData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSourceData.BackColor = System.Drawing.Color.SeaShell;
            this.tbSourceData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSourceData.ForeColor = System.Drawing.Color.SaddleBrown;
            this.tbSourceData.Location = new System.Drawing.Point(16, 313);
            this.tbSourceData.Multiline = true;
            this.tbSourceData.Name = "tbSourceData";
            this.tbSourceData.ReadOnly = true;
            this.tbSourceData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbSourceData.Size = new System.Drawing.Size(946, 100);
            this.tbSourceData.TabIndex = 10;
            this.tbSourceData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbKey_KeyDown);
            this.tbSourceData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKey_KeyPress);
            this.tbSourceData.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbKey_KeyUp);
            // 
            // lSourceData
            // 
            this.lSourceData.AutoSize = true;
            this.lSourceData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSourceData.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lSourceData.Location = new System.Drawing.Point(12, 290);
            this.lSourceData.Name = "lSourceData";
            this.lSourceData.Size = new System.Drawing.Size(181, 20);
            this.lSourceData.TabIndex = 9;
            this.lSourceData.Text = "Исходные данные:";
            // 
            // tbResultData
            // 
            this.tbResultData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbResultData.BackColor = System.Drawing.Color.SeaShell;
            this.tbResultData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbResultData.ForeColor = System.Drawing.Color.SaddleBrown;
            this.tbResultData.Location = new System.Drawing.Point(16, 458);
            this.tbResultData.Multiline = true;
            this.tbResultData.Name = "tbResultData";
            this.tbResultData.ReadOnly = true;
            this.tbResultData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbResultData.Size = new System.Drawing.Size(946, 96);
            this.tbResultData.TabIndex = 12;
            // 
            // lResultData
            // 
            this.lResultData.AutoSize = true;
            this.lResultData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lResultData.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lResultData.Location = new System.Drawing.Point(12, 435);
            this.lResultData.Name = "lResultData";
            this.lResultData.Size = new System.Drawing.Size(186, 20);
            this.lResultData.TabIndex = 11;
            this.lResultData.Text = "Результат работы:";
            // 
            // lKey
            // 
            this.lKey.AutoSize = true;
            this.lKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lKey.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lKey.Location = new System.Drawing.Point(12, 9);
            this.lKey.Name = "lKey";
            this.lKey.Size = new System.Drawing.Size(57, 20);
            this.lKey.TabIndex = 13;
            this.lKey.Text = "Ключ";
            // 
            // tbKey
            // 
            this.tbKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbKey.BackColor = System.Drawing.Color.SeaShell;
            this.tbKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKey.ForeColor = System.Drawing.Color.SaddleBrown;
            this.tbKey.Location = new System.Drawing.Point(16, 32);
            this.tbKey.Multiline = true;
            this.tbKey.Name = "tbKey";
            this.tbKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbKey.Size = new System.Drawing.Size(946, 100);
            this.tbKey.TabIndex = 14;
            this.tbKey.TextChanged += new System.EventHandler(this.tbKey_TextChanged);
            this.tbKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbKey_KeyDown);
            this.tbKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKey_KeyPress);
            this.tbKey.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbKey_KeyUp);
            // 
            // btnClearKey
            // 
            this.btnClearKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearKey.BackColor = System.Drawing.Color.Moccasin;
            this.btnClearKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearKey.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnClearKey.Location = new System.Drawing.Point(968, 85);
            this.btnClearKey.Name = "btnClearKey";
            this.btnClearKey.Size = new System.Drawing.Size(165, 47);
            this.btnClearKey.TabIndex = 19;
            this.btnClearKey.Text = "Очистить";
            this.btnClearKey.UseVisualStyleBackColor = false;
            this.btnClearKey.Click += new System.EventHandler(this.btnClearKey_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1158, 638);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnEncryption);
            this.Controls.Add(this.btnClearKey);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.lKey);
            this.Controls.Add(this.tbResultData);
            this.Controls.Add(this.lResultData);
            this.Controls.Add(this.tbSourceData);
            this.Controls.Add(this.lSourceData);
            this.Controls.Add(this.tbResultKey);
            this.Controls.Add(this.lResultKey);
            this.HelpButton = true;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная работа №2, 351004, Шкредова К. М., вариант 5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnEncryption;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label lResultKey;
        private System.Windows.Forms.TextBox tbResultKey;
        private System.Windows.Forms.TextBox tbSourceData;
        private System.Windows.Forms.Label lSourceData;
        private System.Windows.Forms.TextBox tbResultData;
        private System.Windows.Forms.Label lResultData;
        private System.Windows.Forms.Label lKey;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.Button btnClearKey;
    }
}

