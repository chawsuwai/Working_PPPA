using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PPP_Project.Base
{
    public abstract class BusinessLogic<E, D>
    {
        public abstract E Entity { get; set; }

        public abstract List<E> EntityList { get; set; }

        public abstract D DAO { get; set; }

        public BusinessLogic()
        {
            Init_Object();
        }

        //public abstract List<E> FindKeyValue(string aKeyColumnName, string aValueColumnName);

        public abstract void Init_Object();

        public abstract void Map_Object();

        public abstract void Save();

        public abstract void Saves();

        public abstract void Update();

        public abstract void Delete();

        public abstract E FindByID(int id);

        public abstract E FindByID(string id);

        public abstract List<E> FindByCriteria();

        public abstract E FindByBarCode(string barCode);

        public abstract List<E> FindModelCode(string modelCode);


    }
}