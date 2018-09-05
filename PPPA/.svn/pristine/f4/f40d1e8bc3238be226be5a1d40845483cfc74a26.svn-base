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
    public class Probes:BusinessLogic<ProbesEntity,ProbesDAO>
    {
        public PPP_Project.Criteria.ImportJobsCriteria Criteria { get; set; }

        public override ProbesEntity Entity
        {
            get;
            set;
        }

        public override List<ProbesEntity> EntityList
        {
            get;
            set;
        }

        public override ProbesDAO DAO
        {
            get;
            set;
        }

        public override void Init_Object()
        {
            Entity = new ProbesEntity();
            DAO = new ProbesDAO();
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

        public List<ProbesEntity> Finds()
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

        public List<BranchEntity> FindAllBranch()
        {
            try
            {
                return DAO.FindAllBranch();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public override ProbesEntity FindByID(int id)
        {
            throw new NotImplementedException();
        }

        public override ProbesEntity FindByID(string id)
        {
            throw new NotImplementedException();
        }

        public override List<ProbesEntity> FindByCriteria()
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

        // FindJobImportList
        public List<ProbesEntity> FindProbesJobImportList()
        {
            try
            {
                Map_Object();
                return DAO.FindProbesJobImportList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public override ProbesEntity FindByBarCode(string barCode)
        {
            throw new NotImplementedException();
        }

        public override List<ProbesEntity> FindModelCode(string modelCode)
        {
            throw new NotImplementedException();
        }

        public List<ProbesEntity> FindByImportedDateAndCenter(string importDate, string center)
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

        public List<ExportViewWithoutDe> FindByCriteriaWithoutDe()
        {
            try
            {
                Map_Object();
                return DAO.FindByCriteriaWithoutDe();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<ExportViewWithoutDe> FindByCriteriaWithoutDeForProbes()
        {
            try
            {
                Map_Object();
                return DAO.FindByCriteriaWithoutDeForProbes();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<ExportProbes> FindByCriteriaDenominatorForProbes()
        {
            try
            {
                Map_Object();
                return DAO.FindByCriteriaDenominatorForProbes();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<ExportProbes> FindByCriteriaDenominatorForProbesSingle()
        {
            try
            {
                Map_Object();
                return DAO.FindByCriteriaDenominatorForProbesSingle();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<ExportProbes> FindByCriteriaDenominatorForProbesSingleIGS()
        {
            try
            {
                Map_Object();
                return DAO.FindByCriteriaDenominatorForProbesSingleIGS();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public List<ExportProbes> FindByCriteriaDenominatorForProbesSpecial()
        {
            try
            {
                Map_Object();
                return DAO.FindByCriteriaDenominatorForProbesSpecial();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public void CalculateTotalProbes()
        {
            try
            {
                Map_Object();
                DAO.CalculateTotalProbes();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ReplaceQATProbes(string center)
        {
            try
            {
                DAO.ReplaceQATProbes(center);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ExportViewDeno> FindByCriteriaDenominatorForAll()
        {
            try
            {
                Map_Object();
                return DAO.FindByCriteriaDenominatorForAll();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public List<ExportViewDeno> FindByCriteriaDenominatorForAllSingle()
        {
            try
            {
                Map_Object();
                return DAO.FindByCriteriaDenominatorForAllSingle();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public List<ExportViewDeno> FindByCriteriaDenominatorForAllSingleIGS()
        {
            try
            {
                Map_Object();
                return DAO.FindByCriteriaDenominatorForAllSingleIGS();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<ExportViewDeno> FindByCriteriaDenominatorForAllSpecial()
        {
            try
            {
                Map_Object();
                return DAO.FindByCriteriaDenominatorForAllSpecial();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public string CheckDate(string FromDate, string ToDate, string ChkDate)
        {
            try
            {
                return DAO.CheckDate(FromDate,ToDate,ChkDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

       
    }
}