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

namespace PPP_Project.Criteria
{
    public class ProjectDenominators : BusinessLogic<ProjectDenominatorsEntity, ProjectDenominatorsDAO>
    {
        public override ProjectDenominatorsEntity Entity
        {
            get;
            set;
        }

        public override List<ProjectDenominatorsEntity> EntityList
        {
            get;
            set;
        }

        public override ProjectDenominatorsDAO DAO
        {
            get;
            set;
        }

        public override void Init_Object()
        {
            Entity = new ProjectDenominatorsEntity();
            DAO = new ProjectDenominatorsDAO();
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

        public override ProjectDenominatorsEntity FindByID(int id)
        {
            throw new NotImplementedException();
        }

        public override ProjectDenominatorsEntity FindByID(string id)
        {
            throw new NotImplementedException();
        }

        public override List<ProjectDenominatorsEntity> FindByCriteria()
        {
            throw new NotImplementedException();
        }

        public override ProjectDenominatorsEntity FindByBarCode(string barCode)
        {
            throw new NotImplementedException();
        }

        public override List<ProjectDenominatorsEntity> FindModelCode(string modelCode)
        {
            throw new NotImplementedException();
        }

        public List<ProjectDenominatorsEntity> FindByImportedDate(string importDate)
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

        public List<ProjectDenominatorsEntity> FindPROJECT()
        {
            try
            {
                return DAO.FindPROJECT();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string getDenominatorForProject(string project, string month, decimal Multiply, string type)
        {
            try
            {
                return DAO.getDenominatorForProject(project, month, Multiply, type);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<ProjectDenominatorsEntity> Find()
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

        public ProjectDenominatorsEntity FindDataByID(string id)
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

        public ProjectDenominatorsEntity FindDataByProjectAndMonth(string sProject, string sMonth)
        {
            try
            {
                return DAO.FindDataByProjectAndMonth(sProject, sMonth);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}