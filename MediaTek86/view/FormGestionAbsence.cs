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
        /// Booléen pour savoir si une modification est demandée
        /// </summary>
        private Boolean enCoursDeModifAbsence = false;
        /// <summary>
        /// Identifiant du personnel courant
        /// </summary>
        private int idpersonnel;
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
            this.idpersonnel = idpersonnel;
            Init();
        }

        /// <summary>
        /// Initialisations :
        /// Création du controleur et remplissage des listes
        /// </summary>
        private void Init()
        {
            controller = new FrmGestionAbsenceController();
            grpBoxAddModAbsence.Enabled = false;
            RemplirListeAbsence();
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
        private void RemplirListeAbsence()
        {
            List<Absence> lesAbsences = controller.GetLesAbsencesByIdPersonnel(idpersonnel);
            bdgAbsences.DataSource = lesAbsences;
            dgvAbsence.DataSource = bdgAbsences;
            dgvAbsence.Columns["idpersonnel"].Visible = false;
            dgvAbsence.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        /// <summary>
        ///  Demande de modification d'un absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvAbsence.SelectedRows.Count > 0)
            {
                grpBoxAddModAbsence.Enabled = true;
                EnCoursDeModifAbsence(true);
                Absence absence = (Absence)bdgAbsences.List[bdgAbsences.Position];
                timepickDebut.Value = absence.DateDebut;
                timepickFin.Value = absence.DateFin;
                cmbBoxMotif.SelectedIndex = cmbBoxMotif.FindStringExact(absence.Motif.Libelle);
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }

        }

        /// <summary>
        /// Modification d'affichage suivant si on est en cours de modif ou d'ajout d'un absence
        /// </summary>
        /// <param name="modif"></param>
        private void EnCoursDeModifAbsence(Boolean modif)
        {
            enCoursDeModifAbsence = modif;
            grpBoxAbsence.Enabled = !modif;
            if (modif)
            {
                grpBoxAddModAbsence.Text = "modifier un absence";
            }
            else
            {
                grpBoxAddModAbsence.Text = "ajouter un absence";
            }
        }

        /// <summary>
        /// Demande d'enregistrement de l'ajout ou de la modification d'un absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (timepickDebut.Value > timepickFin.Value)
            {
                MessageBox.Show("La date de fin est antérieure à la date de début", "Information");
            }
            else if (cmbBoxMotif.SelectedIndex != -1)
            {
                Motif motif = (Motif)bdgMotifs.List[bdgMotifs.Position];
                if (enCoursDeModifAbsence)
                {
                    Absence absence = (Absence)bdgAbsences.List[bdgAbsences.Position];
                    DateTime ancienneDate = absence.DateDebut;
                    absence.DateFin = timepickFin.Value;
                    absence.DateDebut = timepickDebut.Value;
                    absence.Motif = motif;
                    try
                    {
                        controller.UpdateAbsence(absence, ancienneDate);
                        grpBoxAddModAbsence.Enabled = false;
                    }
                    catch (InvalidOperationException ex)
                    {
                        MessageBox.Show(ex.Message, "Attention");
                    }
                }
                else
                {
                    Absence absence = new Absence(idpersonnel, timepickDebut.Value, timepickFin.Value, motif);
                    try
                    {
                        controller.AddAbsence(absence);
                    }
                    catch (InvalidOperationException ex)
                    {
                        MessageBox.Show(ex.Message, "Attention");
                    }
                }
                RemplirListeAbsence();
                EnCoursDeModifAbsence(false);
            }
            else
            {
                MessageBox.Show("Tous les champs ne sont pas remplis", "Information");
            }
        }

        /// <summary>
        /// Annule la demande d'ajout ou de modification d'un absence
        /// Vide les zones de saisie du absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EnCoursDeModifAbsence(false);
                grpBoxAddModAbsence.Enabled = false;
            }
        }

        /// <summary>
        /// Demande de suppression d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSuppr_Click(object sender, EventArgs e)
        {
            if (dgvAbsence.SelectedRows.Count > 0)
            {
                Absence absence= (Absence)bdgAbsences.List[bdgAbsences.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer l'absence du " + absence.DateDebut.Date.ToShortDateString() + " au " + absence.DateFin.Date.ToShortDateString() + " avec comme motif : " + absence.Motif.Libelle + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.DelAbsence(absence);
                    RemplirListeAbsence();
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        private void btnAddAbsence_Click(object sender, EventArgs e)
        {
            grpBoxAddModAbsence.Enabled = true;
            EnCoursDeModifAbsence(false);
        }

        private void btnGestPersonnel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
