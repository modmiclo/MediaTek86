using MediaTek86.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.dal
{
    /// <summary>
    /// Classe permettant de gérer les demandes concernant les services
    /// </summary>
    public class ServiceAccess
    {
        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly Connexion connexion = null;

        /// <summary>
        /// Constructeur pour créer l'accès aux données
        /// </summary>
        public ServiceAccess()
        {
            connexion = Connexion.GetInstance();
        }

        /// <summary>
        /// Récupère et retourne les services
        /// </summary>
        /// <returns>liste des services</returns>
        public List<Service> GetLesServices()
        {
            List<Service> lesServices = new List<Service>();
            if (connexion.Manager != null)
            {
                string req = "select * from service order by nom;";
                try
                {
                    List<Object[]> records = connexion.Manager.ReqSelect(req);
                    if (records != null)
                    {
                        foreach (Object[] record in records)
                        {
                            Service service = new Service((int)record[0], (string)record[1]);
                            lesServices.Add(service);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
            return lesServices;
        }
    }
}
