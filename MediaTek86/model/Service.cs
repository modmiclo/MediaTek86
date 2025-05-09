namespace MediaTek86.model
{
    /// <summary>
    /// Classe métier interne pour mémoriser les informations sur les services présentés dans le contexte
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

        public int IdService { get; }
        public string Nom { get; set; }
    }
}
