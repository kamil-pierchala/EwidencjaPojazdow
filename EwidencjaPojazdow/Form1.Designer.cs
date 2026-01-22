namespace EwidencjaPojazdow
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtNr = new System.Windows.Forms.TextBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.numRok = new System.Windows.Forms.NumericUpDown();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.txtWlasciciel = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dgvPojazdy = new System.Windows.Forms.DataGridView();
            this.lblNr = new System.Windows.Forms.Label();
            this.lblMarka = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblRok = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblWlasciciel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numRok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPojazdy)).BeginInit();
            this.SuspendLayout();

            this.txtNr.Location = new System.Drawing.Point(120, 20);
            this.txtNr.Name = "txtNr";
            this.txtNr.Size = new System.Drawing.Size(150, 20);

            this.txtMarka.Location = new System.Drawing.Point(120, 50);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(150, 20);

            this.txtModel.Location = new System.Drawing.Point(120, 80);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(150, 20);

            this.numRok.Location = new System.Drawing.Point(120, 110);
            this.numRok.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            this.numRok.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            this.numRok.Name = "numRok";
            this.numRok.Size = new System.Drawing.Size(150, 20);
            this.numRok.Value = new decimal(new int[] { 2024, 0, 0, 0 });

            this.dtpData.Location = new System.Drawing.Point(120, 140);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(150, 20);

            this.txtWlasciciel.Location = new System.Drawing.Point(120, 170);
            this.txtWlasciciel.Name = "txtWlasciciel";
            this.txtWlasciciel.Size = new System.Drawing.Size(150, 20);

            this.btnDodaj.Location = new System.Drawing.Point(120, 210);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(150, 30);
            this.btnDodaj.TabIndex = 6;
            this.btnDodaj.Text = "Dodaj pojazd";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);

            this.btnGenerujRaport = new System.Windows.Forms.Button();
            this.btnGenerujRaport.Location = new System.Drawing.Point(120, 245);
            this.btnGenerujRaport.Name = "btnGenerujRaport";
            this.btnGenerujRaport.Size = new System.Drawing.Size(150, 30);
            this.btnGenerujRaport.Text = "Generuj Raport";
            this.btnGenerujRaport.Click += new System.EventHandler(this.btnGenerujRaport_Click);
            this.Controls.Add(this.btnGenerujRaport);

            this.dgvPojazdy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPojazdy.Location = new System.Drawing.Point(300, 20);
            this.dgvPojazdy.Name = "dgvPojazdy";
            this.dgvPojazdy.Size = new System.Drawing.Size(450, 220);

            this.lblNr.Location = new System.Drawing.Point(20, 23);
            this.lblNr.Name = "lblNr";
            this.lblNr.Size = new System.Drawing.Size(100, 20);
            this.lblNr.Text = "Nr rej.:";

            this.lblMarka.Location = new System.Drawing.Point(20, 53);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(100, 20);
            this.lblMarka.Text = "Marka:";

            this.lblModel.Location = new System.Drawing.Point(20, 83);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(100, 20);
            this.lblModel.Text = "Model:";

            this.lblRok.Location = new System.Drawing.Point(20, 113);
            this.lblRok.Name = "lblRok";
            this.lblRok.Size = new System.Drawing.Size(100, 20);
            this.lblRok.Text = "Rok:";

            this.lblData.Location = new System.Drawing.Point(20, 143);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(100, 20);
            this.lblData.Text = "Przegląd:";

            this.lblWlasciciel.Location = new System.Drawing.Point(20, 173);
            this.lblWlasciciel.Name = "lblWlasciciel";
            this.lblWlasciciel.Size = new System.Drawing.Size(100, 20);
            this.lblWlasciciel.Text = "Właściciel:";

            this.ClientSize = new System.Drawing.Size(780, 280);
            this.Controls.Add(this.txtNr);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.numRok);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.txtWlasciciel);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvPojazdy);
            this.Controls.Add(this.lblNr);
            this.Controls.Add(this.lblMarka);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblRok);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblWlasciciel);
            this.Name = "Form1";
            this.Text = "Ewidencja Pojazdów";
            ((System.ComponentModel.ISupportInitialize)(this.numRok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPojazdy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtNr;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.NumericUpDown numRok;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.TextBox txtWlasciciel;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DataGridView dgvPojazdy;
        private System.Windows.Forms.Label lblNr;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblRok;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblWlasciciel;
        private System.Windows.Forms.Button btnGenerujRaport;
    }
}