using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShipmentProducts
{
    public abstract class BaseClass
    {
        public BaseClass()
        {
           
        }

        public Control control { get; set; }

        public int IDStatusShipped { get; set; }

        public  int LotID { get; set; }

        public string QuerySN { get; set; }
        public string QueryAggregat { get; set; }

        public string QueryUpdate { get; set; }

        public  int ModelID { get; set; }

        public int StatusShippID { get; set; }
        public DataGridView GridReport { get; set; }        
        public abstract List<string> GetListClients();
        public abstract List<string> GetModelList();
        public abstract void GetCustomerID(string name);

        public abstract void GetLotID(string name);

        public abstract List<string> GetLots();

        public abstract void GetTable(int count);

        public abstract void GetShippedTable(DataGridView Grid);

        public abstract void RemoveShipped(int id);

        public void SetShipped(int id)
        {
            using (var fas = new FASEntities())
            {
                var sh = fas.FAS_Shipped_Table.Where(c => c.ID == id).FirstOrDefault();
                sh.Status = 3;
                fas.SaveChanges();
            }
        }

        public string QueryUpdateValue(int IDShipped,int count) 
        {
            return $@"use fas update FAS_SerialNumbers
                                 set ShipedStatus = {IDShipped}
                                 where SerialNumber in ( select TOP({count}) t.SerialNumber from( 
                                 select s.SerialNumber ,ROW_NUMBER() over(order by format(ManufDate , 'dd.MM.yyyy'), pac.BoxNum) num
                                 from FAS_SerialNumbers s
                                 left join FAS_Start st on s.SerialNumber = st.SerialNumber 
                                 left join FAS_PackingGS pac on s.SerialNumber =pac.SerialNumber
                                 where s.LOTID in (select g.LOTID from FAS_GS_LOTs g where g.LOTID = {LotID})
                                 and s.ShipedStatus is null and s.IsPacked = 1 and pac.FullBox = 1) as t order by num )";
        }

        public void OpenShippedSetting(int id, int index)
        {
            if (index == 3)
            {
                SettingShipped st1 = new SettingShipped(id, this,3);
                st1.ShowDialog(); return;
            }

            SettingShipped st = new SettingShipped(id, this);
            st.ShowDialog();
        }

        void RemodeReportShipped()
        { 
        
        }

        public void GetGridReport()
        {
            if (GridReport == null)
                return;

            GridReport.Visible = true;
            LoadGrid.Loadgrid(GridReport, $@"  use fas SELECT count Кол_во,date Дата,concat(LOTCode, ' | ', FULL_LOT_Code) Лот, st.StatusName Статус, s.ID
              FROM [FAS].[dbo].[FAS_Shipped_Table] s
              left join FAS_GS_LOTs g on s.LOTID = g.LOTID
              left join FAS_Shipped_Status_TB st on s.Status = st.ID
              where StatusName is not null and s.Status = {IDStatusShipped}   order by date desc ");
            GridReport.Columns[4].Visible = false;
        }

        public void GetModelID(string name)
        {
            using (var fas = new FASEntities())
            {
                ModelID = fas.FAS_Models.Where(c => c.ModelName == name).Select(c => c.ModelID).FirstOrDefault();
            }
        }

        public void OpenType(Control control)
        {
            control.Location = new Point(354, 38);
            control.Size = new Size(959, 597);
            control.Visible = true;
        }

    }
}
