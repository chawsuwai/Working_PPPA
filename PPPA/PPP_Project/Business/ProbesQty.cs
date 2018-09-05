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
    public class ProbesQty : BusinessLogic<PQuantityEntity, ProbesQtyDAO>
    {
        public override PQuantityEntity Entity
        {
            get;
            set;
        }

        public override List<PQuantityEntity> EntityList
        {
            get;
            set;
        }

        public override ProbesQtyDAO DAO
        {
            get;
            set;
        }

        public override void Init_Object()
        {
            Entity = new PQuantityEntity();
            DAO = new ProbesQtyDAO();
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

        public override PQuantityEntity FindByID(int id)
        {
            throw new NotImplementedException();
        }

        public override PQuantityEntity FindByID(string id)
        {
            throw new NotImplementedException();
        }

        public override List<PQuantityEntity> FindByCriteria()
        {
            throw new NotImplementedException();
        }

        public override PQuantityEntity FindByBarCode(string barCode)
        {
            throw new NotImplementedException();
        }

        public override List<PQuantityEntity> FindModelCode(string modelCode)
        {
            throw new NotImplementedException();
        }

        public PQuantityEntity FindQty()
        {
            try
            {
                return DAO.FindQty();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public PQuantityEntity FindDataByID(string id)
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

        public List<PQuantityEntity> Find()
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