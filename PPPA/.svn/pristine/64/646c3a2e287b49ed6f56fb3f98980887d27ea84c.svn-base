using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PPP_Project.Base;

namespace PPP_Project.Common.Feature
{
    public interface IDBWriteable
    {
        void ExcuteInsertCommand<B>(B aEntity, string con) where B : EntityBase, new();

        /// <summary>
        /// To Excute SQL Bulk Insert Command
        /// </summary>
        /// <typeparam name="B"></typeparam>
        /// <param name="aEnitites"></param>
        /// <param name="aDatabase"></param>
        void ExcuteBulkInsertCommand<B>(List<B> aEnitites, string con) where B : EntityBase, new();

        /// <summary>
        ///To Excute SQL Update Command
        /// </summary>
        /// <typeparam name="B"></typeparam>
        /// <param name="aEntity"></param>
        /// <param name="aDAOConnection"></param>
        void ExcuteUpdateCommand<B>(B aEntity, string con) where B : EntityBase, new();

        /// <summary>
        ///To Excute SQL Delete Command
        /// </summary>
        /// <typeparam name="B"></typeparam>
        /// <param name="aEntity"></param>
        /// <param name="aDatabase"></param>
        void ExcuteDeleteCommand<B>(B aEntity, string con) where B : EntityBase, new();
    }
}
