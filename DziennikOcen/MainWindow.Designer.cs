namespace DziennikOcen
{
    partial class MainWindow
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonStudenci = new System.Windows.Forms.Button();
            this.buttonProjekty = new System.Windows.Forms.Button();
            this.buttonOceny = new System.Windows.Forms.Button();
            this.buttonPrzedmioty = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrindexuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kierunekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocenyprojektBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxOcena = new System.Windows.Forms.TextBox();
            this.buttonZmienOcene = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocenyprojektBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 531F));
            this.tableLayoutPanel1.Controls.Add(this.buttonStudenci, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonProjekty, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonOceny, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonPrzedmioty, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.button6, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxOcena, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonZmienOcene, 2, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(806, 473);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // buttonStudenci
            // 
            this.buttonStudenci.AutoSize = true;
            this.buttonStudenci.Location = new System.Drawing.Point(3, 3);
            this.buttonStudenci.Name = "buttonStudenci";
            this.buttonStudenci.Size = new System.Drawing.Size(75, 27);
            this.buttonStudenci.TabIndex = 0;
            this.buttonStudenci.Text = "Studenci";
            this.buttonStudenci.UseVisualStyleBackColor = true;
            // 
            // buttonProjekty
            // 
            this.buttonProjekty.AutoSize = true;
            this.buttonProjekty.Location = new System.Drawing.Point(102, 3);
            this.buttonProjekty.Name = "buttonProjekty";
            this.buttonProjekty.Size = new System.Drawing.Size(75, 27);
            this.buttonProjekty.TabIndex = 1;
            this.buttonProjekty.Text = "Projekty";
            this.buttonProjekty.UseVisualStyleBackColor = true;
            // 
            // buttonOceny
            // 
            this.buttonOceny.AutoSize = true;
            this.buttonOceny.Location = new System.Drawing.Point(3, 159);
            this.buttonOceny.Name = "buttonOceny";
            this.buttonOceny.Size = new System.Drawing.Size(75, 27);
            this.buttonOceny.TabIndex = 2;
            this.buttonOceny.Text = "Oceny";
            this.buttonOceny.UseVisualStyleBackColor = true;
            // 
            // buttonPrzedmioty
            // 
            this.buttonPrzedmioty.AutoSize = true;
            this.buttonPrzedmioty.Location = new System.Drawing.Point(102, 159);
            this.buttonPrzedmioty.Name = "buttonPrzedmioty";
            this.buttonPrzedmioty.Size = new System.Drawing.Size(88, 27);
            this.buttonPrzedmioty.TabIndex = 3;
            this.buttonPrzedmioty.Text = "Przedmioty";
            this.buttonPrzedmioty.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.Location = new System.Drawing.Point(3, 192);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 27);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.AutoSize = true;
            this.button6.Location = new System.Drawing.Point(102, 192);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 27);
            this.button6.TabIndex = 5;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentidDataGridViewTextBoxColumn,
            this.imieDataGridViewTextBoxColumn,
            this.nazwiskoDataGridViewTextBoxColumn,
            this.nrindexuDataGridViewTextBoxColumn,
            this.kierunekDataGridViewTextBoxColumn,
            this.grupaDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.hasloDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studenciBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(277, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(468, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // studenciBindingSource
            // 
            this.studenciBindingSource.DataSource = typeof(DziennikOcen.studenci);
            // 
            // studentidDataGridViewTextBoxColumn
            // 
            this.studentidDataGridViewTextBoxColumn.DataPropertyName = "student_id";
            this.studentidDataGridViewTextBoxColumn.HeaderText = "student_id";
            this.studentidDataGridViewTextBoxColumn.Name = "studentidDataGridViewTextBoxColumn";
            // 
            // imieDataGridViewTextBoxColumn
            // 
            this.imieDataGridViewTextBoxColumn.DataPropertyName = "imie";
            this.imieDataGridViewTextBoxColumn.HeaderText = "imie";
            this.imieDataGridViewTextBoxColumn.Name = "imieDataGridViewTextBoxColumn";
            // 
            // nazwiskoDataGridViewTextBoxColumn
            // 
            this.nazwiskoDataGridViewTextBoxColumn.DataPropertyName = "nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.HeaderText = "nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.Name = "nazwiskoDataGridViewTextBoxColumn";
            // 
            // nrindexuDataGridViewTextBoxColumn
            // 
            this.nrindexuDataGridViewTextBoxColumn.DataPropertyName = "nr_indexu";
            this.nrindexuDataGridViewTextBoxColumn.HeaderText = "nr_indexu";
            this.nrindexuDataGridViewTextBoxColumn.Name = "nrindexuDataGridViewTextBoxColumn";
            // 
            // kierunekDataGridViewTextBoxColumn
            // 
            this.kierunekDataGridViewTextBoxColumn.DataPropertyName = "kierunek";
            this.kierunekDataGridViewTextBoxColumn.HeaderText = "kierunek";
            this.kierunekDataGridViewTextBoxColumn.Name = "kierunekDataGridViewTextBoxColumn";
            // 
            // grupaDataGridViewTextBoxColumn
            // 
            this.grupaDataGridViewTextBoxColumn.DataPropertyName = "grupa";
            this.grupaDataGridViewTextBoxColumn.HeaderText = "grupa";
            this.grupaDataGridViewTextBoxColumn.Name = "grupaDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // hasloDataGridViewTextBoxColumn
            // 
            this.hasloDataGridViewTextBoxColumn.DataPropertyName = "haslo";
            this.hasloDataGridViewTextBoxColumn.HeaderText = "haslo";
            this.hasloDataGridViewTextBoxColumn.Name = "hasloDataGridViewTextBoxColumn";
            // 
            // ocenyprojektBindingSource
            // 
            this.ocenyprojektBindingSource.DataSource = typeof(DziennikOcen.oceny_projekt);
            // 
            // textBoxOcena
            // 
            this.textBoxOcena.Location = new System.Drawing.Point(277, 159);
            this.textBoxOcena.Name = "textBoxOcena";
            this.textBoxOcena.Size = new System.Drawing.Size(256, 22);
            this.textBoxOcena.TabIndex = 8;
            // 
            // buttonZmienOcene
            // 
            this.buttonZmienOcene.AutoSize = true;
            this.buttonZmienOcene.Location = new System.Drawing.Point(277, 192);
            this.buttonZmienOcene.Name = "buttonZmienOcene";
            this.buttonZmienOcene.Size = new System.Drawing.Size(100, 27);
            this.buttonZmienOcene.TabIndex = 9;
            this.buttonZmienOcene.Text = "Zmień ocene";
            this.buttonZmienOcene.UseVisualStyleBackColor = true;
            this.buttonZmienOcene.Click += new System.EventHandler(this.buttonZmienOcene_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 473);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocenyprojektBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonStudenci;
        private System.Windows.Forms.Button buttonProjekty;
        private System.Windows.Forms.Button buttonOceny;
        private System.Windows.Forms.Button buttonPrzedmioty;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource ocenyprojektBindingSource;
        private System.Windows.Forms.BindingSource studenciBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrindexuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kierunekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hasloDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBoxOcena;
        private System.Windows.Forms.Button buttonZmienOcene;
    }
}