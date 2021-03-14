
namespace Fakturace_Holas
{
    partial class FrmVyber
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnZakaznici = new System.Windows.Forms.Button();
            this.BtnProdukty = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnZakaznici
            // 
            this.BtnZakaznici.Location = new System.Drawing.Point(12, 12);
            this.BtnZakaznici.Name = "BtnZakaznici";
            this.BtnZakaznici.Size = new System.Drawing.Size(141, 70);
            this.BtnZakaznici.TabIndex = 0;
            this.BtnZakaznici.Text = "Zákazníci";
            this.BtnZakaznici.UseVisualStyleBackColor = true;
            // 
            // BtnProdukty
            // 
            this.BtnProdukty.Location = new System.Drawing.Point(180, 12);
            this.BtnProdukty.Name = "BtnProdukty";
            this.BtnProdukty.Size = new System.Drawing.Size(145, 70);
            this.BtnProdukty.TabIndex = 1;
            this.BtnProdukty.Text = "Produkty";
            this.BtnProdukty.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 94);
            this.Controls.Add(this.BtnProdukty);
            this.Controls.Add(this.BtnZakaznici);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnZakaznici;
        private System.Windows.Forms.Button BtnProdukty;
    }
}

