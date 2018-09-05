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
    public class Repricing:BusinessLogic<RepricingEntity,RepricingDAO>
    {
        public PPP_Project.Criteria.ImportJobsCriteria Criteria { get; set; }
        public override RepricingEntity Entity
        {
            get;
            set;
        }

        public override List<RepricingEntity> EntityList
        {
            get;
            set;
        }

        public override RepricingDAO DAO
        {
            get;
            set;
        }

        public override void Init_Object()
        {
            Entity = new RepricingEntity();
            DAO = new RepricingDAO();
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

        public List<RepricingEntity> Finds()
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

        public override RepricingEntity FindByID(int id)
        {
            throw new NotImplementedException();
        }

        public override RepricingEntity FindByID(string id)
        {
            throw new NotImplementedException();
        }

        public override List<RepricingEntity> FindByCriteria()
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

        // FindRepricingJobImportList
        public List<RepricingEntity> FindRepricingJobImportList()
        {
            try
            {
                Map_Object();
                return DAO.FindRepricingJobImportList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public override RepricingEntity FindByBarCode(string barCode)
        {
            throw new NotImplementedException();
        }

        public override List<RepricingEntity> FindModelCode(string modelCode)
        {
            throw new NotImplementedException();
        }

        public List<RepricingEntity> FindByImportedDateAndCenter(string importDate, string center)
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

        public List<ExportViewWithoutDe> FindByCriteriaWithoutDeForRepricing()
        {
            try
            {
                Map_Object();
                return DAO.FindByCriteriaWithoutDeForRepricing();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<ExportRepricing> FindByCriteriaDenominatorForRepricing()
        {
            try
            {
                Map_Object();
                return DAO.FindByCriteriaDenominatorForRepricing();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<ExportRepricing> FindByCriteriaDenominatorForRepricingSingle()
        {
            try
            {
                Map_Object();
                return DAO.FindByCriteriaDenominatorForRepricingSingle();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<ExportRepricing> FindByCriteriaDenominatorForRepricingSingleIGS()
        {
            try
            {
                Map_Object();
                return DAO.FindByCriteriaDenominatorForRepricingSingleIGS();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<ExportRepricing> FindByCriteriaDenominatorForRepricingSpecial()
        {
            try
            {
                Map_Object();
                return DAO.FindByCriteriaDenominatorForRepricingSpecial();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ReplaceQATRepricing(string center)
        {
            try
            {
                DAO.ReplaceQATRepricing(center);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}