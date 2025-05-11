using MediaTek86.dal;
using MediaTek86.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.controller
{
    /// <summary>
    /// Contrôleur de FormConnexion
    /// </summary>
    public class FrmConnexionController
    {
        /// <summary>
        /// objet d'accès aux opérations possibles sur les responsables
        /// </summary>
        private readonly ResponsableAccess responsableAccess;

        /// <summary>
        /// Récupère l'acces aux données
        /// </summary>
        public FrmConnexionController()
        {
            responsableAccess = new ResponsableAccess();
        }

        /// <summary>
        /// Vérifie l'authentification
        /// </summary>
        /// <param name="responsable">objet contenant les informations de connexion</param>
        /// <returns> vrai si les informations de connexion sont correctes</returns>
        public Boolean ControleAuthentification(Responsable responsable)
        {
            return responsableAccess.ControleAuthentification(responsable);
        }

    }
}

