namespace MediaTek86.model
{
    /// <summary>
    /// Classe métier interne pour mémoriser les informations du personnel
    /// </summary>
    public class Personnel
    {
        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="idPersonnel"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        /// <param name="service"></param>
        public Personnel(int idPersonnel, string nom, string prenom, string tel, string mail, Service service)
        {
            this.IdPersonnel = idPersonnel;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Tel = tel;
            this.Mail = mail;
            this.Service = service;
        }

        /// <summary>
        /// Obtient l'identifiant du personnel
        /// </summary>
        public int IdPersonnel { get; }
        /// <summary>
        /// Obtient ou définit le nom du personnel
        /// </summary>
        public string Nom { get; set; }
        /// <summary>
        /// Obtient ou définit le prénom du personnel
        /// </summary>
        public string Prenom { get; set; }
        /// <summary>
        /// Obtient ou définit le téléphone du personnel
        /// </summary>
        public string Tel { get; set; }
        /// <summary>
        /// Obtient ou définit le mail du personnel
        /// </summary>
        public string Mail { get; set; }
        /// <summary>
        /// Obtient ou définit le service du personnel
        /// </summary>
        public Service Service { get; set; }
    }
}
