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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(795, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // LabelP
            // 
            this.LabelP.Location = new System.Drawing.Point(27, 26);
            this.LabelP.Name = "LabelP";
            this.LabelP.Size = new System.Drawing.Size(100, 23);
            this.LabelP.TabIndex = 1;
            this.LabelP.Text = "P:";
            // 
            // TextBoxP
            // 
            this.TextBoxP.Location = new System.Drawing.Point(54, 23);
            this.TextBoxP.Name = "TextBoxP";
            this.TextBoxP.Size = new System.Drawing.Size(222, 23);
            this.TextBoxP.TabIndex = 2;
            this.TextBoxP.TextChanged += new System.EventHandler(this.ClearStrip_Click);
            // 
            // TextBoxQ
            // 
            this.TextBoxQ.Location = new System.Drawing.Point(54, 56);
            this.TextBoxQ.Name = "TextBoxQ";
            this.TextBoxQ.Size = new System.Drawing.Size(222, 23);
            this.TextBoxQ.TabIndex = 4;
            this.TextBoxQ.TextChanged += new System.EventHandler(this.ClearStrip_Click);
            // 
            // LabelQ
            // 
            this.LabelQ.Location = new System.Drawing.Point(27, 59);
            this.LabelQ.Name = "LabelQ";
            this.LabelQ.Size = new System.Drawing.Size(100, 23);
            this.LabelQ.TabIndex = 3;
            this.LabelQ.Text = "Q:";
            // 
            // TextBoxR
            // 
            this.TextBoxR.Location = new System.Drawing.Point(507, 4);
            this.TextBoxR.Multiline = true;
            this.TextBoxR.Name = "TextBoxR";
            this.TextBoxR.ReadOnly = true;
            this.TextBoxR.Size = new System.Drawing.Size(275, 61);
            this.TextBoxR.TabIndex = 5;
            // 
            // LabelR
            // 
            this.LabelR.Location = new System.Drawing.Point(464, 23);
            this.LabelR.Name = "LabelR";
            this.LabelR.Size = new System.Drawing.Size(37, 23);
            this.LabelR.TabIndex = 6;
            this.LabelR.Text = "R:";
            // 
            // ButtonR
            // 
            this.ButtonR.Location = new System.Drawing.Point(54, 99);
            this.ButtonR.Name = "ButtonR";
            this.ButtonR.Size = new System.Drawing.Size(222, 30);
            this.ButtonR.TabIndex = 7;
            this.ButtonR.Text = "Рассчитать параметры";
            this.ButtonR.UseVisualStyleBackColor = true;
            this.ButtonR.Click += new System.EventHandler(this.ButtonR_Click);
            // 
            // LabelD
            // 
            this.LabelD.Location = new System.Drawing.Point(27, 160);
            this.LabelD.Name = "LabelD";
            this.LabelD.Size = new System.Drawing.Size(173, 23);
            this.LabelD.TabIndex = 8;
            this.LabelD.Text = "Закрытая константа D:";
            // 
            // TextBoxD
            // 
            this.TextBoxD.Location = new System.Drawing.Point(27, 186);
            this.TextBoxD.Name = "TextBoxD";
            this.TextBoxD.Size = new System.Drawing.Size(249, 23);
            this.TextBoxD.TabIndex = 9;
            this.TextBoxD.TextChanged += new System.EventHandler(this.ClearStrip_Click);
            // 
            // EulerLabel
            // 
            this.EulerLabel.Location = new System.Drawing.Point(454, 99);
            this.EulerLabel.Name = "EulerLabel";
            this.EulerLabel.Size = new System.Drawing.Size(56, 23);
            this.EulerLabel.TabIndex = 10;
            this.EulerLabel.Text = "φ(R):";
            // 
            // TextBoxEuler
            // 
            this.TextBoxEuler.Location = new System.Drawing.Point(507, 81);
            this.TextBoxEuler.Multiline = true;
            this.TextBoxEuler.Name = "TextBoxEuler";
            this.TextBoxEuler.ReadOnly = true;
            this.TextBoxEuler.Size = new System.Drawing.Size(275, 61);
            this.TextBoxEuler.TabIndex = 11;
            // 
            // RadioButtonCipher
            // 
            this.RadioButtonCipher.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RadioButtonCipher.Checked = true;
            this.RadioButtonCipher.Location = new System.Drawing.Point(30, 222);
            this.RadioButtonCipher.Name = "RadioButtonCipher";
            this.RadioButtonCipher.Size = new System.Drawing.Size(129, 24);
            this.RadioButtonCipher.TabIndex = 12;
            this.RadioButtonCipher.TabStop = true;
            this.RadioButtonCipher.Text = "Шифрация";
            this.RadioButtonCipher.UseVisualStyleBackColor = true;
            this.RadioButtonCipher.CheckedChanged += new System.EventHandler(this.RadioButtonCipher_CheckedChanged);
            // 
            // RadioButtonDecipher
            // 
            this.RadioButtonDecipher.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RadioButtonDecipher.Location = new System.Drawing.Point(165, 222);
            this.RadioButtonDecipher.Name = "RadioButtonDecipher";
            this.RadioButtonDecipher.Size = new System.Drawing.Size(129, 24);
            this.RadioButtonDecipher.TabIndex = 13;
            this.RadioButtonDecipher.Text = "Дешифрация";
            this.RadioButtonDecipher.UseVisualStyleBackColor = true;
            this.RadioButtonDecipher.CheckedChanged += new System.EventHandler(this.RadioButtonDecipher_CheckedChanged);
            // 
            // TextBoxE
            // 
            this.TextBoxE.Location = new System.Drawing.Point(507, 185);
            this.TextBoxE.Multiline = true;
            this.TextBoxE.Name = "TextBoxE";
            this.TextBoxE.ReadOnly = true;
            this.TextBoxE.Size = new System.Drawing.Size(275, 46);
            this.TextBoxE.TabIndex = 14;
            // 
            // LabelE
            // 
            this.LabelE.Location = new System.Drawing.Point(559, 151);
            this.LabelE.Name = "LabelE";
            this.LabelE.Size = new System.Drawing.Size(174, 25);
            this.LabelE.TabIndex = 15;
            this.LabelE.Text = "Открытая константа E:";
            // 
            // PlainText
            // 
            this.PlainText.Location = new System.Drawing.Point(27, 308);
            this.PlainText.Multiline = true;
            this.PlainText.Name = "PlainText";
            this.PlainText.ReadOnly = true;
            this.PlainText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PlainText.Size = new System.Drawing.Size(755, 105);
            this.PlainText.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(28, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(592, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Исходный текст:";
            // 
            // LabelCipher
            // 
            this.LabelCipher.Location = new System.Drawing.Point(27, 430);
            this.LabelCipher.Name = "LabelCipher";
            this.LabelCipher.Size = new System.Drawing.Size(448, 23);
            this.LabelCipher.TabIndex = 18;
            this.LabelCipher.Text = "Зашифрованный текст:";
            // 
            // CipherText
            // 
            this.CipherText.Location = new System.Drawing.Point(27, 456);
            this.CipherText.Multiline = true;
            this.CipherText.Name = "CipherText";
            this.CipherText.ReadOnly = true;
            this.CipherText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CipherText.Size = new System.Drawing.Size(755, 113);
            this.CipherText.TabIndex = 19;
            // 
            // ResultButton
            // 
            this.ResultButton.Enabled = false;
            this.ResultButton.Location = new System.Drawing.Point(304, 586);
            this.ResultButton.Name = "ResultButton";
            this.ResultButton.Size = new System.Drawing.Size(171, 57);
            this.ResultButton.TabIndex = 20;
            this.ResultButton.Text = "Зашифровать";
            this.ResultButton.UseVisualStyleBackColor = true;
            this.ResultButton.Click += new System.EventHandler(this.ResultButton_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 70);
            this.button1.TabIndex = 21;
            this.button1.Text = "Открыть файл\r\nс исходным текстом";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(323, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 61);
            this.button2.TabIndex = 22;
            this.button2.Text = "Сохранить заши-\r\nфрованный \r\nтекст\r\n\r\n";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(323, 23);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 70);
            this.button3.TabIndex = 23;
            this.button3.Text = "Открыть файл с \r\nзашифрованным текстом";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(323, 106);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 61);
            this.button4.TabIndex = 24;
            this.button4.Text = "Сохранить\r\nисходный текст";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(323, 185);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(121, 35);
            this.button5.TabIndex = 25;
            this.button5.Text = "Очистить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(795, 665);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ResultButton);
            this.Controls.Add(this.CipherText);
            this.Controls.Add(this.LabelCipher);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlainText);
            this.Controls.Add(this.LabelE);
            this.Controls.Add(this.TextBoxE);
            this.Controls.Add(this.RadioButtonDecipher);
            this.Controls.Add(this.RadioButtonCipher);
            this.Controls.Add(this.TextBoxEuler);
            this.Controls.Add(this.EulerLabel);
            this.Controls.Add(this.TextBoxD);
            this.Controls.Add(this.LabelD);
            this.Controls.Add(this.ButtonR);
            this.Controls.Add(this.LabelR);
            this.Controls.Add(this.TextBoxR);
            this.Controls.Add(this.TextBoxQ);
            this.Controls.Add(this.LabelQ);
            this.Controls.Add(this.TextBoxP);
            this.Controls.Add(this.LabelP);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ТИ ЛР3 Пуренок 351004";
            this.Load += new System.EventHandler(this.MainForm_Load);
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
        private System.Windows.Forms.Label LabelP;
        private System.Windows.Forms.TextBox TextBoxP;
        private System.Windows.Forms.TextBox TextBoxQ;
        private System.Windows.Forms.Label LabelQ;
        private System.Windows.Forms.TextBox TextBoxR;
        private System.Windows.Forms.Label LabelR;

        private System.Windows.Forms.MenuStrip menuStrip1;

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}