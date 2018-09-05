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

namespace PPP_Project.Business
{
    public class CategoryExpertHunt : BusinessLogic<CategoryExpertHuntEntity, CategoryExpertHuntDAO>
    {
        public PPP_Project.Criteria.ImportJobsCriteria Criteria { get; set; }

        public override CategoryExpertHuntEntity Entity
        {
            get;
            set;
        }

        public override List<CategoryExpertHuntEntity> EntityList
        {
            get;
            set;
        }

        public override CategoryExpertHuntDAO DAO
        {
            get;
            set;
        }

        public override void Init_Object()
        {
            Entity = new CategoryExpertHuntEntity();
            DAO = new CategoryExpertHuntDAO();
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

        public List<CategoryExpertHuntEntity> Finds()
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

        public override CategoryExpertHuntEntity FindByID(int id)
        {
            throw new NotImplementedException();
        }

        public override CategoryExpertHuntEntity FindByID(string id)
        {
            throw new NotImplementedException();
        }

        public override List<CategoryExpertHuntEntity> FindByCriteria()
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


        public override CategoryExpertHuntEntity FindByBarCode(string barCode)
        {
            throw new NotImplementedException();
        }

        public override List<CategoryExpertHuntEntity> FindModelCode(string modelCode)
        {
            throw new NotImplementedException();
        }

        public List<CategoryExpertHuntEntity> FindByImportedDateAndCenter(string importDate, string center)
        {
            try
            {
                return DAO.FindByImportedDateAndCenter(importDate, center);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ExportViewWithoutDe> FindByCriteriaWithoutDeForCategoryExpertHunt()
        {
            try
            {
                Map_Object();
                return DAO.FindByCriteriaWithoutDeForCategoryExpertHunt();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<ExportCategoryExpertHunt> FindByCriteriaDenominatorForCategoryExpertHunt()
        {
            try
            {
                Map_Object();
                return DAO.FindByCriteriaDenominatorForCategoryExpertHunt();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public List<ExportCategoryExpertHunt> FindByCriteriaDenominatorForCategoryExpertHuntSingle()
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


        public List<ExportCategoryExpertHunt> FindByCriteriaDenominatorForCategoryExpertHuntSingleIGS()
        {
            try
            {
                Map_Object();
                return DAO.FindByCriteriaDenominatorForCategoryExpertHuntSingleIGS();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<ExportCategoryExpertHunt> FindByCriteriaDenominatorForCategoryExpertHuntSpecial()
        {
            try
            {
                Map_Object();
                return DAO.FindByCriteriaDenominatorForCategoryExpertHuntSpecial();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ReplaceQATCategoryExpertHunt(string center)
        {
            try
            {
                DAO.ReplaceQATCategoryExpertHunt(center);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}