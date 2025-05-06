
namespace MediaTek86.view
{
    partial class FormErreur
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
            this.lblErreur = new System.Windows.Forms.Label();
            this.btnErreurOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblErreur
            // 
            this.lblErreur.AutoSize = true;
            this.lblErreur.Location = new System.Drawing.Point(144, 34);
            this.lblErreur.Name = "lblErreur";
            this.lblErreur.Size = new System.Drawing.Size(35, 13);
            this.lblErreur.TabIndex = 0;
            this.lblErreur.Text = "Erreur";
            // 
            // btnErreurOk
            // 
            this.btnErreurOk.Location = new System.Drawing.Point(125, 62);
            this.btnErreurOk.Name = "btnErreurOk";
            this.btnErreurOk.Size = new System.Drawing.Size(75, 23);
            this.btnErreurOk.TabIndex = 1;
            this.btnErreurOk.Text = "Ok";
            this.btnErreurOk.UseVisualStyleBackColor = true;
            // 
            // FormErreur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 112);
            this.Controls.Add(this.btnErreurOk);
            this.Controls.Add(this.lblErreur);
            this.Name = "FormErreur";
            this.Text = "FormErreur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblErreur;
        private System.Windows.Forms.Button btnErreurOk;
    }
}