using MediaTek86.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.dal
{
    /// <summary>
    /// Classe permettant de gérer les demandes concernant les absences
    /// </summary>
    public class AbsenceAccess
    {
        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly Connexion connexion = null;

        /// <summary>
        /// Constructeur pour créer l'accès aux données
        /// </summary>
        public AbsenceAccess()
        {
            connexion = Connexion.GetInstance();
        }

        /// <summary>
        /// Récupère et retourne les absences
        /// </summary>
        /// <returns>liste des absences</returns>
        public List<Absence> GetLesAbsencesByIdPersonnel(int idPersonnel)
        {
            List<Absence> lesAbsences = new List<Absence>();
            if (connexion.Manager != null)
            {
                string req = "select a.idpersonnel, a.datedebut, a.datefin, a.idmotif, m.libelle ";
                req += "from absence a ";
                req += "join motif m on m.idmotif = a.idmotif ";
                req += "join personnel p on p.idpersonnel = a.idpersonnel ";
                req += "where a.idpersonnel = " + idPersonnel;
                req += " order by a.datedebut DESC;";
                try
                {
                    List<Object[]> records = connexion.Manager.ReqSelect(req);
                    Console.WriteLine(records.Count > 0);
                    if (records != null)
                    {
                        foreach (Object[] record in records)
                        {
                            Motif motif = new Motif((int)record[3], (string)record[4]);
                            Absence absence = new Absence(
                                (int)record[0], (DateTime)record[1], (DateTime)record[2], motif
                            );
                            lesAbsences.Add(absence);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
            return lesAbsences;
        }
    }
}
