using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PPP_Project.Entity;
using PPP_Project.DAO;
using PPP_Project.Base;


namespace PPP_Project.Criteria
{
    public class User : BusinessLogic<UserEntity,UserDAO>
    {
        public override UserEntity Entity
        {
            get;
            set;
        }

        public override List<UserEntity> EntityList
        {
            get;
            set;
        }

        public override UserDAO DAO
        {
            get;
            set;
        }

        public override void Init_Object()
        {
            DAO = new UserDAO();
        }

        public override void Map_Object()
        {
            DAO.Entity = this.Entity;
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
            throw new NotImplementedException();
        }

        public override UserEntity FindByID(int id)
        {
            throw new NotImplementedException();
        }

        public override UserEntity FindByID(string id)
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

        public List<UserEntity> Finds()
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

        public override List<UserEntity> FindByCriteria()
        {
            throw new NotImplementedException();
        }        

        public UserEntity FindByIDandPasswordandBranchCode(string id, string pw, string Bcode)
        {
            try
            {
                return DAO.FindByIDandPasswordandBranchCode(id, pw, Bcode);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override UserEntity FindByBarCode(string barCode)
        {
            throw new NotImplementedException();
        }

        public override List<UserEntity> FindModelCode(string modelCode)
        {
            throw new NotImplementedException();
        }
    }
}