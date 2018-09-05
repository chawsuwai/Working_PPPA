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
    public class ProbesRate : BusinessLogic<RateEntity, ProbesRateDAO>
    {
        public override RateEntity Entity
        {
            get;
            set;
        }

        public override List<RateEntity> EntityList
        {
            get;
            set;
        }

        public override ProbesRateDAO DAO
        {
            get;
            set;
        }

        public override void Init_Object()
        {
            Entity = new RateEntity();
            DAO = new ProbesRateDAO();
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

        public override RateEntity FindByID(int id)
        {
            throw new NotImplementedException();
        }

        public override RateEntity FindByID(string id)
        {
            throw new NotImplementedException();
        }

        public override List<RateEntity> FindByCriteria()
        {
            throw new NotImplementedException();
        }

        public override RateEntity FindByBarCode(string barCode)
        {
            throw new NotImplementedException();
        }

        public override List<RateEntity> FindModelCode(string modelCode)
        {
            throw new NotImplementedException();
        }

        public RateEntity FindRate()
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

        public RateEntity FindDataByID(string id)
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

        public List<RateEntity> Find()
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

        public string getRangeLabel(int id)
        {
            try
            {
                return DAO.getRangeLabel(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}