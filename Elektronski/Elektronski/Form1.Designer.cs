namespace Elektronski
{
    partial class Form1
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.šifarniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.osobaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skolskaGodinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.predmetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odeljenjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izveštajiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odeljenjaBtn = new System.Windows.Forms.Button();
            this.oceneBtn = new System.Windows.Forms.Button();
            this.upisniceBtn = new System.Windows.Forms.Button();
            this.raspodeleBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.šifarniciToolStripMenuItem,
            this.odeljenjaToolStripMenuItem,
            this.izveštajiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1015, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "Šifarnici";
            // 
            // šifarniciToolStripMenuItem
            // 
            this.šifarniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.osobaToolStripMenuItem,
            this.skolskaGodinaToolStripMenuItem,
            this.smerToolStripMenuItem,
            this.predmetToolStripMenuItem});
            this.šifarniciToolStripMenuItem.Name = "šifarniciToolStripMenuItem";
            this.šifarniciToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.šifarniciToolStripMenuItem.Text = "Šifarnici";
            // 
            // osobaToolStripMenuItem
            // 
            this.osobaToolStripMenuItem.Name = "osobaToolStripMenuItem";
            this.osobaToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.osobaToolStripMenuItem.Text = "Osoba";
            this.osobaToolStripMenuItem.Click += new System.EventHandler(this.osobaToolStripMenuItem_Click);
            // 
            // skolskaGodinaToolStripMenuItem
            // 
            this.skolskaGodinaToolStripMenuItem.Name = "skolskaGodinaToolStripMenuItem";
            this.skolskaGodinaToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.skolskaGodinaToolStripMenuItem.Text = "Školska godina";
            this.skolskaGodinaToolStripMenuItem.Click += new System.EventHandler(this.skolskaGodinaToolStripMenuItem_Click);
            // 
            // smerToolStripMenuItem
            // 
            this.smerToolStripMenuItem.Name = "smerToolStripMenuItem";
            this.smerToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.smerToolStripMenuItem.Text = "Smer";
            this.smerToolStripMenuItem.Click += new System.EventHandler(this.smerToolStripMenuItem_Click);
            // 
            // predmetToolStripMenuItem
            // 
            this.predmetToolStripMenuItem.Name = "predmetToolStripMenuItem";
            this.predmetToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.predmetToolStripMenuItem.Text = "Predmet";
            this.predmetToolStripMenuItem.Click += new System.EventHandler(this.predmetToolStripMenuItem_Click);
            // 
            // odeljenjaToolStripMenuItem
            // 
            this.odeljenjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledToolStripMenuItem});
            this.odeljenjaToolStripMenuItem.Name = "odeljenjaToolStripMenuItem";
            this.odeljenjaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.odeljenjaToolStripMenuItem.Text = "Odeljenja";
            // 
            // pregledToolStripMenuItem
            // 
            this.pregledToolStripMenuItem.Name = "pregledToolStripMenuItem";
            this.pregledToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.pregledToolStripMenuItem.Text = "Pregled";
            this.pregledToolStripMenuItem.Click += new System.EventHandler(this.pregledToolStripMenuItem_Click);
            // 
            // izveštajiToolStripMenuItem
            // 
            this.izveštajiToolStripMenuItem.Name = "izveštajiToolStripMenuItem";
            this.izveštajiToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.izveštajiToolStripMenuItem.Text = "Izveštaji";
            // 
            // odeljenjaBtn
            // 
            this.odeljenjaBtn.Location = new System.Drawing.Point(259, 144);
            this.odeljenjaBtn.Name = "odeljenjaBtn";
            this.odeljenjaBtn.Size = new System.Drawing.Size(183, 102);
            this.odeljenjaBtn.TabIndex = 2;
            this.odeljenjaBtn.Text = "Pregled odeljenja";
            this.odeljenjaBtn.UseVisualStyleBackColor = true;
            this.odeljenjaBtn.Click += new System.EventHandler(this.odeljenjaBtn_Click);
            // 
            // oceneBtn
            // 
            this.oceneBtn.Location = new System.Drawing.Point(492, 144);
            this.oceneBtn.Name = "oceneBtn";
            this.oceneBtn.Size = new System.Drawing.Size(183, 102);
            this.oceneBtn.TabIndex = 3;
            this.oceneBtn.Text = "Pregled ocena";
            this.oceneBtn.UseVisualStyleBackColor = true;
            this.oceneBtn.Click += new System.EventHandler(this.oceneBtn_Click);
            // 
            // upisniceBtn
            // 
            this.upisniceBtn.Location = new System.Drawing.Point(259, 282);
            this.upisniceBtn.Name = "upisniceBtn";
            this.upisniceBtn.Size = new System.Drawing.Size(183, 102);
            this.upisniceBtn.TabIndex = 4;
            this.upisniceBtn.Text = "Pregled upisnica";
            this.upisniceBtn.UseVisualStyleBackColor = true;
            this.upisniceBtn.Click += new System.EventHandler(this.upisniceBtn_Click);
            // 
            // raspodeleBtn
            // 
            this.raspodeleBtn.Location = new System.Drawing.Point(492, 282);
            this.raspodeleBtn.Name = "raspodeleBtn";
            this.raspodeleBtn.Size = new System.Drawing.Size(183, 102);
            this.raspodeleBtn.TabIndex = 5;
            this.raspodeleBtn.Text = "Pregled raspodela";
            this.raspodeleBtn.UseVisualStyleBackColor = true;
            this.raspodeleBtn.Click += new System.EventHandler(this.raspodeleBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 596);
            this.Controls.Add(this.raspodeleBtn);
            this.Controls.Add(this.upisniceBtn);
            this.Controls.Add(this.oceneBtn);
            this.Controls.Add(this.odeljenjaBtn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "EsDnevnik";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem šifarniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem osobaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skolskaGodinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem predmetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odeljenjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izveštajiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledToolStripMenuItem;
        private System.Windows.Forms.Button odeljenjaBtn;
        private System.Windows.Forms.Button oceneBtn;
        private System.Windows.Forms.Button upisniceBtn;
        private System.Windows.Forms.Button raspodeleBtn;
    }
}

