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

namespace PPP_Project.Business
{
    public class DenoChange : BusinessLogic<DenoChangeEntity, DenoChangeDAO>
    {
        public override DenoChangeEntity Entity
        {
            get;
            set;
        }

        public override List<DenoChangeEntity> EntityList
        {
            get;
            set;
        }

        public override DenoChangeDAO DAO
        {
            get;
            set;
        }

        public override void Init_Object()
        {
            Entity = new DenoChangeEntity();
            DAO = new DenoChangeDAO();
        }

        public override void Map_Object()
        {
            try
            {
                DAO.Entity = this.Entity;
                DAO.EntityList = this.EntityList;
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

        public override DenoChangeEntity FindByID(int id)
        {
            throw new NotImplementedException();
        }

        public override DenoChangeEntity FindByID(string id)
        {
            throw new NotImplementedException();
        }

        public override List<DenoChangeEntity> FindByCriteria()
        {
            throw new NotImplementedException();
        }

        public override DenoChangeEntity FindByBarCode(string barCode)
        {
            throw new NotImplementedException();
        }

        public override List<DenoChangeEntity> FindModelCode(string modelCode)
        {
            throw new NotImplementedException();
        }

        public DenoChangeEntity FindDataByID(string id)
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

        public List<DenoChangeEntity> Find()
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

        public List<SheetEntity> FindAllSheet()
        {
            try
            {
                return DAO.FindAllSheet();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void updateDenominatorChangeForProject(string project, string month, decimal Multiply, string type, string dcdate, string id)
        {
            try
            {
                DAO.updateDenominatorChangeForProject(project, month, Multiply, type, dcdate, id);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public string getCountForProject(string project, string dcDate)
        {
            try
            {
                return DAO.getCountForProject(project, dcDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public string getCountForProjectByDate(string dcDate)
        {
            try
            {
                return DAO.getCountForProjectByDate(dcDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void DeleteNullValue()
        {
            try
            {
                DAO.DeleteNullValue();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DenoChangeEntity FindByProjectAndChangeDate(DenoChangeEntity entity)
        {
            try
            {
                return DAO.FindByProjectAndChangeDate(entity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        
    }
}