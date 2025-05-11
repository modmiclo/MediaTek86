using MediaTek86.model;
using MediaTek86.dal;
using MediaTek86.dal;
using MediaTek86.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.controller
{
    public class FrmGestionAbsenceController
    {
        /// <summary>
        /// objet d'accès aux opérations possibles sur les absences
        /// </summary>
        private readonly AbsenceAccess absenceAccess;

        /// <summary>
        /// objet d'accès aux opérations possibles sur les motifs
        /// </summary>
        private readonly MotifAccess motifAccess;

        /// <summary>
        /// Récupère les acces aux données
        /// </summary>
        public FrmGestionAbsenceController()
        {
            absenceAccess = new AbsenceAccess();
            motifAccess = new MotifAccess();
        }

        /// <summary>
        /// Récupère et retourne les infos des motifs
        /// </summary>
        /// <returns>liste des motifs </returns>
        public List<Motif> GetLesMotifs()
        {
            return motifAccess.GetLesMotifs();
        }

        /// <summary>
        /// Récupère et retourne les infos des absences
        /// </summary>
        /// <returns>liste des absences </returns>
        public List<Absence> GetLesAbsencesByIdPersonnel(int idpersonnel)
        {
            return absenceAccess.GetLesAbsencesByIdPersonnel(idpersonnel);
        }
        /// <summary>
        /// Demande d'ajout d'une absence
        /// </summary>
        /// <param name="absence">objet absence à ajouter</param>
        public void AddAbsence(Absence absence)
        {
            absenceAccess.AddAbsence(absence);
        }

        /// <summary>
        /// Demande de modification d'une absence
        /// </summary>
        /// <param name="absence">objet absence à modifier</param>
        /// <param name="ancienneDate">l'ancienne date de l'absence</param>
        public void UpdateAbsence(Absence absence, DateTime ancienneDate)
        {
            absenceAccess.UpdateAbsence(absence, ancienneDate);
        }

        /// <summary>
        /// Demande de suppression d'une absence
        /// </summary>
        /// <param name="absence">objet absence à supprimer</param>
        public void DelAbsence(Absence absence)
        {
            absenceAccess.DelAbsence(absence);
        }
    }
}
