namespace MediaTek86.model
{
    /// <summary>
    /// Classe métier interne pour mémoriser les informations des motifs d'absence
    /// </summary>
    public class Motif
    {
        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="idMotif"></param>
        /// <param name="libelle"></param>
        public Motif(int idMotif, string libelle)
        {
            this.IdMotif = idMotif;
            this.Libelle = libelle;
        }

        /// <summary>
        /// Obtient l'identifiant du motif
        /// </summary>
        public int IdMotif { get; }
        /// <summary>
        /// Obtient ou définit le libellé du motif 
        /// </summary>
        public string Libelle { get; set; }

        /// <summary>
        /// Définit l'information à afficher (juste le nom)
        /// </summary>
        /// <returns>nom du motif</returns>
        public override string ToString()
        {
            return this.Libelle;
        }
    }
}
