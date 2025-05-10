using MediaTek86.model;
using MediaTek86.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.controller
{
    /// <summary>
    /// Contrôleur de FrmGestionAbsence et FrmGestionPersonnel
    /// </summary>
    public class FrmGestionPersonnelController
    {
        /// <summary>
        /// objet d'accès aux opérations possibles sur le personnel
        /// </summary>
        private readonly PersonnelAccess personnelAccess;

        /// <summary>
        /// objet d'accès aux opérations possibles sur les services
        /// </summary>
        private readonly ServiceAccess servicesAccess;


        /// <summary>
        /// Récupère les acces aux données
        /// </summary>
        public FrmGestionPersonnelController()
        {
            personnelAccess = new PersonnelAccess();
            servicesAccess = new ServiceAccess();
        }

        /// <summary>
        /// Récupère et retourne les infos du personnel
        /// </summary>
        /// <returns>liste des développeurs</returns>
        public List<Personnel> GetLePersonnel()
        {
            return personnelAccess.GetLePersonnel();
        }

        public List<Service> GetLesServices()
        {
            return servicesAccess.GetLesServices();
        }

        /// <summary>
        /// Demande d'ajout d'un personnel
        /// </summary>
        /// <param name="personnel">objet developpeur à ajouter</param>
        public void AddPersonnel(Personnel personnel)
        {
            personnelAccess.AddPersonnel(personnel);
        }

        /// <summary>
        /// Demande de modification d'un personnel
        /// </summary>
        /// <param name="personnel">objet developpeur à modifier</param>
        public void UpdatePersonnel(Personnel personnel)
        {
            personnelAccess.UpdatePersonnel(personnel);
        }

        /// <summary>
        /// Demande de suppression d'un personnel
        /// </summary>
        /// <param name="personnel">objet personnel à supprimer</param>
        public void DelPersonnel(Personnel personnel)
        {
            personnelAccess.DelPersonnel(personnel);
        }

    }
}
