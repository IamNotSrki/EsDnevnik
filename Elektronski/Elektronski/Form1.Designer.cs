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
            this.školskaGodinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.predmetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odeljenjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izveštajiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.školskaGodinaToolStripMenuItem,
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
            // školskaGodinaToolStripMenuItem
            // 
            this.školskaGodinaToolStripMenuItem.Name = "školskaGodinaToolStripMenuItem";
            this.školskaGodinaToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.školskaGodinaToolStripMenuItem.Text = "Školska godina";
            // 
            // smerToolStripMenuItem
            // 
            this.smerToolStripMenuItem.Name = "smerToolStripMenuItem";
            this.smerToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.smerToolStripMenuItem.Text = "Smer";
            // 
            // predmetToolStripMenuItem
            // 
            this.predmetToolStripMenuItem.Name = "predmetToolStripMenuItem";
            this.predmetToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.predmetToolStripMenuItem.Text = "Predmet";
            // 
            // odeljenjaToolStripMenuItem
            // 
            this.odeljenjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledToolStripMenuItem});
            this.odeljenjaToolStripMenuItem.Name = "odeljenjaToolStripMenuItem";
            this.odeljenjaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.odeljenjaToolStripMenuItem.Text = "Odeljenja";
            // 
            // izveštajiToolStripMenuItem
            // 
            this.izveštajiToolStripMenuItem.Name = "izveštajiToolStripMenuItem";
            this.izveštajiToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.izveštajiToolStripMenuItem.Text = "Izveštaji";
            // 
            // pregledToolStripMenuItem
            // 
            this.pregledToolStripMenuItem.Name = "pregledToolStripMenuItem";
            this.pregledToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pregledToolStripMenuItem.Text = "Pregled";
            this.pregledToolStripMenuItem.Click += new System.EventHandler(this.pregledToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 596);
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
        private System.Windows.Forms.ToolStripMenuItem školskaGodinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem predmetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odeljenjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izveštajiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledToolStripMenuItem;
    }
}

