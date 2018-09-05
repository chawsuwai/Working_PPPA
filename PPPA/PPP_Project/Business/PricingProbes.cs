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
    public class PricingProbes:BusinessLogic<PricingProbesEntity,PricingProbesDAO>
    {
        public PPP_Project.Criteria.ImportJobsCriteria Criteria { get; set; }

        public override PricingProbesEntity Entity
        {
            get;
            set;
        }

        public override List<PricingProbesEntity> EntityList
        {
            get;
            set;
        }

        public override PricingProbesDAO DAO
        {
            get;
            set;
        }

        public override void Init_Object()
        {
            Entity = new PricingProbesEntity();
            DAO = new PricingProbesDAO();
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

        public override PricingProbesEntity FindByID(int id)
        {
            throw new NotImplementedException();
        }

        public override PricingProbesEntity FindByID(string id)
        {
            throw new NotImplementedException();
        }

        public override List<PricingProbesEntity> FindByCriteria()
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

        //FindProbesJobImportList
        public List<PricingProbesEntity> FindPricingProbesJobImportList()
        {
            try
            {
                Map_Object();
                return DAO.FindPricingProbesJobImportList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public override PricingProbesEntity FindByBarCode(string barCode)
        {
            throw new NotImplementedException();
        }

        public override List<PricingProbesEntity> FindModelCode(string modelCode)
        {
            throw new NotImplementedException();
        }

        public List<PricingProbesEntity> FindByImportedDateAndCenter(string importDate, string center)
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

        public List<ExportViewWithoutDe> FindByCriteriaWithoutDeForPricingProbes()
        {
            try
            {
                Map_Object();
                return DAO.FindByCriteriaWithoutDeForPricingProbes();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<ExportPricingProbes> FindByCriteriaDenominatorForPricingProbes()
        {
            try
            {
                Map_Object();
                return DAO.FindByCriteriaDenominatorForPricingProbes();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<ExportPricingProbes> FindByCriteriaDenominatorForPricingProbesSingle()
        {
            try
            {
                Map_Object();
                return DAO.FindByCriteriaDenominatorForPricingProbesSingle();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<ExportPricingProbes> FindByCriteriaDenominatorForPricingProbesSingleIGS()
        {
            try
            {
                Map_Object();
                return DAO.FindByCriteriaDenominatorForPricingProbesSingleIGS();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<ExportPricingProbes> FindByCriteriaDenominatorForPricingProbesSpecial()
        {
            try
            {
                Map_Object();
                return DAO.FindByCriteriaDenominatorForPricingProbesSpecial();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ReplaceQATPricingProbes(string center)
        {
            try
            {
                DAO.ReplaceQATPricingProbes(center);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}