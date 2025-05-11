
namespace MediaTek86.view
{
    partial class FormGestionAbsence
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
            this.grpBoxAbsence = new System.Windows.Forms.GroupBox();
            this.btnAddAbsence = new System.Windows.Forms.Button();
            this.btnSuppr = new System.Windows.Forms.Button();
            this.btnGestPersonnel = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.dgvAbsence = new System.Windows.Forms.DataGridView();
            this.grpBoxAddModAbsence = new System.Windows.Forms.GroupBox();
            this.timepickFin = new System.Windows.Forms.DateTimePicker();
            this.timepickDebut = new System.Windows.Forms.DateTimePicker();
            this.cmbBoxMotif = new System.Windows.Forms.ComboBox();
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.lblMotif = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.grpBoxAbsence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsence)).BeginInit();
            this.grpBoxAddModAbsence.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxAbsence
            // 
            this.grpBoxAbsence.Controls.Add(this.btnAddAbsence);
            this.grpBoxAbsence.Controls.Add(this.btnSuppr);
            this.grpBoxAbsence.Controls.Add(this.btnGestPersonnel);
            this.grpBoxAbsence.Controls.Add(this.btnModifier);
            this.grpBoxAbsence.Controls.Add(this.dgvAbsence);
            this.grpBoxAbsence.Location = new System.Drawing.Point(12, 12);
            this.grpBoxAbsence.Name = "grpBoxAbsence";
            this.grpBoxAbsence.Size = new System.Drawing.Size(776, 207);
            this.grpBoxAbsence.TabIndex = 0;
            this.grpBoxAbsence.TabStop = false;
            this.grpBoxAbsence.Text = "Absence";
            // 
            // btnAddAbsence
            // 
            this.btnAddAbsence.Location = new System.Drawing.Point(657, 175);
            this.btnAddAbsence.Name = "btnAddAbsence";
            this.btnAddAbsence.Size = new System.Drawing.Size(113, 23);
            this.btnAddAbsence.TabIndex = 4;
            this.btnAddAbsence.Text = "Ajouter une absence";
            this.btnAddAbsence.UseVisualStyleBackColor = true;
            // 
            // btnSuppr
            // 
            this.btnSuppr.Location = new System.Drawing.Point(244, 175);
            this.btnSuppr.Name = "btnSuppr";
            this.btnSuppr.Size = new System.Drawing.Size(113, 23);
            this.btnSuppr.TabIndex = 3;
            this.btnSuppr.Text = "Supprimer";
            this.btnSuppr.UseVisualStyleBackColor = true;
            // 
            // btnGestPersonnel
            // 
            this.btnGestPersonnel.Location = new System.Drawing.Point(125, 175);
            this.btnGestPersonnel.Name = "btnGestPersonnel";
            this.btnGestPersonnel.Size = new System.Drawing.Size(113, 23);
            this.btnGestPersonnel.TabIndex = 2;
            this.btnGestPersonnel.Text = "Gestion personnel";
            this.btnGestPersonnel.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(6, 175);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(113, 23);
            this.btnModifier.TabIndex = 1;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // dgvAbsence
            // 
            this.dgvAbsence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsence.Location = new System.Drawing.Point(6, 19);
            this.dgvAbsence.Name = "dgvAbsence";
            this.dgvAbsence.Size = new System.Drawing.Size(764, 150);
            this.dgvAbsence.TabIndex = 0;
            // 
            // grpBoxAddModAbsence
            // 
            this.grpBoxAddModAbsence.Controls.Add(this.timepickFin);
            this.grpBoxAddModAbsence.Controls.Add(this.timepickDebut);
            this.grpBoxAddModAbsence.Controls.Add(this.cmbBoxMotif);
            this.grpBoxAddModAbsence.Controls.Add(this.lblDateDebut);
            this.grpBoxAddModAbsence.Controls.Add(this.lblDateFin);
            this.grpBoxAddModAbsence.Controls.Add(this.lblMotif);
            this.grpBoxAddModAbsence.Controls.Add(this.btnAnnuler);
            this.grpBoxAddModAbsence.Controls.Add(this.btnEnregistrer);
            this.grpBoxAddModAbsence.Location = new System.Drawing.Point(12, 225);
            this.grpBoxAddModAbsence.Name = "grpBoxAddModAbsence";
            this.grpBoxAddModAbsence.Size = new System.Drawing.Size(776, 100);
            this.grpBoxAddModAbsence.TabIndex = 1;
            this.grpBoxAddModAbsence.TabStop = false;
            this.grpBoxAddModAbsence.Text = "Ajouter et modifier une absence";
            // 
            // timepickFin
            // 
            this.timepickFin.Location = new System.Drawing.Point(378, 28);
            this.timepickFin.Name = "timepickFin";
            this.timepickFin.Size = new System.Drawing.Size(152, 20);
            this.timepickFin.TabIndex = 5;
            // 
            // timepickDebut
            // 
            this.timepickDebut.Location = new System.Drawing.Point(93, 28);
            this.timepickDebut.Name = "timepickDebut";
            this.timepickDebut.Size = new System.Drawing.Size(152, 20);
            this.timepickDebut.TabIndex = 8;
            // 
            // cmbBoxMotif
            // 
            this.cmbBoxMotif.FormattingEnabled = true;
            this.cmbBoxMotif.Location = new System.Drawing.Point(618, 28);
            this.cmbBoxMotif.Name = "cmbBoxMotif";
            this.cmbBoxMotif.Size = new System.Drawing.Size(152, 21);
            this.cmbBoxMotif.TabIndex = 5;
            // 
            // lblDateDebut
            // 
            this.lblDateDebut.AutoSize = true;
            this.lblDateDebut.Location = new System.Drawing.Point(6, 31);
            this.lblDateDebut.Name = "lblDateDebut";
            this.lblDateDebut.Size = new System.Drawing.Size(81, 13);
            this.lblDateDebut.TabIndex = 4;
            this.lblDateDebut.Text = "Date de début :";
            // 
            // lblDateFin
            // 
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.Location = new System.Drawing.Point(307, 31);
            this.lblDateFin.Name = "lblDateFin";
            this.lblDateFin.Size = new System.Drawing.Size(65, 13);
            this.lblDateFin.TabIndex = 3;
            this.lblDateFin.Text = "Date de fin :";
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Location = new System.Drawing.Point(576, 31);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(36, 13);
            this.lblMotif.TabIndex = 2;
            this.lblMotif.Text = "Motif :";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(128, 63);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(113, 23);
            this.btnAnnuler.TabIndex = 1;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(9, 63);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(113, 23);
            this.btnEnregistrer.TabIndex = 0;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // FormGestionAbsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 339);
            this.Controls.Add(this.grpBoxAddModAbsence);
            this.Controls.Add(this.grpBoxAbsence);
            this.Name = "FormGestionAbsence";
            this.Text = "FormGestionAbsence";
            this.grpBoxAbsence.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsence)).EndInit();
            this.grpBoxAddModAbsence.ResumeLayout(false);
            this.grpBoxAddModAbsence.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxAbsence;
        private System.Windows.Forms.DataGridView dgvAbsence;
        private System.Windows.Forms.Button btnAddAbsence;
        private System.Windows.Forms.Button btnSuppr;
        private System.Windows.Forms.Button btnGestPersonnel;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.GroupBox grpBoxAddModAbsence;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.ComboBox cmbBoxMotif;
        private System.Windows.Forms.Label lblDateDebut;
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.DateTimePicker timepickFin;
        private System.Windows.Forms.DateTimePicker timepickDebut;
    }
}