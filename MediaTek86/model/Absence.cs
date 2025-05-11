using System;

namespace MediaTek86.model
{
    /// <summary>
    /// Classe métier interne pour mémoriser les informations d'absence
    /// </summary>
    public class Absence
    {
        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="idPersonnel"></param>
        /// <param name="dateDebut"></param>
        /// <param name="dateFin"></param>
        /// <param name="motif"></param>
        public Absence(int idPersonnel, DateTime dateDebut, DateTime dateFin, Motif motif)
        {
            this.IdPersonnel = idPersonnel;
            this.DateDebut = dateDebut;
            this.DateFin = dateFin;
            this.Motif = motif;
        }

        /// <summary>
        /// Obtient l'identifiant du personnel absent 
        /// </summary>
        public int IdPersonnel { get; }
        /// <summary>
        /// Obtient ou définit la date de début de l'absence
        /// </summary>
        public DateTime DateDebut { get; set; }
        /// <summary>
        /// Obtient ou définit la date de fin de l'absence
        /// </summary>
        public DateTime DateFin { get; set; }
        /// <summary>
        /// Obtient ou définit le motif de l'absence
        /// </summary>
        public Motif Motif { get; set; }
    }
}
