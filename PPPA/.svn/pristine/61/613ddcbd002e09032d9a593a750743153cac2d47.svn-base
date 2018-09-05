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
    public class Masks:BusinessLogic<MasksEntity,MasksDAO>
    {
        public PPP_Project.Criteria.ImportJobsCriteria Criteria { get; set; }

        public override MasksEntity Entity
        {
            get;
            set;
        }

        public override List<MasksEntity> EntityList
        {
            get;
            set;
        }

        public override MasksDAO DAO
        {
            get;
            set;
        }

        public override void Init_Object()
        {
            Entity = new MasksEntity();
            DAO = new MasksDAO();
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

        public List<MasksEntity> Finds()
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


        public override MasksEntity FindByID(int id)
        {
            throw new NotImplementedException();
        }

        public override MasksEntity FindByID(string id)
        {
            throw new NotImplementedException();
        }

        public override List<MasksEntity> FindByCriteria()
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

        // FindPricingProbesJobImportList
        public List<MasksEntity> FindMasksJobImportList()
        {
            try
            {
                Map_Object();
                return DAO.FindMasksJobImportList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override MasksEntity FindByBarCode(string barCode)
        {
            throw new NotImplementedException();
        }

        public override List<MasksEntity> FindModelCode(string modelCode)
        {
            throw new NotImplementedException();
        }

        public List<MasksEntity> FindByImportedDateAndCenter(string importDate, string center)
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

        public List<ExportViewWithoutDe> FindByCriteriaWithoutDeForMasks()
        {
            try
            {
                Map_Object();
                return DAO.FindByCriteriaWithoutDeForMasks();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<ExportMasks> FindByCriteriaDenominatorForMasks()
        {
            try
            {
                Map_Object();
                return DAO.FindByCriteriaDenominatorForMasks();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public List<ExportMasks> FindByCriteriaDenominatorForMasksSingle()
        {
            try
            {
                Map_Object();
                return DAO.FindByCriteriaDenominatorForMasksSingle();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<ExportMasks> FindByCriteriaDenominatorForMasksSingleIGS()
        {
            try
            {
                Map_Object();
                return DAO.FindByCriteriaDenominatorForMasksSingleIGS();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<ExportMasks> FindByCriteriaDenominatorForMasksSpecial()
        {
            try
            {
                Map_Object();
                return DAO.FindByCriteriaDenominatorForMasksSpecial();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<ExportMasksOther> FindByCriteriaDenominatorForMasksDetail()
        {
            try
            {
                Map_Object();
                return DAO.FindByCriteriaDenominatorForMasksDetail();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ReplaceQATMasks(string center)
        {
            try
            {
                DAO.ReplaceQATMasks(center);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}