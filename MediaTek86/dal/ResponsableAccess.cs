using MediaTek86.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaTek86.dal
{
    /// <summary>
    /// Classe permettant de gérer les demandes concernant les responsables
    /// </summary>
    public class ResponsableAccess
        {
            /// <summary>
            /// Instance unique de l'accès aux données
            /// </summary>
            private readonly Connexion connexion = null;

            /// <summary>
            /// Constructeur pour créer l'accès aux données
            /// </summary>
            public ResponsableAccess()
            {
                connexion = Connexion.GetInstance();
            }

            /// <summary>
            /// Controle si l'utillisateur a le droit de se connecter (login, pwd)
            /// </summary>
            /// <param name="login"></param>
            /// <param name="pwd"></param>
            /// <returns>vrai si l'utilisateur a le profil "admin"</returns>
            public Boolean ControleAuthentification(Responsable responsable)
            {
                if (connexion.Manager != null)
                {
                string req = "SELECT * FROM responsable ";
                req += "WHERE login = @login AND pwd = SHA2(@pwd, 256);";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                    parameters.Add("@login", responsable.Login);
                    parameters.Add("@pwd", responsable.Pwd);
                    try
                    {
                        List<Object[]> records = connexion.Manager.ReqSelect(req, parameters);
                        if (records != null)
                        {
                            return (records.Count > 0);
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Environment.Exit(0);
                    }
                }
                return false;
            }

        /// <summary>
        /// Récupère et retourne le personnel
        /// </summary>
        /// <returns>liste du personnel</returns>
        public List<Personnel> GetLePersonnel()
        {
            List<Personnel> lePersonnel= new List<Personnel>();
            if (connexion.Manager != null)
            {
                string req = "select p.idpersonnel, p.nom, p.prenom, p.tel, p.mail, s.idservice, s.nom ";
                req += "from personnel p join service s on p.idservice = s.idservice ";
                req += "order by p.nom, p.prenom;";
                try
                {
                    List<Object[]> records = connexion.Manager.ReqSelect(req);
                    Console.WriteLine(records.Count > 0);
                    if (records != null)
                    {
                        foreach (Object[] record in records)
                        {
                            Service service = new Service((int)record[5], (string)record[6]);
                            Personnel personnel = new Personnel(
                                (int)record[0], (string)record[1], (string)record[2],
                                (string)record[3], (string)record[4], service
                            );
                            lePersonnel.Add(personnel);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
            return lePersonnel;
        }
    }
}
