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
    public class FrmGestionController
    {
        /// <summary>
        /// objet d'accès aux opérations possibles sur le personnel
        /// </summary>
        private readonly ResponsableAccess responsableAccess;


        /// <summary>
        /// Récupère les acces aux données
        /// </summary>
        public FrmGestionController()
        {
            responsableAccess = new ResponsableAccess();
        }

        /// <summary>
        /// Récupère et retourne les infos du personnel
        /// </summary>
        /// <returns>liste des développeurs</returns>
        public List<Personnel> GetLePersonnel()
        {
            return responsableAccess.GetLePersonnel();
        }

        public List<Service> GetLesServices()
        {
            return responsableAccess.GetLesServices();
        }

        /// <summary>
        /// Demande d'ajout d'un personnel
        /// </summary>
        /// <param name="personnel">objet developpeur à ajouter</param>
        public void AddPersonnel(Personnel personnel)
        {
            responsableAccess.AddPersonnel(personnel);
        }

        /// <summary>
        /// Demande de modification d'un personnel
        /// </summary>
        /// <param name="personnel">objet developpeur à modifier</param>
        public void UpdatePersonnel(Personnel personnel)
        {
            responsableAccess.UpdatePersonnel(personnel);
        }
    }
}
