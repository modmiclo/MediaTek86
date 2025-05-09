using MediaTek86.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.dal
{
    /// <summary>
    /// Classe permettant de gérer les demandes concernant les developpeurs
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
        }
}
