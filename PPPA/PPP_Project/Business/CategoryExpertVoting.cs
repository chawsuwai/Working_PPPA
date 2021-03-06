﻿using System;
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
    public class CategoryExpertVoting:BusinessLogic<CategoryExpertVotingEntity,CategoryExpertVotingDAO>
    {
        public PPP_Project.Criteria.ImportJobsCriteria Criteria { get; set; }

        public override CategoryExpertVotingEntity Entity
        {
            get;
            set;
        }

        public override List<CategoryExpertVotingEntity> EntityList
        {
            get;
            set;
        }

        public override CategoryExpertVotingDAO DAO
        {
            get;
            set;
        }

        public override void Init_Object()
        {
            Entity = new CategoryExpertVotingEntity();
            DAO = new CategoryExpertVotingDAO();
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

        public List<CategoryExpertVotingEntity> Finds()
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

        public override CategoryExpertVotingEntity FindByID(int id)
        {
            throw new NotImplementedException();
        }

        public override CategoryExpertVotingEntity FindByID(string id)
        {
            throw new NotImplementedException();
        }

        public override List<CategoryExpertVotingEntity> FindByCriteria()
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
        

        public override CategoryExpertVotingEntity FindByBarCode(string barCode)
        {
            throw new NotImplementedException();
        }

        public override List<CategoryExpertVotingEntity> FindModelCode(string modelCode)
        {
            throw new NotImplementedException();
        }

        public List<CategoryExpertVotingEntity> FindByImportedDateAndCenter(string importDate, string center)
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

        public List<ExportViewWithoutDe> FindByCriteriaWithoutDeForCategoryExpertVoting()
        {
            try
            {
                Map_Object();
                return DAO.FindByCriteriaWithoutDeForCategoryExpertVoting();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<ExportCategoryExpertVoting> FindByCriteriaDenominatorForCategoryExpertVoting()
        {
            try
            {
                Map_Object();
                return DAO.FindByCriteriaDenominatorForCategoryExpertVoting();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public List<ExportCategoryExpertVoting> FindByCriteriaDenominatorForCategoryExpertVotingSingle()
        {
            try
            {
                Map_Object();
                return DAO.FindByCriteriaDenominatorForCategoryExpertVotingSingle();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public List<ExportCategoryExpertVoting> FindByCriteriaDenominatorForCategoryExpertHuntSingle()
        {
            try
            {
                Map_Object();
                return DAO.FindByCriteriaDenominatorForCategoryExpertHuntSingle();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public List<ExportCategoryExpertVoting> FindByCriteriaDenominatorForCategoryExpertVotingSingleIGS()
        {
            try
            {
                Map_Object();
                return DAO.FindByCriteriaDenominatorForCategoryExpertVotingSingleIGS();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<ExportCategoryExpertVoting> FindByCriteriaDenominatorForCategoryExpertVotingSpecial()
        {
            try
            {
                Map_Object();
                return DAO.FindByCriteriaDenominatorForCategoryExpertVotingSpecial();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ReplaceQATCategoryExpertVoting(string center)
        {
            try
            {
                DAO.ReplaceQATCategoryExpertVoting(center);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}