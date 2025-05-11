namespace MediaTek86.model
{
    /// <summary>
    /// Classe métier interne pour mémoriser les informations sur les services
    /// </summary>
    public class Service
    {
        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="idService"></param>
        /// <param name="nom"></param>
        public Service(int idService, string nom)
        {
            this.IdService = idService;
            this.Nom = nom;
        }

        /// <summary>
        /// Obtient l'identifiant du service
        /// </summary>
        public int IdService { get; }
        /// <summary>
        /// Obtient ou définit le nom du service
        /// </summary>
        public string Nom { get; set; }
        /// <summary>
        /// Définit l'information à afficher (juste le nom)
        /// </summary>
        /// <returns>nom du service</returns>
        public override string ToString()
        {
            return this.Nom;
        }
    }
}
