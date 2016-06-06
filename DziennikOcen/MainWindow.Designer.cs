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
            this.studenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ocenyprojektBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocenyprojektBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.75F));
            this.tableLayoutPanel1.Controls.Add(this.buttonStudenci, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonProjekty, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonOceny, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonPrzedmioty, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.button6, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(604, 384);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonStudenci
            // 
            this.buttonStudenci.AutoSize = true;
            this.buttonStudenci.Location = new System.Drawing.Point(2, 2);
            this.buttonStudenci.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonStudenci.Name = "buttonStudenci";
            this.buttonStudenci.Size = new System.Drawing.Size(59, 23);
            this.buttonStudenci.TabIndex = 0;
            this.buttonStudenci.Text = "Studenci";
            this.buttonStudenci.UseVisualStyleBackColor = true;
            this.buttonStudenci.Click += new System.EventHandler(this.buttonStudenci_Click);
            // 
            // buttonProjekty
            // 
            this.buttonProjekty.AutoSize = true;
            this.buttonProjekty.Location = new System.Drawing.Point(220, 2);
            this.buttonProjekty.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonProjekty.Name = "buttonProjekty";
            this.buttonProjekty.Size = new System.Drawing.Size(56, 23);
            this.buttonProjekty.TabIndex = 1;
            this.buttonProjekty.Text = "Projekty";
            this.buttonProjekty.UseVisualStyleBackColor = true;
            // 
            // buttonOceny
            // 
            this.buttonOceny.AutoSize = true;
            this.buttonOceny.Location = new System.Drawing.Point(2, 29);
            this.buttonOceny.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOceny.Name = "buttonOceny";
            this.buttonOceny.Size = new System.Drawing.Size(56, 23);
            this.buttonOceny.TabIndex = 2;
            this.buttonOceny.Text = "Oceny";
            this.buttonOceny.UseVisualStyleBackColor = true;
            // 
            // buttonPrzedmioty
            // 
            this.buttonPrzedmioty.AutoSize = true;
            this.buttonPrzedmioty.Location = new System.Drawing.Point(220, 29);
            this.buttonPrzedmioty.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPrzedmioty.Name = "buttonPrzedmioty";
            this.buttonPrzedmioty.Size = new System.Drawing.Size(68, 23);
            this.buttonPrzedmioty.TabIndex = 3;
            this.buttonPrzedmioty.Text = "Przedmioty";
            this.buttonPrzedmioty.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.AutoSize = true;
            this.button6.Location = new System.Drawing.Point(220, 56);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(56, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.Location = new System.Drawing.Point(2, 56);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 384);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}