namespace alapmuveletek
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
            this.txtValasz = new System.Windows.Forms.TextBox();
            this.lbFeladat = new System.Windows.Forms.Label();
            this.btnUjraprobal = new System.Windows.Forms.Button();
            this.btnMegoldas = new System.Windows.Forms.Button();
            this.lbMegoldas = new System.Windows.Forms.Label();
            this.lbHelyesHelytelen = new System.Windows.Forms.Label();
            this.lbProbalkozas = new System.Windows.Forms.Label();
            this.lbHanyKerdes = new System.Windows.Forms.Label();
            this.lbEredmenySz = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbEredmenyelMuv = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.műveletekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSzorzas = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsOsztas = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsOsszeadas = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsKivonas = new System.Windows.Forms.ToolStripMenuItem();
            this.pnStatisztika = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtValasz
            // 
            this.txtValasz.Location = new System.Drawing.Point(338, 41);
            this.txtValasz.Name = "txtValasz";
            this.txtValasz.Size = new System.Drawing.Size(100, 20);
            this.txtValasz.TabIndex = 1;
            this.txtValasz.TextChanged += new System.EventHandler(this.TxtValasz_TextChanged);
            // 
            // lbFeladat
            // 
            this.lbFeladat.AutoSize = true;
            this.lbFeladat.Location = new System.Drawing.Point(164, 28);
            this.lbFeladat.Name = "lbFeladat";
            this.lbFeladat.Size = new System.Drawing.Size(42, 13);
            this.lbFeladat.TabIndex = 3;
            this.lbFeladat.Text = "Feladat";
            // 
            // btnUjraprobal
            // 
            this.btnUjraprobal.Location = new System.Drawing.Point(338, 85);
            this.btnUjraprobal.Name = "btnUjraprobal";
            this.btnUjraprobal.Size = new System.Drawing.Size(75, 23);
            this.btnUjraprobal.TabIndex = 4;
            this.btnUjraprobal.Text = "Újra";
            this.btnUjraprobal.UseVisualStyleBackColor = true;
            // 
            // btnMegoldas
            // 
            this.btnMegoldas.Location = new System.Drawing.Point(12, 114);
            this.btnMegoldas.Name = "btnMegoldas";
            this.btnMegoldas.Size = new System.Drawing.Size(160, 23);
            this.btnMegoldas.TabIndex = 5;
            this.btnMegoldas.Text = "Megoldást mutat";
            this.btnMegoldas.UseVisualStyleBackColor = true;
            this.btnMegoldas.Click += new System.EventHandler(this.BtnMegoldas_Click);
            // 
            // lbMegoldas
            // 
            this.lbMegoldas.AutoSize = true;
            this.lbMegoldas.Location = new System.Drawing.Point(12, 140);
            this.lbMegoldas.Name = "lbMegoldas";
            this.lbMegoldas.Size = new System.Drawing.Size(59, 13);
            this.lbMegoldas.TabIndex = 6;
            this.lbMegoldas.Text = "Megoldás: ";
            // 
            // lbHelyesHelytelen
            // 
            this.lbHelyesHelytelen.AutoSize = true;
            this.lbHelyesHelytelen.Location = new System.Drawing.Point(461, 47);
            this.lbHelyesHelytelen.Name = "lbHelyesHelytelen";
            this.lbHelyesHelytelen.Size = new System.Drawing.Size(74, 13);
            this.lbHelyesHelytelen.TabIndex = 7;
            this.lbHelyesHelytelen.Text = "Az eredmény: ";
            // 
            // lbProbalkozas
            // 
            this.lbProbalkozas.AutoSize = true;
            this.lbProbalkozas.Location = new System.Drawing.Point(12, 185);
            this.lbProbalkozas.Name = "lbProbalkozas";
            this.lbProbalkozas.Size = new System.Drawing.Size(113, 13);
            this.lbProbalkozas.TabIndex = 8;
            this.lbProbalkozas.Text = "Próbálkozások száma:";
            // 
            // lbHanyKerdes
            // 
            this.lbHanyKerdes.AutoSize = true;
            this.lbHanyKerdes.Location = new System.Drawing.Point(12, 172);
            this.lbHanyKerdes.Name = "lbHanyKerdes";
            this.lbHanyKerdes.Size = new System.Drawing.Size(91, 13);
            this.lbHanyKerdes.TabIndex = 9;
            this.lbHanyKerdes.Text = "Kérdések száma: ";
            // 
            // lbEredmenySz
            // 
            this.lbEredmenySz.AutoSize = true;
            this.lbEredmenySz.Location = new System.Drawing.Point(9, 221);
            this.lbEredmenySz.Name = "lbEredmenySz";
            this.lbEredmenySz.Size = new System.Drawing.Size(124, 13);
            this.lbEredmenySz.TabIndex = 10;
            this.lbEredmenySz.Text = "Eredmény százalékosan:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 272);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // lbEredmenyelMuv
            // 
            this.lbEredmenyelMuv.AutoSize = true;
            this.lbEredmenyelMuv.Location = new System.Drawing.Point(12, 256);
            this.lbEredmenyelMuv.Name = "lbEredmenyelMuv";
            this.lbEredmenyelMuv.Size = new System.Drawing.Size(171, 13);
            this.lbEredmenyelMuv.TabIndex = 12;
            this.lbEredmenyelMuv.Text = "Eredmények műveletekre lebontva";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.műveletekToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(585, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // műveletekToolStripMenuItem
            // 
            this.műveletekToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsSzorzas,
            this.cmsOsztas,
            this.cmsOsszeadas,
            this.cmsKivonas});
            this.műveletekToolStripMenuItem.Name = "műveletekToolStripMenuItem";
            this.műveletekToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.műveletekToolStripMenuItem.Text = "Műveletek";
            // 
            // cmsSzorzas
            // 
            this.cmsSzorzas.Name = "cmsSzorzas";
            this.cmsSzorzas.Size = new System.Drawing.Size(180, 22);
            this.cmsSzorzas.Text = "szorzás";
            this.cmsSzorzas.Click += new System.EventHandler(this.CmsSzorzas_Click);
            // 
            // cmsOsztas
            // 
            this.cmsOsztas.Name = "cmsOsztas";
            this.cmsOsztas.Size = new System.Drawing.Size(180, 22);
            this.cmsOsztas.Text = "osztás";
            this.cmsOsztas.Click += new System.EventHandler(this.CmsOsztas_Click);
            // 
            // cmsOsszeadas
            // 
            this.cmsOsszeadas.Name = "cmsOsszeadas";
            this.cmsOsszeadas.Size = new System.Drawing.Size(180, 22);
            this.cmsOsszeadas.Text = "összeadás";
            // 
            // cmsKivonas
            // 
            this.cmsKivonas.Name = "cmsKivonas";
            this.cmsKivonas.Size = new System.Drawing.Size(180, 22);
            this.cmsKivonas.Text = "kivonás";
            // 
            // pnStatisztika
            // 
            this.pnStatisztika.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnStatisztika.Location = new System.Drawing.Point(12, 256);
            this.pnStatisztika.Name = "pnStatisztika";
            this.pnStatisztika.Size = new System.Drawing.Size(278, 182);
            this.pnStatisztika.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 450);
            this.Controls.Add(this.lbEredmenyelMuv);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbEredmenySz);
            this.Controls.Add(this.lbHanyKerdes);
            this.Controls.Add(this.lbProbalkozas);
            this.Controls.Add(this.lbHelyesHelytelen);
            this.Controls.Add(this.lbMegoldas);
            this.Controls.Add(this.btnMegoldas);
            this.Controls.Add(this.btnUjraprobal);
            this.Controls.Add(this.lbFeladat);
            this.Controls.Add(this.txtValasz);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnStatisztika);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Alapműveletek";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtValasz;
        private System.Windows.Forms.Label lbFeladat;
        private System.Windows.Forms.Button btnUjraprobal;
        private System.Windows.Forms.Button btnMegoldas;
        private System.Windows.Forms.Label lbMegoldas;
        private System.Windows.Forms.Label lbHelyesHelytelen;
        private System.Windows.Forms.Label lbProbalkozas;
        private System.Windows.Forms.Label lbHanyKerdes;
        private System.Windows.Forms.Label lbEredmenySz;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbEredmenyelMuv;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem műveletekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmsSzorzas;
        private System.Windows.Forms.ToolStripMenuItem cmsOsztas;
        private System.Windows.Forms.ToolStripMenuItem cmsOsszeadas;
        private System.Windows.Forms.ToolStripMenuItem cmsKivonas;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel pnStatisztika;
    }
}

