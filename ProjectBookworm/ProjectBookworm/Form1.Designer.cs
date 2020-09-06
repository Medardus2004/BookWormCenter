namespace ProjectBookworm
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.verschluesselButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.EingabeVerschluessel = new System.Windows.Forms.TextBox();
            this.AusgabeVerschluessel = new System.Windows.Forms.TextBox();
            this.EingabeEntschluessel = new System.Windows.Forms.TextBox();
            this.AusgabeEntschluessel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // verschluesselButton
            // 
            this.verschluesselButton.Location = new System.Drawing.Point(546, 77);
            this.verschluesselButton.Name = "verschluesselButton";
            this.verschluesselButton.Size = new System.Drawing.Size(75, 23);
            this.verschluesselButton.TabIndex = 0;
            this.verschluesselButton.Text = "Verschlüsseln";
            this.verschluesselButton.UseVisualStyleBackColor = true;
            this.verschluesselButton.Click += new System.EventHandler(this.verschluessel_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(546, 122);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Entschlüsseln";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // EingabeVerschluessel
            // 
            this.EingabeVerschluessel.Location = new System.Drawing.Point(256, 80);
            this.EingabeVerschluessel.Name = "EingabeVerschluessel";
            this.EingabeVerschluessel.Size = new System.Drawing.Size(100, 20);
            this.EingabeVerschluessel.TabIndex = 2;
            // 
            // AusgabeVerschluessel
            // 
            this.AusgabeVerschluessel.Location = new System.Drawing.Point(412, 80);
            this.AusgabeVerschluessel.Name = "AusgabeVerschluessel";
            this.AusgabeVerschluessel.Size = new System.Drawing.Size(100, 20);
            this.AusgabeVerschluessel.TabIndex = 3;
            // 
            // EingabeEntschluessel
            // 
            this.EingabeEntschluessel.Location = new System.Drawing.Point(256, 122);
            this.EingabeEntschluessel.Name = "EingabeEntschluessel";
            this.EingabeEntschluessel.Size = new System.Drawing.Size(100, 20);
            this.EingabeEntschluessel.TabIndex = 4;
            // 
            // AusgabeEntschluessel
            // 
            this.AusgabeEntschluessel.Location = new System.Drawing.Point(412, 122);
            this.AusgabeEntschluessel.Name = "AusgabeEntschluessel";
            this.AusgabeEntschluessel.Size = new System.Drawing.Size(100, 20);
            this.AusgabeEntschluessel.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AusgabeEntschluessel);
            this.Controls.Add(this.EingabeEntschluessel);
            this.Controls.Add(this.AusgabeVerschluessel);
            this.Controls.Add(this.EingabeVerschluessel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.verschluesselButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button verschluesselButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox EingabeVerschluessel;
        private System.Windows.Forms.TextBox AusgabeVerschluessel;
        private System.Windows.Forms.TextBox EingabeEntschluessel;
        private System.Windows.Forms.TextBox AusgabeEntschluessel;
    }
}

