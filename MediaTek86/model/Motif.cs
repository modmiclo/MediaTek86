namespace MediaTek86.model
{
    class Motif
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

        public int IdMotif { get; }
        public string Libelle { get; set; }
    }
}
