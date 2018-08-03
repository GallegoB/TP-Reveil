namespace WindowsFormsApplication1
{
    partial class reveil
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
            this.grpRappel = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRappel = new System.Windows.Forms.TextBox();
            this.cboFrequence = new System.Windows.Forms.ComboBox();
            this.dtpHeure = new System.Windows.Forms.DateTimePicker();
            this.dtpJour = new System.Windows.Forms.DateTimePicker();
            this.btnAjout = new System.Windows.Forms.Button();
            this.grpEnsemble = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label0 = new System.Windows.Forms.Label();
            this.lstEnsemble = new System.Windows.Forms.ListBox();
            this.btnVider = new System.Windows.Forms.Button();
            this.btnSuppr = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            this.grpMaintenant = new System.Windows.Forms.GroupBox();
            this.lblHeure = new System.Windows.Forms.Label();
            this.LblDate = new System.Windows.Forms.Label();
            this.grpRappel.SuspendLayout();
            this.grpEnsemble.SuspendLayout();
            this.grpMaintenant.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRappel
            // 
            this.grpRappel.Controls.Add(this.label7);
            this.grpRappel.Controls.Add(this.label6);
            this.grpRappel.Controls.Add(this.label5);
            this.grpRappel.Controls.Add(this.txtRappel);
            this.grpRappel.Controls.Add(this.cboFrequence);
            this.grpRappel.Controls.Add(this.dtpHeure);
            this.grpRappel.Controls.Add(this.dtpJour);
            this.grpRappel.Controls.Add(this.btnAjout);
            this.grpRappel.Location = new System.Drawing.Point(12, 19);
            this.grpRappel.Name = "grpRappel";
            this.grpRappel.Size = new System.Drawing.Size(417, 87);
            this.grpRappel.TabIndex = 0;
            this.grpRappel.TabStop = false;
            this.grpRappel.Text = "Un rappel";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(176, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "fréquence";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "heure";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "date";
            // 
            // txtRappel
            // 
            this.txtRappel.Location = new System.Drawing.Point(6, 58);
            this.txtRappel.Name = "txtRappel";
            this.txtRappel.Size = new System.Drawing.Size(324, 20);
            this.txtRappel.TabIndex = 5;
            // 
            // cboFrequence
            // 
            this.cboFrequence.FormattingEnabled = true;
            this.cboFrequence.Items.AddRange(new object[] {
            "Unique",
            "Journalier",
            "Hebdomadaire",
            "Mensuel",
            "Annuel"});
            this.cboFrequence.Location = new System.Drawing.Point(179, 33);
            this.cboFrequence.Name = "cboFrequence";
            this.cboFrequence.Size = new System.Drawing.Size(152, 21);
            this.cboFrequence.TabIndex = 3;
            // 
            // dtpHeure
            // 
            this.dtpHeure.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHeure.Location = new System.Drawing.Point(103, 34);
            this.dtpHeure.Name = "dtpHeure";
            this.dtpHeure.ShowUpDown = true;
            this.dtpHeure.Size = new System.Drawing.Size(70, 20);
            this.dtpHeure.TabIndex = 4;
            // 
            // dtpJour
            // 
            this.dtpJour.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpJour.Location = new System.Drawing.Point(6, 34);
            this.dtpJour.Name = "dtpJour";
            this.dtpJour.Size = new System.Drawing.Size(91, 20);
            this.dtpJour.TabIndex = 3;
            // 
            // btnAjout
            // 
            this.btnAjout.Location = new System.Drawing.Point(336, 58);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(75, 23);
            this.btnAjout.TabIndex = 3;
            this.btnAjout.Text = "Ajout";
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // grpEnsemble
            // 
            this.grpEnsemble.Controls.Add(this.label4);
            this.grpEnsemble.Controls.Add(this.label3);
            this.grpEnsemble.Controls.Add(this.label2);
            this.grpEnsemble.Controls.Add(this.label1);
            this.grpEnsemble.Controls.Add(this.label0);
            this.grpEnsemble.Controls.Add(this.lstEnsemble);
            this.grpEnsemble.Controls.Add(this.btnVider);
            this.grpEnsemble.Controls.Add(this.btnSuppr);
            this.grpEnsemble.Controls.Add(this.btnModif);
            this.grpEnsemble.Location = new System.Drawing.Point(12, 112);
            this.grpEnsemble.Name = "grpEnsemble";
            this.grpEnsemble.Size = new System.Drawing.Size(579, 182);
            this.grpEnsemble.TabIndex = 1;
            this.grpEnsemble.TabStop = false;
            this.grpEnsemble.Text = "Ensemble des rappels";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(275, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Annuel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(215, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mensuel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(121, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Hebdomadaire";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(53, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Journalier";
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label0.Location = new System.Drawing.Point(6, 166);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(47, 13);
            this.label0.TabIndex = 8;
            this.label0.Text = "Unique";
            // 
            // lstEnsemble
            // 
            this.lstEnsemble.FormattingEnabled = true;
            this.lstEnsemble.Location = new System.Drawing.Point(6, 19);
            this.lstEnsemble.Name = "lstEnsemble";
            this.lstEnsemble.Size = new System.Drawing.Size(486, 134);
            this.lstEnsemble.TabIndex = 7;
            // 
            // btnVider
            // 
            this.btnVider.Location = new System.Drawing.Point(498, 77);
            this.btnVider.Name = "btnVider";
            this.btnVider.Size = new System.Drawing.Size(75, 23);
            this.btnVider.TabIndex = 6;
            this.btnVider.Text = "Vider";
            this.btnVider.UseVisualStyleBackColor = true;
            this.btnVider.Click += new System.EventHandler(this.btnVider_Click);
            // 
            // btnSuppr
            // 
            this.btnSuppr.Location = new System.Drawing.Point(498, 48);
            this.btnSuppr.Name = "btnSuppr";
            this.btnSuppr.Size = new System.Drawing.Size(75, 23);
            this.btnSuppr.TabIndex = 5;
            this.btnSuppr.Text = "Supprimer";
            this.btnSuppr.UseVisualStyleBackColor = true;
            this.btnSuppr.Click += new System.EventHandler(this.btnSuppr_Click);
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(498, 19);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(75, 23);
            this.btnModif.TabIndex = 4;
            this.btnModif.Text = "Modif";
            this.btnModif.UseVisualStyleBackColor = true;
            // 
            // grpMaintenant
            // 
            this.grpMaintenant.Controls.Add(this.lblHeure);
            this.grpMaintenant.Controls.Add(this.LblDate);
            this.grpMaintenant.Location = new System.Drawing.Point(441, 20);
            this.grpMaintenant.Name = "grpMaintenant";
            this.grpMaintenant.Size = new System.Drawing.Size(150, 86);
            this.grpMaintenant.TabIndex = 2;
            this.grpMaintenant.TabStop = false;
            this.grpMaintenant.Text = "Maintenant";
            // 
            // lblHeure
            // 
            this.lblHeure.AutoSize = true;
            this.lblHeure.Location = new System.Drawing.Point(6, 33);
            this.lblHeure.Name = "lblHeure";
            this.lblHeure.Size = new System.Drawing.Size(0, 13);
            this.lblHeure.TabIndex = 3;
            this.lblHeure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Location = new System.Drawing.Point(6, 16);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(0, 13);
            this.LblDate.TabIndex = 8;
            this.LblDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // reveil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 305);
            this.Controls.Add(this.grpMaintenant);
            this.Controls.Add(this.grpEnsemble);
            this.Controls.Add(this.grpRappel);
            this.Name = "reveil";
            this.Text = "Réveil";
            this.grpRappel.ResumeLayout(false);
            this.grpRappel.PerformLayout();
            this.grpEnsemble.ResumeLayout(false);
            this.grpEnsemble.PerformLayout();
            this.grpMaintenant.ResumeLayout(false);
            this.grpMaintenant.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRappel;
        private System.Windows.Forms.GroupBox grpEnsemble;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.Button btnVider;
        private System.Windows.Forms.Button btnSuppr;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.GroupBox grpMaintenant;
        private System.Windows.Forms.TextBox txtRappel;
        private System.Windows.Forms.ComboBox cboFrequence;
        private System.Windows.Forms.DateTimePicker dtpHeure;
        private System.Windows.Forms.DateTimePicker dtpJour;
        private System.Windows.Forms.ListBox lstEnsemble;
        private System.Windows.Forms.Label lblHeure;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

