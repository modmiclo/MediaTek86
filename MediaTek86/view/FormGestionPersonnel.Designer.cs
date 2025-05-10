
namespace MediaTek86.view
{
    partial class FormGestionPersonnel
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
            this.grpBoxPersonnel = new System.Windows.Forms.GroupBox();
            this.btnAddPersonnel = new System.Windows.Forms.Button();
            this.btnSuppr = new System.Windows.Forms.Button();
            this.btnGestAbsence = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.dgvPersonnel = new System.Windows.Forms.DataGridView();
            this.grpBoxAddModPersonnel = new System.Windows.Forms.GroupBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.txtBoxMail = new System.Windows.Forms.TextBox();
            this.txtBoxTel = new System.Windows.Forms.TextBox();
            this.txtBoxPrenom = new System.Windows.Forms.TextBox();
            this.txtBoxNom = new System.Windows.Forms.TextBox();
            this.cmbBoxService = new System.Windows.Forms.ComboBox();
            this.lblService = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.grpBoxPersonnel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).BeginInit();
            this.grpBoxAddModPersonnel.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxPersonnel
            // 
            this.grpBoxPersonnel.Controls.Add(this.btnAddPersonnel);
            this.grpBoxPersonnel.Controls.Add(this.btnSuppr);
            this.grpBoxPersonnel.Controls.Add(this.btnGestAbsence);
            this.grpBoxPersonnel.Controls.Add(this.btnModifier);
            this.grpBoxPersonnel.Controls.Add(this.dgvPersonnel);
            this.grpBoxPersonnel.Location = new System.Drawing.Point(12, 12);
            this.grpBoxPersonnel.Name = "grpBoxPersonnel";
            this.grpBoxPersonnel.Size = new System.Drawing.Size(781, 209);
            this.grpBoxPersonnel.TabIndex = 0;
            this.grpBoxPersonnel.TabStop = false;
            this.grpBoxPersonnel.Text = "Personnel";
            // 
            // btnAddPersonnel
            // 
            this.btnAddPersonnel.Location = new System.Drawing.Point(648, 175);
            this.btnAddPersonnel.Name = "btnAddPersonnel";
            this.btnAddPersonnel.Size = new System.Drawing.Size(127, 23);
            this.btnAddPersonnel.TabIndex = 4;
            this.btnAddPersonnel.Text = "Ajouter un personnel";
            this.btnAddPersonnel.UseVisualStyleBackColor = true;
            // 
            // btnSuppr
            // 
            this.btnSuppr.Location = new System.Drawing.Point(272, 175);
            this.btnSuppr.Name = "btnSuppr";
            this.btnSuppr.Size = new System.Drawing.Size(127, 23);
            this.btnSuppr.TabIndex = 3;
            this.btnSuppr.Text = "Supprimer";
            this.btnSuppr.UseVisualStyleBackColor = true;
            // 
            // btnGestAbsence
            // 
            this.btnGestAbsence.Location = new System.Drawing.Point(139, 175);
            this.btnGestAbsence.Name = "btnGestAbsence";
            this.btnGestAbsence.Size = new System.Drawing.Size(127, 23);
            this.btnGestAbsence.TabIndex = 2;
            this.btnGestAbsence.Text = "Gestion absence";
            this.btnGestAbsence.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(6, 175);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(127, 23);
            this.btnModifier.TabIndex = 1;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // dgvPersonnel
            // 
            this.dgvPersonnel.AllowUserToAddRows = false;
            this.dgvPersonnel.AllowUserToDeleteRows = false;
            this.dgvPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonnel.Location = new System.Drawing.Point(6, 19);
            this.dgvPersonnel.Name = "dgvPersonnel";
            this.dgvPersonnel.ReadOnly = true;
            this.dgvPersonnel.Size = new System.Drawing.Size(769, 150);
            this.dgvPersonnel.TabIndex = 0;
            // 
            // grpBoxAddModPersonnel
            // 
            this.grpBoxAddModPersonnel.Controls.Add(this.btnAnnuler);
            this.grpBoxAddModPersonnel.Controls.Add(this.btnEnregistrer);
            this.grpBoxAddModPersonnel.Controls.Add(this.txtBoxMail);
            this.grpBoxAddModPersonnel.Controls.Add(this.txtBoxTel);
            this.grpBoxAddModPersonnel.Controls.Add(this.txtBoxPrenom);
            this.grpBoxAddModPersonnel.Controls.Add(this.txtBoxNom);
            this.grpBoxAddModPersonnel.Controls.Add(this.cmbBoxService);
            this.grpBoxAddModPersonnel.Controls.Add(this.lblService);
            this.grpBoxAddModPersonnel.Controls.Add(this.lblTel);
            this.grpBoxAddModPersonnel.Controls.Add(this.lblMail);
            this.grpBoxAddModPersonnel.Controls.Add(this.lblNom);
            this.grpBoxAddModPersonnel.Controls.Add(this.lblPrenom);
            this.grpBoxAddModPersonnel.Location = new System.Drawing.Point(12, 227);
            this.grpBoxAddModPersonnel.Name = "grpBoxAddModPersonnel";
            this.grpBoxAddModPersonnel.Size = new System.Drawing.Size(781, 171);
            this.grpBoxAddModPersonnel.TabIndex = 1;
            this.grpBoxAddModPersonnel.TabStop = false;
            this.grpBoxAddModPersonnel.Text = "Ajouter et modifier un personnel";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(139, 132);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(127, 23);
            this.btnAnnuler.TabIndex = 11;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(6, 132);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(127, 23);
            this.btnEnregistrer.TabIndex = 10;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // txtBoxMail
            // 
            this.txtBoxMail.Location = new System.Drawing.Point(343, 82);
            this.txtBoxMail.Name = "txtBoxMail";
            this.txtBoxMail.Size = new System.Drawing.Size(171, 20);
            this.txtBoxMail.TabIndex = 6;
            // 
            // txtBoxTel
            // 
            this.txtBoxTel.Location = new System.Drawing.Point(343, 35);
            this.txtBoxTel.Name = "txtBoxTel";
            this.txtBoxTel.Size = new System.Drawing.Size(171, 20);
            this.txtBoxTel.TabIndex = 9;
            // 
            // txtBoxPrenom
            // 
            this.txtBoxPrenom.Location = new System.Drawing.Point(61, 82);
            this.txtBoxPrenom.Name = "txtBoxPrenom";
            this.txtBoxPrenom.Size = new System.Drawing.Size(171, 20);
            this.txtBoxPrenom.TabIndex = 7;
            // 
            // txtBoxNom
            // 
            this.txtBoxNom.Location = new System.Drawing.Point(61, 35);
            this.txtBoxNom.Name = "txtBoxNom";
            this.txtBoxNom.Size = new System.Drawing.Size(171, 20);
            this.txtBoxNom.TabIndex = 8;
            // 
            // cmbBoxService
            // 
            this.cmbBoxService.FormattingEnabled = true;
            this.cmbBoxService.Location = new System.Drawing.Point(604, 81);
            this.cmbBoxService.Name = "cmbBoxService";
            this.cmbBoxService.Size = new System.Drawing.Size(171, 21);
            this.cmbBoxService.TabIndex = 5;
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(669, 35);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(49, 13);
            this.lblService.TabIndex = 4;
            this.lblService.Text = "Service :";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(309, 38);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(28, 13);
            this.lblTel.TabIndex = 3;
            this.lblTel.Text = "Tel :";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(305, 85);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(32, 13);
            this.lblMail.TabIndex = 2;
            this.lblMail.Text = "Mail :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(20, 38);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(35, 13);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom :";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(6, 85);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(49, 13);
            this.lblPrenom.TabIndex = 0;
            this.lblPrenom.Text = "Prenom :";
            // 
            // FormGestionPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 420);
            this.Controls.Add(this.grpBoxAddModPersonnel);
            this.Controls.Add(this.grpBoxPersonnel);
            this.Name = "FormGestionPersonnel";
            this.Text = "FormGestionPersonnel";
            this.grpBoxPersonnel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).EndInit();
            this.grpBoxAddModPersonnel.ResumeLayout(false);
            this.grpBoxAddModPersonnel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxPersonnel;
        private System.Windows.Forms.DataGridView dgvPersonnel;
        private System.Windows.Forms.Button btnAddPersonnel;
        private System.Windows.Forms.Button btnSuppr;
        private System.Windows.Forms.Button btnGestAbsence;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.GroupBox grpBoxAddModPersonnel;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.TextBox txtBoxTel;
        private System.Windows.Forms.TextBox txtBoxNom;
        private System.Windows.Forms.TextBox txtBoxPrenom;
        private System.Windows.Forms.TextBox txtBoxMail;
        private System.Windows.Forms.ComboBox cmbBoxService;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
    }
}