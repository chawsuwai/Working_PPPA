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
    public class AccuracyPercentRate : BusinessLogic<AccPerRateEntity, AccPerRateDAO>
    {
        public override AccPerRateEntity Entity
        {
            get;
            set;
        }

        public override List<AccPerRateEntity> EntityList
        {
            get;
            set;
        }

        public override AccPerRateDAO DAO
        {
            get;
            set;
        }

        public override void Init_Object()
        {
            Entity = new AccPerRateEntity();
            DAO = new AccPerRateDAO();
        }

        public override void Map_Object()
        {
            DAO.Entity = this.Entity;
            DAO.EntityList = this.EntityList;
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

        public override AccPerRateEntity FindByID(int id)
        {
            throw new NotImplementedException();
        }

        public override AccPerRateEntity FindByID(string id)
        {
            throw new NotImplementedException();
        }

        public override List<AccPerRateEntity> FindByCriteria()
        {
            throw new NotImplementedException();
        }

        public override AccPerRateEntity FindByBarCode(string barCode)
        {
            throw new NotImplementedException();
        }

        public override List<AccPerRateEntity> FindModelCode(string modelCode)
        {
            throw new NotImplementedException();
        }

        public AccPerRateEntity FindRate()
        {
            try
            {
                return DAO.FindRate();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public AccPerRateEntity FindDataByID(string id)
        {
            try
            {
                return DAO.FindDataByID(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<AccPerRateEntity> Find()
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
    }
}