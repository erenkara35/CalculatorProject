namespace CalculatorProjecttt
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
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnDod = new Button();
            btn0 = new Button();
            btnClear = new Button();
            btnBolu = new Button();
            btnCarpi = new Button();
            btnEksi = new Button();
            btnArti = new Button();
            txtEkran = new TextBox();
            lstSonuc = new ListBox();
            btnBackSpace = new Button();
            btnArtiEksi = new Button();
            btnEsittir = new Button();
            SuspendLayout();
            // 
            // btn7
            // 
            btn7.Location = new Point(23, 80);
            btn7.Name = "btn7";
            btn7.Size = new Size(61, 60);
            btn7.TabIndex = 0;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += NumberButtons;
            // 
            // btn8
            // 
            btn8.Location = new Point(91, 80);
            btn8.Name = "btn8";
            btn8.Size = new Size(61, 60);
            btn8.TabIndex = 1;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += NumberButtons;
            // 
            // btn9
            // 
            btn9.Location = new Point(158, 80);
            btn9.Name = "btn9";
            btn9.Size = new Size(61, 60);
            btn9.TabIndex = 2;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += NumberButtons;
            // 
            // btn6
            // 
            btn6.Location = new Point(158, 146);
            btn6.Name = "btn6";
            btn6.Size = new Size(61, 60);
            btn6.TabIndex = 5;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += NumberButtons;
            // 
            // btn5
            // 
            btn5.Location = new Point(91, 146);
            btn5.Name = "btn5";
            btn5.Size = new Size(61, 60);
            btn5.TabIndex = 4;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += NumberButtons;
            // 
            // btn4
            // 
            btn4.Location = new Point(23, 146);
            btn4.Name = "btn4";
            btn4.Size = new Size(61, 60);
            btn4.TabIndex = 3;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += NumberButtons;
            // 
            // btn3
            // 
            btn3.Location = new Point(158, 212);
            btn3.Name = "btn3";
            btn3.Size = new Size(61, 60);
            btn3.TabIndex = 8;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += NumberButtons;
            // 
            // btn2
            // 
            btn2.Location = new Point(91, 212);
            btn2.Name = "btn2";
            btn2.Size = new Size(61, 60);
            btn2.TabIndex = 7;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += NumberButtons;
            // 
            // btn1
            // 
            btn1.Location = new Point(23, 212);
            btn1.Name = "btn1";
            btn1.Size = new Size(61, 60);
            btn1.TabIndex = 6;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += NumberButtons;
            // 
            // btnDod
            // 
            btnDod.Location = new Point(158, 278);
            btnDod.Name = "btnDod";
            btnDod.Size = new Size(61, 60);
            btnDod.TabIndex = 11;
            btnDod.Text = ".";
            btnDod.UseVisualStyleBackColor = true;
            btnDod.Click += NumberButtons;
            // 
            // btn0
            // 
            btn0.Location = new Point(91, 278);
            btn0.Name = "btn0";
            btn0.Size = new Size(61, 60);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += NumberButtons;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(23, 278);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(61, 60);
            btnClear.TabIndex = 9;
            btnClear.Text = "CE";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnBolu
            // 
            btnBolu.Location = new Point(225, 278);
            btnBolu.Name = "btnBolu";
            btnBolu.Size = new Size(61, 60);
            btnBolu.TabIndex = 15;
            btnBolu.Text = "/";
            btnBolu.UseVisualStyleBackColor = true;
            btnBolu.Click += OperatorButtons;
            // 
            // btnCarpi
            // 
            btnCarpi.Location = new Point(225, 212);
            btnCarpi.Name = "btnCarpi";
            btnCarpi.Size = new Size(61, 60);
            btnCarpi.TabIndex = 14;
            btnCarpi.Text = "*";
            btnCarpi.UseVisualStyleBackColor = true;
            btnCarpi.Click += OperatorButtons;
            // 
            // btnEksi
            // 
            btnEksi.Location = new Point(225, 146);
            btnEksi.Name = "btnEksi";
            btnEksi.Size = new Size(61, 60);
            btnEksi.TabIndex = 13;
            btnEksi.Text = "-";
            btnEksi.UseVisualStyleBackColor = true;
            btnEksi.Click += OperatorButtons;
            // 
            // btnArti
            // 
            btnArti.Location = new Point(225, 80);
            btnArti.Name = "btnArti";
            btnArti.Size = new Size(61, 60);
            btnArti.TabIndex = 12;
            btnArti.Text = "+";
            btnArti.UseVisualStyleBackColor = true;
            btnArti.Click += OperatorButtons;
            // 
            // txtEkran
            // 
            txtEkran.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            txtEkran.Location = new Point(23, 27);
            txtEkran.Name = "txtEkran";
            txtEkran.Size = new Size(328, 39);
            txtEkran.TabIndex = 16;
            // 
            // lstSonuc
            // 
            lstSonuc.FormattingEnabled = true;
            lstSonuc.ItemHeight = 21;
            lstSonuc.Location = new Point(373, 33);
            lstSonuc.Name = "lstSonuc";
            lstSonuc.Size = new Size(144, 298);
            lstSonuc.TabIndex = 17;
            // 
            // btnBackSpace
            // 
            btnBackSpace.Location = new Point(292, 80);
            btnBackSpace.Name = "btnBackSpace";
            btnBackSpace.Size = new Size(59, 126);
            btnBackSpace.TabIndex = 18;
            btnBackSpace.Text = "<=";
            btnBackSpace.UseVisualStyleBackColor = true;
            btnBackSpace.Click += btnBackSpace_Click;
            // 
            // btnArtiEksi
            // 
            btnArtiEksi.Location = new Point(292, 212);
            btnArtiEksi.Name = "btnArtiEksi";
            btnArtiEksi.Size = new Size(59, 60);
            btnArtiEksi.TabIndex = 19;
            btnArtiEksi.Text = "+/-";
            btnArtiEksi.UseVisualStyleBackColor = true;
            btnArtiEksi.Click += btnArtiEksi_Click;
            // 
            // btnEsittir
            // 
            btnEsittir.Location = new Point(292, 278);
            btnEsittir.Name = "btnEsittir";
            btnEsittir.Size = new Size(59, 60);
            btnEsittir.TabIndex = 19;
            btnEsittir.Text = "=";
            btnEsittir.UseVisualStyleBackColor = true;
            btnEsittir.Click += btnEsittir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(543, 362);
            Controls.Add(btnEsittir);
            Controls.Add(btnArtiEksi);
            Controls.Add(btnBackSpace);
            Controls.Add(lstSonuc);
            Controls.Add(txtEkran);
            Controls.Add(btnBolu);
            Controls.Add(btnCarpi);
            Controls.Add(btnEksi);
            Controls.Add(btnArti);
            Controls.Add(btnDod);
            Controls.Add(btn0);
            Controls.Add(btnClear);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnDod;
        private Button btn0;
        private Button btnClear;
        private Button btnBolu;
        private Button btnCarpi;
        private Button btnEksi;
        private Button btnArti;
        private TextBox txtEkran;
        private ListBox lstSonuc;
        private Button btnBackSpace;
        private Button btnArtiEksi;
        private Button btnEsittir;
    }
}
