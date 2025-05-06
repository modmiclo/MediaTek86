
namespace MediaTek86.view
{
    partial class FormConfirmation
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
            this.lblConf = new System.Windows.Forms.Label();
            this.btnConfAnnuler = new System.Windows.Forms.Button();
            this.btnConfContinuer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblConf
            // 
            this.lblConf.AutoSize = true;
            this.lblConf.Location = new System.Drawing.Point(33, 33);
            this.lblConf.Name = "lblConf";
            this.lblConf.Size = new System.Drawing.Size(176, 13);
            this.lblConf.TabIndex = 0;
            this.lblConf.Text = "Êtes-vous sur de vouloir continuer ?";
            // 
            // btnConfAnnuler
            // 
            this.btnConfAnnuler.Location = new System.Drawing.Point(36, 69);
            this.btnConfAnnuler.Name = "btnConfAnnuler";
            this.btnConfAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnConfAnnuler.TabIndex = 1;
            this.btnConfAnnuler.Text = "Annuler";
            this.btnConfAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnConfContinuer
            // 
            this.btnConfContinuer.Location = new System.Drawing.Point(134, 69);
            this.btnConfContinuer.Name = "btnConfContinuer";
            this.btnConfContinuer.Size = new System.Drawing.Size(75, 23);
            this.btnConfContinuer.TabIndex = 2;
            this.btnConfContinuer.Text = "Continuer";
            this.btnConfContinuer.UseVisualStyleBackColor = true;
            // 
            // FormConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 125);
            this.Controls.Add(this.btnConfContinuer);
            this.Controls.Add(this.btnConfAnnuler);
            this.Controls.Add(this.lblConf);
            this.Name = "FormConfirmation";
            this.Text = "FormConfirmation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConf;
        private System.Windows.Forms.Button btnConfAnnuler;
        private System.Windows.Forms.Button btnConfContinuer;
    }
}