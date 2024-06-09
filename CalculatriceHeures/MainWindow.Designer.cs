namespace CalculatriceHeures
{
    partial class CalculHeure
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.ConfirmBTN = new System.Windows.Forms.Button();
            this.entryIN = new System.Windows.Forms.TextBox();
            this.exitIN = new System.Windows.Forms.TextBox();
            this.entryLBL = new System.Windows.Forms.Label();
            this.exitLBL = new System.Windows.Forms.Label();
            this.workingHourLBL = new System.Windows.Forms.Label();
            this.resultLBL = new System.Windows.Forms.Label();
            this.errorLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ConfirmBTN
            // 
            this.ConfirmBTN.Location = new System.Drawing.Point(330, 255);
            this.ConfirmBTN.Name = "ConfirmBTN";
            this.ConfirmBTN.Size = new System.Drawing.Size(122, 40);
            this.ConfirmBTN.TabIndex = 2;
            this.ConfirmBTN.Text = "&Calcul";
            this.ConfirmBTN.UseVisualStyleBackColor = true;
            this.ConfirmBTN.Click += new System.EventHandler(this.ConfirmBTN_Click);
            // 
            // entryIN
            // 
            this.entryIN.Location = new System.Drawing.Point(330, 132);
            this.entryIN.Name = "entryIN";
            this.entryIN.Size = new System.Drawing.Size(122, 20);
            this.entryIN.TabIndex = 0;
            // 
            // exitIN
            // 
            this.exitIN.Location = new System.Drawing.Point(330, 185);
            this.exitIN.Name = "exitIN";
            this.exitIN.Size = new System.Drawing.Size(122, 20);
            this.exitIN.TabIndex = 1;
            // 
            // entryLBL
            // 
            this.entryLBL.AutoSize = true;
            this.entryLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryLBL.Location = new System.Drawing.Point(326, 109);
            this.entryLBL.Name = "entryLBL";
            this.entryLBL.Size = new System.Drawing.Size(115, 20);
            this.entryLBL.TabIndex = 3;
            this.entryLBL.Text = "Heure d\'entrée";
            // 
            // exitLBL
            // 
            this.exitLBL.AutoSize = true;
            this.exitLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLBL.Location = new System.Drawing.Point(326, 162);
            this.exitLBL.Name = "exitLBL";
            this.exitLBL.Size = new System.Drawing.Size(96, 20);
            this.exitLBL.TabIndex = 4;
            this.exitLBL.Text = "Heure de fin";
            // 
            // workingHourLBL
            // 
            this.workingHourLBL.AutoSize = true;
            this.workingHourLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workingHourLBL.Location = new System.Drawing.Point(326, 307);
            this.workingHourLBL.Name = "workingHourLBL";
            this.workingHourLBL.Size = new System.Drawing.Size(126, 20);
            this.workingHourLBL.TabIndex = 5;
            this.workingHourLBL.Text = "Heures travaillés";
            // 
            // resultLBL
            // 
            this.resultLBL.AutoSize = true;
            this.resultLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLBL.Location = new System.Drawing.Point(366, 339);
            this.resultLBL.Name = "resultLBL";
            this.resultLBL.Size = new System.Drawing.Size(45, 20);
            this.resultLBL.TabIndex = 6;
            this.resultLBL.Text = "0h00";
            // 
            // errorLBL
            // 
            this.errorLBL.AutoSize = true;
            this.errorLBL.ForeColor = System.Drawing.Color.Red;
            this.errorLBL.Location = new System.Drawing.Point(314, 226);
            this.errorLBL.Name = "errorLBL";
            this.errorLBL.Size = new System.Drawing.Size(77, 13);
            this.errorLBL.TabIndex = 7;
            this.errorLBL.Text = "ERROR TEXT";
            // 
            // CalculHeure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.errorLBL);
            this.Controls.Add(this.resultLBL);
            this.Controls.Add(this.workingHourLBL);
            this.Controls.Add(this.exitLBL);
            this.Controls.Add(this.entryLBL);
            this.Controls.Add(this.exitIN);
            this.Controls.Add(this.entryIN);
            this.Controls.Add(this.ConfirmBTN);
            this.Name = "CalculHeure";
            this.Text = "Calculatrice d\'heures";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConfirmBTN;
        private System.Windows.Forms.TextBox entryIN;
        private System.Windows.Forms.TextBox exitIN;
        private System.Windows.Forms.Label entryLBL;
        private System.Windows.Forms.Label exitLBL;
        private System.Windows.Forms.Label workingHourLBL;
        private System.Windows.Forms.Label resultLBL;
        private System.Windows.Forms.Label errorLBL;
    }
}

