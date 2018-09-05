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
    public class ProjectNames : BusinessLogic<ProjectNamesEntity, ProjectNamesDAO>
    {
        public override ProjectNamesEntity Entity
        {
            get;
            set;
        }

        public override List<ProjectNamesEntity> EntityList
        {
            get;
            set;
        }

        public override ProjectNamesDAO DAO
        {
            get;
            set;
        }

        public override void Init_Object()
        {
            Entity = new ProjectNamesEntity();
            DAO = new ProjectNamesDAO();
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
            throw new NotImplementedException();
        }

        public override void Delete()
        {
            throw new NotImplementedException();
        }

        public override ProjectNamesEntity FindByID(int id)
        {
            throw new NotImplementedException();
        }

        public override ProjectNamesEntity FindByID(string id)
        {
            throw new NotImplementedException();
        }

        public override List<ProjectNamesEntity> FindByCriteria()
        {
            throw new NotImplementedException();
        }

        public override ProjectNamesEntity FindByBarCode(string barCode)
        {
            throw new NotImplementedException();
        }

        public override List<ProjectNamesEntity> FindModelCode(string modelCode)
        {
            throw new NotImplementedException();
        }

        public List<ProjectNamesEntity> FindByImportedDate(string importDate)
        {
            try
            {
                return DAO.FindByImportedDate(importDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ProjectNamesEntity> FindByProjectName(string importDate, string SheetName)
        {
            try
            {
                return DAO.FindByProjectName(importDate,SheetName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ProjectNamesEntity> FindByImportedDateWithSheet(string importDate, string SheetName, string Status)
        {
            try
            {
                return DAO.FindByImportedDateWithSheet(importDate,SheetName,Status);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}