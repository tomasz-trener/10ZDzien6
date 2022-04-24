
namespace P01KomunikacjaMiedzyFormularzami
{
    partial class FrmStartowy
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
            this.btnSzczegoly = new System.Windows.Forms.Button();
            this.txtDane = new System.Windows.Forms.TextBox();
            this.btnWyslij = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSzczegoly
            // 
            this.btnSzczegoly.Location = new System.Drawing.Point(12, 12);
            this.btnSzczegoly.Name = "btnSzczegoly";
            this.btnSzczegoly.Size = new System.Drawing.Size(75, 23);
            this.btnSzczegoly.TabIndex = 0;
            this.btnSzczegoly.Text = "Szczegóły";
            this.btnSzczegoly.UseVisualStyleBackColor = true;
            this.btnSzczegoly.Click += new System.EventHandler(this.btnSzczegoly_Click);
            // 
            // txtDane
            // 
            this.txtDane.Location = new System.Drawing.Point(12, 83);
            this.txtDane.Name = "txtDane";
            this.txtDane.Size = new System.Drawing.Size(75, 20);
            this.txtDane.TabIndex = 1;
            // 
            // btnWyslij
            // 
            this.btnWyslij.Location = new System.Drawing.Point(12, 54);
            this.btnWyslij.Name = "btnWyslij";
            this.btnWyslij.Size = new System.Drawing.Size(75, 23);
            this.btnWyslij.TabIndex = 2;
            this.btnWyslij.Text = "Wyślij";
            this.btnWyslij.UseVisualStyleBackColor = true;
            this.btnWyslij.Click += new System.EventHandler(this.btnWyslij_Click);
            // 
            // FrmStartowy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(128, 143);
            this.Controls.Add(this.btnWyslij);
            this.Controls.Add(this.txtDane);
            this.Controls.Add(this.btnSzczegoly);
            this.Name = "FrmStartowy";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSzczegoly;
        private System.Windows.Forms.TextBox txtDane;
        private System.Windows.Forms.Button btnWyslij;
    }
}

