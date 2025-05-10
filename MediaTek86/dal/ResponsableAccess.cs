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

        /// <summary>
        /// Demande d'ajout un développeur
        /// </summary>
        /// <param name="personnel">objet personnel à ajouter</param>
        public void AddPersonnel(Personnel personnel)
        {
            if (connexion.Manager != null)
            {
                string req = "insert into personnel(nom, prenom, tel, mail, idservice) ";
                req += "values (@nom, @prenom, @tel, @mail, @idservice);";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@nom", personnel.Nom);
                parameters.Add("@prenom", personnel.Prenom);
                parameters.Add("@tel", personnel.Tel);
                parameters.Add("@mail", personnel.Mail);
                parameters.Add("@idservice", personnel.Service.IdService);
                try
                {
                    connexion.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
        }

        /// <summary>
        /// Demande de modification d'un développeur
        /// </summary>
        /// <param name="personnel">objet personnel à modifier</param>
        public void UpdatePersonnel(Personnel personnel)
        {
            if (connexion.Manager != null)
            {
                string req = "update personnel set nom = @nom, prenom = @prenom, tel = @tel, mail = @mail, idservice = @idservice ";
                req += "where idpersonnel = @idpersonnel;";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idPersonnel", personnel.IdPersonnel);
                parameters.Add("@nom", personnel.Nom);
                parameters.Add("@prenom", personnel.Prenom);
                parameters.Add("@tel", personnel.Tel);
                parameters.Add("@mail", personnel.Mail);
                parameters.Add("@idservice", personnel.Service.IdService);
                try
                {
                    connexion.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
        }

        /// <summary>
        /// Demande de suppression d'un personnel
        /// </summary>
        /// <param name="personnel">objet personnel à supprimer</param>
        public void DelPersonnel(Personnel personnel)
        {
            if (connexion.Manager != null)
            {
                string req = "delete from personnel where idpersonnel = @idpersonnel;";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@idpersonnel", personnel.IdPersonnel);
                try
                {
                    connexion.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
        }
    }
}
