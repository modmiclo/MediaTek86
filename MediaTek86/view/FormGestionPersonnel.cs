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
    public partial class FormGestionPersonnel : Form
    {
        /// <summary>
        /// Controleur de la fenêtre
        /// </summary>
        private FrmGestionController controller;
        /// <summary>
        /// Objet pour gérer la liste du personnel
        /// </summary>
        private BindingSource bdgPersonnel = new BindingSource();
        /// <summary>
        /// Objet pour gérer la liste des services
        /// </summary>
        private BindingSource bdgServices = new BindingSource();
        /// <summary>
        /// Booléen pour savoir si une modification est demandée
        /// </summary>
        private Boolean enCoursDeModifPersonnel = false;
        /// <summary>
        /// construction des composants graphiques et appel des autres initialisations
        /// </summary>
        public FormGestionPersonnel()
        {
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// Initialisations :
        /// Création du controleur et remplissage des listes
        /// </summary>
        private void Init()
        {
            controller = new FrmGestionController();
            RemplirListePersonnel();
            RemplirListeService();
        }


        /// <summary>
        /// Affiche le personnel
        /// </summary>
        private void RemplirListePersonnel()
        {
            List<Personnel> lePersonnel = controller.GetLePersonnel();
            bdgPersonnel.DataSource = lePersonnel;
            dgvPersonnel.DataSource = bdgPersonnel;
            dgvPersonnel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }


        /// <summary>
        /// Affiche les services
        /// </summary>
        private void RemplirListeService()
        {
            List<Service> lesServices = controller.GetLesServices();
            bdgServices.DataSource = lesServices;
            cmbBoxService.DataSource = bdgServices;
        }

        /// <summary>
        ///  Demande de modification d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count > 0)
            {
                EnCoursDeModifPersonnel(true);
                Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                txtBoxNom.Text = personnel.Nom;
                txtBoxPrenom.Text = personnel.Prenom;
                txtBoxTel.Text = personnel.Tel;
                txtBoxMail.Text = personnel.Mail;
                cmbBoxService.SelectedIndex = cmbBoxService.FindStringExact(personnel.Service.Nom);
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }

        }

        /// <summary>
        /// Modification d'affichage suivant si on est en cours de modif ou d'ajout d'un personnel
        /// </summary>
        /// <param name="modif"></param>
        private void EnCoursDeModifPersonnel(Boolean modif)
        {
            enCoursDeModifPersonnel = modif;
            grpBoxPersonnel.Enabled = !modif;
            if (modif)
            {
                grpBoxAddModPersonnel.Text = "modifier un personnel";
            }
            else
            {
                grpBoxAddModPersonnel.Text = "ajouter un personnel";
                txtBoxNom.Text = "";
                txtBoxPrenom.Text = "";
                txtBoxTel.Text = "";
                txtBoxMail.Text = "";
            }
        }

        /// <summary>
        /// Demande d'enregistrement de l'ajout ou de la modification d'un personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (!txtBoxNom.Text.Equals("") && !txtBoxPrenom.Text.Equals("") && !txtBoxTel.Text.Equals("") && !txtBoxMail.Text.Equals("") && cmbBoxService.SelectedIndex != -1)
            {
                Service profil = (Service)bdgServices.List[bdgServices.Position];
                if (enCoursDeModifPersonnel)
                {
                    Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                    personnel.Nom = txtBoxNom.Text;
                    personnel.Prenom = txtBoxPrenom.Text;
                    personnel.Tel = txtBoxTel.Text;
                    personnel.Mail = txtBoxMail.Text;
                    personnel.Service = profil;
                    controller.UpdatePersonnel(personnel);
                }
                else
                {
                    Personnel personnel = new Personnel(0, txtBoxNom.Text, txtBoxPrenom.Text, txtBoxTel.Text, txtBoxMail.Text, profil);
                    controller.AddPersonnel(personnel);
                }
                RemplirListePersonnel();
                EnCoursDeModifPersonnel(false);
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }

        }
    }
}
