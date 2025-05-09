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

        public int IdPersonnel { get; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public Motif Motif { get; set; }
    }
}
