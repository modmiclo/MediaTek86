using MediaTek86.model;
using Org.BouncyCastle.Crypto.Parameters;
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

        /// <summary>
        /// Demande d'ajout d'une absence
        /// </summary>
        /// <param name="absence">objet absence à ajouter</param>
        public void AddAbsence(Absence absence)
        {
            if (connexion.Manager != null)
            {
                Dictionary<string, object> parameters = CountAbsenceBetweenDate(absence);

                string reqInsert = "insert into absence(idpersonnel, datedebut, datefin, idmotif) ";
                reqInsert += "values (@idpersonnel, @datedebut, @datefin, @idmotif);";
                parameters.Add("@idmotif", absence.Motif.IdMotif);

                try
                {
                    connexion.Manager.ReqUpdate(reqInsert, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    throw;
                }
            }
        }


        /// <summary>
        /// Demande de modification d'une absence
        /// </summary>
        /// <param name="absence">objet absence à modifier</param>
        /// <param name="ancienneDate">l'ancienne date de l'absence</param>
        public void UpdateAbsence(Absence absence, DateTime ancienneDate)
        {
            if (connexion.Manager != null)
            {
                Dictionary<string, object> parameters = CountAbsenceBetweenDate(absence, ancienneDate);

                string req = "update absence set datedebut = @datedebut, datefin = @datefin, idmotif = @idmotif ";
                req += "where idpersonnel = @idpersonnel and datedebut = @ancienneDate;";
                parameters.Add("@idmotif", absence.Motif.IdMotif);
                try
                {
                    connexion.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    throw;
                }
            }
        }

        private Dictionary<string, object> CountAbsenceBetweenDate(Absence absence, DateTime? ancienneDateDebut = null)
        {
            string reqCheck = "select count(*) from absence ";
            reqCheck += "where idpersonnel = @idpersonnel ";
            reqCheck += "and not (DATE(@datefin) < DATE(datedebut) or DATE(@datedebut) > DATE(datefin)) ";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", absence.IdPersonnel);
            parameters.Add("@datedebut", absence.DateDebut.Date);
            parameters.Add("@datefin", absence.DateFin.Date);

            if (ancienneDateDebut != null)
            {
                reqCheck += "and not (idpersonnel = @idpersonnel and datedebut = @ancienneDate);";
                parameters.Add("@ancienneDate", ancienneDateDebut);
            }

            try
            {
                List<Object[]> result = connexion.Manager.ReqSelect(reqCheck, parameters);

                if (result.Count > 0)
                {
                    int count = Convert.ToInt32(result[0][0]);
                    if (count > 0)
                    {
                        throw new InvalidOperationException("Une absence est déjà programmée dans ce créneau !");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

            return parameters;
        }
    }
}
