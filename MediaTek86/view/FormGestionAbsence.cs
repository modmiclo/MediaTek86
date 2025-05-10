using MediaTek86.controller;
using MediaTek86.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaTek86.view
{
    public partial class FormGestionAbsence : Form
    {

        /// <summary>
        /// Objet pour gérer la liste des motifs
        /// </summary>
        private BindingSource bdgMotifs = new BindingSource();

        /// <summary>
        /// Objet pour gérer la liste des absences
        /// </summary>
        private BindingSource bdgAbsences = new BindingSource();
        /// <summary>
        /// Controleur de la fenêtre
        /// </summary>
        private FrmGestionAbsenceController controller;

        /// <summary>
        /// construction des composants graphiques et appel des autres initialisations
        /// </summary>
        public FormGestionAbsence(int idpersonnel)
        {
            InitializeComponent();
            Init(idpersonnel);
        }

        /// <summary>
        /// Initialisations :
        /// Création du controleur et remplissage des listes
        /// </summary>
        private void Init(int idpersonnel)
        {
            controller = new FrmGestionAbsenceController();
            RemplirListeAbsence(idpersonnel);
            RemplirListeMotif();
        }

        /// <summary>
        /// Affiche les motifs
        /// </summary>
        private void RemplirListeMotif()
        {
            List<Motif> lesMotifs = controller.GetLesMotifs();
            bdgMotifs.DataSource = lesMotifs;
            cmbBoxMotif.DataSource = bdgMotifs;
        }

        /// <summary>
        /// Affiche les absences
        /// </summary>
        private void RemplirListeAbsence(int idpersonnel)
        {
            List<Absence> lesAbsences = controller.GetLesAbsencesByIdPersonnel(idpersonnel);
            bdgAbsences.DataSource = lesAbsences;
            dgvAbsence.DataSource = bdgAbsences;
            dgvAbsence.Columns["idpersonnel"].Visible = false;
            dgvAbsence.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}
