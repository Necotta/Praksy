namespace Praksy
{
    partial class Apka
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.aktualnaData = new System.Windows.Forms.Label();
            this.aktualnyCzas = new System.Windows.Forms.Label();
            this.doKoncaPraktyk = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // aktualnaData
            // 
            this.aktualnaData.AutoSize = true;
            this.aktualnaData.Location = new System.Drawing.Point(12, 23);
            this.aktualnaData.Name = "aktualnaData";
            this.aktualnaData.Size = new System.Drawing.Size(76, 13);
            this.aktualnaData.TabIndex = 0;
            this.aktualnaData.Text = "Aktualna data:";
            // 
            // aktualnyCzas
            // 
            this.aktualnyCzas.AutoSize = true;
            this.aktualnyCzas.Location = new System.Drawing.Point(12, 47);
            this.aktualnyCzas.Name = "aktualnyCzas";
            this.aktualnyCzas.Size = new System.Drawing.Size(76, 13);
            this.aktualnyCzas.TabIndex = 1;
            this.aktualnyCzas.Text = "Aktualny czas:";
            // 
            // doKoncaPraktyk
            // 
            this.doKoncaPraktyk.AutoSize = true;
            this.doKoncaPraktyk.Location = new System.Drawing.Point(12, 96);
            this.doKoncaPraktyk.Name = "doKoncaPraktyk";
            this.doKoncaPraktyk.Size = new System.Drawing.Size(95, 13);
            this.doKoncaPraktyk.TabIndex = 2;
            this.doKoncaPraktyk.Text = "Do końca praktyk:";
            // 
            // Apka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 137);
            this.Controls.Add(this.doKoncaPraktyk);
            this.Controls.Add(this.aktualnyCzas);
            this.Controls.Add(this.aktualnaData);
            this.Name = "Apka";
            this.Text = "Apka";
            this.Load += new System.EventHandler(this.Apka_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aktualnaData;
        private System.Windows.Forms.Label aktualnyCzas;
        private System.Windows.Forms.Label doKoncaPraktyk;
    }
}

