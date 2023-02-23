namespace Elektronski
{
    partial class Form3
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonPoslednji = new System.Windows.Forms.Button();
            this.buttonSledeci = new System.Windows.Forms.Button();
            this.buttonBrisi = new System.Windows.Forms.Button();
            this.buttonIzmeni = new System.Windows.Forms.Button();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonPrethodni = new System.Windows.Forms.Button();
            this.buttonPrvi = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(351, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(351, 167);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(117, 20);
            this.textBox3.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(351, 132);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(117, 20);
            this.textBox2.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Indeks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Razred";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(280, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Godina";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(280, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Razredni";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Smer";
            // 
            // buttonPoslednji
            // 
            this.buttonPoslednji.Location = new System.Drawing.Point(674, 331);
            this.buttonPoslednji.Name = "buttonPoslednji";
            this.buttonPoslednji.Size = new System.Drawing.Size(75, 23);
            this.buttonPoslednji.TabIndex = 29;
            this.buttonPoslednji.Text = ">>";
            this.buttonPoslednji.UseVisualStyleBackColor = true;
            this.buttonPoslednji.Click += new System.EventHandler(this.buttonPoslednji_Click);
            // 
            // buttonSledeci
            // 
            this.buttonSledeci.Location = new System.Drawing.Point(566, 331);
            this.buttonSledeci.Name = "buttonSledeci";
            this.buttonSledeci.Size = new System.Drawing.Size(75, 23);
            this.buttonSledeci.TabIndex = 28;
            this.buttonSledeci.Text = ">";
            this.buttonSledeci.UseVisualStyleBackColor = true;
            this.buttonSledeci.Click += new System.EventHandler(this.buttonSledeci_Click);
            // 
            // buttonBrisi
            // 
            this.buttonBrisi.Location = new System.Drawing.Point(456, 331);
            this.buttonBrisi.Name = "buttonBrisi";
            this.buttonBrisi.Size = new System.Drawing.Size(75, 23);
            this.buttonBrisi.TabIndex = 27;
            this.buttonBrisi.Text = "Briši";
            this.buttonBrisi.UseVisualStyleBackColor = true;
            this.buttonBrisi.Click += new System.EventHandler(this.buttonBrisi_Click);
            // 
            // buttonIzmeni
            // 
            this.buttonIzmeni.Location = new System.Drawing.Point(351, 331);
            this.buttonIzmeni.Name = "buttonIzmeni";
            this.buttonIzmeni.Size = new System.Drawing.Size(75, 23);
            this.buttonIzmeni.TabIndex = 26;
            this.buttonIzmeni.Text = "Izmeni";
            this.buttonIzmeni.UseVisualStyleBackColor = true;
            this.buttonIzmeni.Click += new System.EventHandler(this.buttonIzmeni_Click);
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(250, 331);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(75, 23);
            this.buttonDodaj.TabIndex = 25;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonPrethodni
            // 
            this.buttonPrethodni.Location = new System.Drawing.Point(143, 331);
            this.buttonPrethodni.Name = "buttonPrethodni";
            this.buttonPrethodni.Size = new System.Drawing.Size(75, 23);
            this.buttonPrethodni.TabIndex = 24;
            this.buttonPrethodni.Text = "<";
            this.buttonPrethodni.UseVisualStyleBackColor = true;
            this.buttonPrethodni.Click += new System.EventHandler(this.buttonPrethodni_Click);
            // 
            // buttonPrvi
            // 
            this.buttonPrvi.Location = new System.Drawing.Point(44, 331);
            this.buttonPrvi.Name = "buttonPrvi";
            this.buttonPrvi.Size = new System.Drawing.Size(75, 23);
            this.buttonPrvi.TabIndex = 23;
            this.buttonPrvi.Text = "<<";
            this.buttonPrvi.UseVisualStyleBackColor = true;
            this.buttonPrvi.Click += new System.EventHandler(this.buttonPrvi_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(350, 203);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 30;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(350, 236);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 31;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(351, 270);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(81, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(645, 24);
            this.label9.TabIndex = 33;
            this.label9.Text = "Nakon dodavanja, izmene ili brisanja, treba zatvoriti prozor pa ga opet otvoriti";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 420);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonPoslednji);
            this.Controls.Add(this.buttonSledeci);
            this.Controls.Add(this.buttonBrisi);
            this.Controls.Add(this.buttonIzmeni);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.buttonPrethodni);
            this.Controls.Add(this.buttonPrvi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Odeljenje";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonPoslednji;
        private System.Windows.Forms.Button buttonSledeci;
        private System.Windows.Forms.Button buttonBrisi;
        private System.Windows.Forms.Button buttonIzmeni;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonPrethodni;
        private System.Windows.Forms.Button buttonPrvi;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label9;
    }
}