using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PPP_Project.Base;
using PPP_Project.Entity;
using PPP_Project.DAO;
using PPP_Project.Common;
using PPP_Project.CommonAttributes;
using PPP_Project.Common.Extension;
using PPP_Project.Common.Enum;
using PPP_Project.Criteria;

namespace PPP_Project.Criteria
{
    public class Votes:BusinessLogic<VotesEntity,VotesDAO>
    {
        public PPP_Project.Criteria.ImportJobsCriteria Criteria { get; set; }

        public override VotesEntity Entity
        {
            get;
            set;
        }

        public override List<VotesEntity> EntityList
        {
            get;
            set;
        }

        public override VotesDAO DAO
        {
            get;
            set;
        }

        public override void Init_Object()
        {
            Entity = new VotesEntity();
            DAO = new VotesDAO();            
        }

        public override void Map_Object()
        {
            try
            {
                DAO.Entity = this.Entity;
                DAO.EntityList = this.EntityList;
                DAO.Criteria = this.Criteria;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void Save()
        {
            try
            {
                Map_Object();
                DAO.Save();
            }
            catch (Exception ex)
            {
                throw ex;
            } 
        }

        public override void Saves()
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            try
            {
                Map_Object();
                DAO.Update();
            }
            catch (Exception ex)
            {                
                throw ex;
            }
        }

        public override void Delete()
        {
            try
            {
                Map_Object();
                DAO.Delete();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<VotesEntity> Finds()
        {
            try
            {
                return DAO.Finds();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public override VotesEntity FindByID(int id)
        {
            throw new NotImplementedException();
        }

        public override VotesEntity FindByID(string id)
        {
            throw new NotImplementedException();
        }

        public override List<VotesEntity> FindByCriteria()
        {
            try
            {
                Map_Object();
                return DAO.FindByCriteria();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // FindVotesJobImportList
        public List<VotesEntity> FindVotesJobImportList()
        {
            try
            {
                Map_Object();
                return DAO.FindVotesJobImportList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override VotesEntity FindByBarCode(string barCode)
        {
            throw new NotImplementedException();
        }

        public override List<VotesEntity> FindModelCode(string modelCode)
        {
            throw new NotImplementedException();
        }

        public List<VotesEntity> FindByImportedDateAndCenter(string importDate, string center)
        {
            try
            {
                return DAO.FindByImportedDateAndCenter(importDate,center);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ExportViewWithoutDe> FindByCriteriaWithoutDeForVotes()
        {
            try
            {
                Map_Object();
                return DAO.FindByCriteriaWithoutDeForVotes();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<ExportVotes> FindByCriteriaDenominatorForMasks()
        {
            try
            {
                Map_Object();
                return DAO.FindByCriteriaDenominatorForVotes();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<ExportVotes> FindByCriteriaDenominatorForVotes()
        {
            try
            {
                Map_Object();
                return DAO.FindByCriteriaDenominatorForVotes();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public List<ExportVotes> FindByCriteriaDenominatorForVotesSingle()
        {
            try
            {
                Map_Object();
                return DAO.FindByCriteriaDenominatorForVotesSingle();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public List<ExportVotes> FindByCriteriaDenominatorForVotesSingleIGS()
        {
            try
            {
                Map_Object();
                return DAO.FindByCriteriaDenominatorForVotesSingleIGS();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public List<ExportVotes> FindByCriteriaDenominatorForVotesSpecial()
        {
            try
            {
                Map_Object();
                return DAO.FindByCriteriaDenominatorForVotesSpecial();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ReplaceQATVotes(string center)
        {
            try
            {
                DAO.ReplaceQATVotes(center);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}