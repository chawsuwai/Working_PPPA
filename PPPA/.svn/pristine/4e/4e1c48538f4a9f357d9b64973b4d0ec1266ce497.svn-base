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
    public class AccuracyPercentage : BusinessLogic<AccuracyEntity, AccuracyPercentageDAO>
    {
        public PPP_Project.Criteria.ImportJobsCriteria Criteria { get; set; }

        public override AccuracyEntity Entity
        {
            get;
            set;
        }

        public override List<AccuracyEntity> EntityList
        {
            get;
            set;
        }

        public override AccuracyPercentageDAO DAO
        {
            get;
            set;
        }

        public override void Init_Object()
        {
            Entity = new AccuracyEntity();
            DAO = new AccuracyPercentageDAO();
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

        public override AccuracyEntity FindByID(int id)
        {
            throw new NotImplementedException();
        }

        public override AccuracyEntity FindByID(string id)
        {
            throw new NotImplementedException();
        }

        public override List<AccuracyEntity> FindByCriteria()
        {
            throw new NotImplementedException();
        }

        public override AccuracyEntity FindByBarCode(string barCode)
        {
            throw new NotImplementedException();
        }

        public override List<AccuracyEntity> FindModelCode(string modelCode)
        {
            throw new NotImplementedException();
        }

        public List<AccuracyEntity> FindByAccPerDate(string accDate, string center)
        {
            try
            {
                return DAO.FindByAccPerDate(accDate,center);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ExportAccuracy> FindByMonthFor3PA(string center, string Month, string FromDate, string ToDate, string Month2, string FromDate2, string ToDate2)
        {

            try
            {
                Map_Object();
                return DAO.FindByMonthFor3PA(center, Month, FromDate, ToDate, Month2, FromDate2, ToDate2);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<ExportAccuracy> FindByMonthFor3PAGSS(string center, string Month, string FromDate, string ToDate, string Month2, string FromDate2, string ToDate2)
        {

            try
            {
                Map_Object();
                return DAO.FindByMonthFor3PAGSS(center, Month, FromDate, ToDate, Month2, FromDate2, ToDate2);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<ExportAccuracy> FindByMonthForAbove96P(string center, string Month, int Total, decimal percent, string FromDate, string ToDate, string Month2, string FromDate2, string ToDate2)
        {

            try
            {
                Map_Object();
                return DAO.FindByMonthForAbove96P(center,Month,Total,percent,FromDate,ToDate,Month2,FromDate2,ToDate2);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public List<ExportAccuracy> FindByMonthForAboveGSS(string center, string Month, int Total, decimal percent, string FromDate, string ToDate, string Month2, string FromDate2, string ToDate2)
        {

            try
            {
                Map_Object();
                return DAO.FindByMonthForAboveGSS(center, Month, Total, percent, FromDate, ToDate, Month2, FromDate2, ToDate2);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<ExportAccuracy> FindByMonthForUnder96P(string center, string Month, int Total, decimal percent, string FromDate, string ToDate, string Month2, string FromDate2, string ToDate2)
        {
            try
            {
                Map_Object();
                return DAO.FindByMonthForUnder96P(center, Month, Total, percent, FromDate, ToDate, Month2, FromDate2, ToDate2);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<ExportAccuracy> FindByMonthForUnderGSS(string center, string Month, int Total, decimal percent, string FromDate, string ToDate, string Month2, string FromDate2, string ToDate2)
        {
            try
            {
                Map_Object();
                return DAO.FindByMonthForUnderGSS(center, Month, Total, percent, FromDate, ToDate, Month2, FromDate2, ToDate2);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<AccuracyEntity> Finds()
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

        public List<AccuracyEntity> FindByQATWithAccMonth(string QAT, string accDate)
        {
            try
            {
                return DAO.FindByQATWithAccMonth(QAT,accDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public AccuracyEntity FindDataByID(string id)
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

        public List<AccuracyEntity> FindQAT()
        {
            try
            {
                return DAO.FindQAT();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ReplaceQATAccuracy(string center)
        {
            try
            {
                DAO.ReplaceQATAccuracy(center);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string FindMonthAndYear(string FromDate)
        {
            try
            {
                return DAO.FindMonthAndYear(FromDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public string FindPreviousMonth(string FromDate)
        {
            try
            {
                return DAO.FindPreviousMonth(FromDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public string FindLastDayOfMonth(string FromDate)
        {
            try
            {
                return DAO.FindLastDayOfMonth(FromDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }



     
    }
}