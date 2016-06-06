namespace DziennikOcen
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelHaslo = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxHaslo = new System.Windows.Forms.TextBox();
            this.buttonZaloguj = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(60, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "DZIENNIK OCEN STUDENTÓW";
            this.label1.Click += new System.EventHandler(this.Form1_Load);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(147, 102);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(33, 13);
            this.labelLogin.TabIndex = 1;
            this.labelLogin.Text = "Login";
            this.labelLogin.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // labelHaslo
            // 
            this.labelHaslo.AutoSize = true;
            this.labelHaslo.Location = new System.Drawing.Point(147, 202);
            this.labelHaslo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHaslo.Name = "labelHaslo";
            this.labelHaslo.Size = new System.Drawing.Size(36, 13);
            this.labelHaslo.TabIndex = 2;
            this.labelHaslo.Text = "Hasło";
            this.labelHaslo.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(206, 98);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(126, 20);
            this.textBoxLogin.TabIndex = 3;
            // 
            // textBoxHaslo
            // 
            this.textBoxHaslo.Location = new System.Drawing.Point(206, 202);
            this.textBoxHaslo.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxHaslo.Name = "textBoxHaslo";
            this.textBoxHaslo.PasswordChar = '*';
            this.textBoxHaslo.Size = new System.Drawing.Size(126, 20);
            this.textBoxHaslo.TabIndex = 4;
            // 
            // buttonZaloguj
            // 
            this.buttonZaloguj.Location = new System.Drawing.Point(206, 281);
            this.buttonZaloguj.Margin = new System.Windows.Forms.Padding(2);
            this.buttonZaloguj.Name = "buttonZaloguj";
            this.buttonZaloguj.Size = new System.Drawing.Size(64, 24);
            this.buttonZaloguj.TabIndex = 5;
            this.buttonZaloguj.Text = "Zaloguj";
            this.buttonZaloguj.UseVisualStyleBackColor = true;
            this.buttonZaloguj.Click += new System.EventHandler(this.buttonZaloguj_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(306, 204);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Size = new System.Drawing.Size(150, 100);
            this.splitContainer1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 423);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.buttonZaloguj);
            this.Controls.Add(this.textBoxHaslo);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.labelHaslo);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Dziennik Ocen Studentów";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelHaslo;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxHaslo;
        private System.Windows.Forms.Button buttonZaloguj;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

