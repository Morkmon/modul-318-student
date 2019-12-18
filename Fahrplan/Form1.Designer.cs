namespace Fahrplan
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
            this.abfahrt = new System.Windows.Forms.Label();
            this.zielort = new System.Windows.Forms.Label();
            this.Verbindungsuchen = new System.Windows.Forms.Button();
            this.comoBoxAbfahrtsort = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // abfahrt
            // 
            this.abfahrt.AutoSize = true;
            this.abfahrt.Location = new System.Drawing.Point(93, 71);
            this.abfahrt.Name = "abfahrt";
            this.abfahrt.Size = new System.Drawing.Size(37, 17);
            this.abfahrt.TabIndex = 0;
            this.abfahrt.Text = "Von:";
            this.abfahrt.Click += new System.EventHandler(this.label1_Click);
            // 
            // zielort
            // 
            this.zielort.AutoSize = true;
            this.zielort.Location = new System.Drawing.Point(364, 71);
            this.zielort.Name = "zielort";
            this.zielort.Size = new System.Drawing.Size(45, 17);
            this.zielort.TabIndex = 1;
            this.zielort.Text = "Nach:";
            // 
            // Verbindungsuchen
            // 
            this.Verbindungsuchen.Location = new System.Drawing.Point(641, 100);
            this.Verbindungsuchen.Name = "Verbindungsuchen";
            this.Verbindungsuchen.Size = new System.Drawing.Size(120, 27);
            this.Verbindungsuchen.TabIndex = 4;
            this.Verbindungsuchen.Text = "Suchen";
            this.Verbindungsuchen.UseVisualStyleBackColor = true;
            this.Verbindungsuchen.Click += new System.EventHandler(this.suchen_Click);
            // 
            // comoBoxAbfahrtsort
            // 
            this.comoBoxAbfahrtsort.FormattingEnabled = true;
            this.comoBoxAbfahrtsort.Location = new System.Drawing.Point(96, 100);
            this.comoBoxAbfahrtsort.Name = "comoBoxAbfahrtsort";
            this.comoBoxAbfahrtsort.Size = new System.Drawing.Size(252, 24);
            this.comoBoxAbfahrtsort.TabIndex = 5;
            this.comoBoxAbfahrtsort.SelectedIndexChanged += new System.EventHandler(this.Abfahrtsort_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(367, 100);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(252, 24);
            this.comboBox2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comoBoxAbfahrtsort);
            this.Controls.Add(this.Verbindungsuchen);
            this.Controls.Add(this.zielort);
            this.Controls.Add(this.abfahrt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label abfahrt;
        private System.Windows.Forms.Label zielort;
        private System.Windows.Forms.Button Verbindungsuchen;
        private System.Windows.Forms.ComboBox comoBoxAbfahrtsort;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

