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
    public class ProbesRange : BusinessLogic<ProbesRangeEntity, ProbesRangeDAO>
    {
        public override ProbesRangeEntity Entity
        {
            get;
            set;
        }

        public override List<ProbesRangeEntity> EntityList
        {
            get;
            set;
        }

        public override ProbesRangeDAO DAO
        {
            get;
            set;
        }

        public override void Init_Object()
        {
            Entity = new ProbesRangeEntity();
            DAO = new ProbesRangeDAO();
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

        public override ProbesRangeEntity FindByID(int id)
        {
            try
            {
                return DAO.FindByID(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override ProbesRangeEntity FindByID(string id)
        {
            throw new NotImplementedException();
        }

        public override List<ProbesRangeEntity> FindByCriteria()
        {
            throw new NotImplementedException();
        }

        public override ProbesRangeEntity FindByBarCode(string barCode)
        {
            throw new NotImplementedException();
        }

        public override List<ProbesRangeEntity> FindModelCode(string modelCode)
        {
            throw new NotImplementedException();
        }

        public List<ProbesRangeEntity> FindRangeInfo()
        {
            try
            {
                return DAO.FindRangeInfo();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateRangeInfo(ProbesRangeEntity v)
        {
            try
            {
                DAO.UpdateRangeInfo(v);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}