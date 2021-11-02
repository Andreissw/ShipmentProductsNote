using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShipmentProducts
{
    public partial class Form1 : Form
    {
        List<BaseClass> ListBase;
        BaseClass Object;  

        public Form1()
        {
            InitializeComponent();
            foreach (var item in new List<string>() {"GS Приемники" })            
                ListType.Items.Add(item);
            GetStatus();

            if (Directory.Exists(@"C:\CSVFile"))
            {
                foreach (var item in Directory.GetFiles(@"C:\CSVFile"))
                {
                    try
                    {
                        File.Delete(item);
                    }
                    catch (Exception)
                    {

                        
                    }
                    
                }
                
            }

            if (ApplicationDeployment.IsNetworkDeployed)
            {
                this.Text = "Программа для отгрузок" + "Verison Product - " + ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();                
            }
        }

        private void BtLiterAdd_Click(object sender, EventArgs e)
        {
            if (Object.LotID == 0)
            {
                MessageBox.Show("Лот не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            var box = new AddBoxForm(Object.LotID);
            var Result = box.ShowDialog();

            if (Result != DialogResult.OK)           
                return;

            listBox1.Items.Add(box.SettingBox);
        }
        void GetStatus()
        {
            using (var fas = new FASEntities())
            {
               var list = fas.FAS_Shipped_Status_TB.Select(c => c.StatusName).ToList();
                list.Add("");
                CBStatus.DataSource = list;
                CBStatus.Text = "";
            }
        }

        private void BT_OK_Click(object sender, EventArgs e)
        {
            ClickType();
        }

        private void OkBT_Click(object sender, EventArgs e)
        {
            if (GridReport.DataSource == null)
                return;           

            Object.OpenShippedSetting(int.Parse(GridReport[4, GridReport.CurrentRow.Index].Value.ToString()), GetShippedStatus());
            //Object.GetGridReport(GridReport);
        }
                
        private void GridReport_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridReport.DataSource == null)
                return;

            if (e.RowIndex == -1)
                return;

            GetShippedStatus();

            Object.GridReport = new DataGridView();
            Object.GridReport = GridReport;
            Object.OpenShippedSetting(int.Parse(GridReport[4, GridReport.CurrentRow.Index].Value.ToString()), GetShippedStatus());
            //Object.GetGridReport(GridReport);
        }

        private void ListType_DoubleClick(object sender, EventArgs e)
        {
            ClickType();
        }

        void ClickType()
        {
            if (ListType.SelectedIndex == -1)
                return;

            ListBase = new List<BaseClass>() { new GS(), new Contract() };
            Object = ListBase[ListType.SelectedIndex];
            Object.control = this;

            Object.OpenType(GB);            
            CBClient.DataSource = Object.GetListClients(); //Получаем список Заказчиков 
            CBClient.Text = "";
            CBModel.DataSource = null;
            NUM.Value = 0;
        }

        private void CBClient_SelectionChangeCommitted(object sender, EventArgs e) //Заказчик
        {
            //if (string.IsNullOrEmpty(CBClient.Text))
            //    return;
            Object.GetCustomerID(CBClient.Text);
            CBModel.DataSource = Object.GetModelList();
            CBModel.Text = "";
        }

        private void CBModel_SelectionChangeCommitted(object sender, EventArgs e) //Модель
        {
            Object.GetModelID(CBModel.Text);
            CBLOT.DataSource = Object.GetLots();
            CBLOT.Text = "";
        }

        private void CBLOT_SelectionChangeCommitted(object sender, EventArgs e) //Заказ
        {
            Object.GetLotID(CBLOT.Text);
            GBValue.Visible = true;
            GBBox.Visible = true;
            LoadLB.Visible = true;
        }      

        private void CBStatus_SelectionChangeCommitted(object sender, EventArgs e) //Тип отгрузки
        {
            if (GetShippedStatus() == 0) {
                GridReport.DataSource = null; return;
            }

            Object.GridReport = new DataGridView();
            Object.GridReport = GridReport;
            Object.GetGridReport();
        }

        int GetShippedStatus()
        {
            using (var fas = new FASEntities())
            {
                if (string.IsNullOrWhiteSpace(CBStatus.Text)) {
                   Object.IDStatusShipped = 0;  return 0;
                }

                var id =  fas.FAS_Shipped_Status_TB.FirstOrDefault(c => c.StatusName == CBStatus.Text).ID;
                Object.IDStatusShipped = id;
                return id;
            }
        }
       

        private void BTOk_Click(object sender, EventArgs e)
        {
            if (NUM.Value == 0)
            {
                MessageBox.Show("Не указано кол-во"); return;
            }

            GetQueryValue(FullBox(CBBox1));
            Check();
            GetShippedStatus();
            Object.GetTable((int)NUM.Value);
            GC.Collect();
        }
        string FullBox(CheckBox CB)
        {
            if (CB.Checked)
                return "1";
            else
                return "1,0";
            
        }
        private void BTOk1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Не указана информация Литтеры и коробок"); return;
            }

            GetQueryBox(ReturnQuery(),FullBox(CBBox2));
            Check();

            Object.GetTable((int)NUM.Value);
            GC.Collect();
        }

        void GetQueryValue(string FullBox)
        {

            Object.QuerySN = $@"use fas
                               SELECT 
                               M.ModelName,FullSTBSN ,p.[SerialNumber],CASID,SmartCardID	,MAC ,format(ManufDate , 'dd.MM.yyyy') ManufDate
                               ,([LiterName] + convert ( nvarchar(2),p.LiterIndex)) Liter ,[PalletNum] ,[BoxNum] ,[UnitNum], FULL_LOT_Code,  Specification
                               FROM [FAS].[dbo].[FAS_PackingGS]  p
                               left join FAS_Start  st on st.SerialNumber = p.SerialNumber 
                               left join FAS_Upload U on U.SerialNumber = p.SerialNumber 
                               left join FAS_GS_LOTs Lt On Lt.LOTID =p.LOTID
                               left join FAS_Models M On M.ModelID = Lt.ModelID
                               left join FAS_Liter As L on L.ID = P.LiterID

                               where p.SerialNumber in 
                               (
                            select TOP({NUM.Value}) t.SerialNumber from( 

                            select *, (case when BoxCapacity = inBox then 1 else 0 end) ПолнаяКоробка from  (
                            select s.SerialNumber ,ROW_NUMBER() over(order by format(ManufDate , 'dd.MM.yyyy'), pac.BoxNum) num
                            ,(select g.BoxCapacity from FAS_GS_LOTs g where pac.LOTID = g.LOTID) BoxCapacity
                            ,count(pac.UnitNum) OVER ( partition by BoxNum,LiterID,LiterIndex,pac.LotID) inBox
                            from FAS_SerialNumbers s
                            left join FAS_Start st on s.SerialNumber = st.SerialNumber 
                               left join FAS_PackingGS pac on s.SerialNumber =pac.SerialNumber
                            where s.LOTID in (select g.LOTID from FAS_GS_LOTs g where g.LOTID = {Object.LotID}) 
                            and s.ShipedStatus is null and s.IsPacked = 1) as tt

                            ) as t where ПолнаяКоробка in ({FullBox}) order by num 

                               )
                               order by LiterID, p.LiterIndex , BoxNum,UnitNum";          

            Object.QueryAggregat = $@"select   min(num1) as по, max(num1) as шт, min(ta.SerialNumber) 'с Диапазон серийных номеров', max(ta.SerialNumber) 'по Диапазон серийных номеров', max(num1) - min(num1) + 1 'Шт'
                               from(
                               SELECT p.[SerialNumber], p.[SerialNumber] - ROW_NUMBER() over (order by p.[SerialNumber]) as num, ROW_NUMBER() over (order by p.[SerialNumber]) as num1

                               FROM [FAS].[dbo].[FAS_PackingGS]  p
                               left join FAS_Start  st on st.SerialNumber = p.SerialNumber 
                               left join FAS_Upload U on U.SerialNumber = p.SerialNumber 
                               left join FAS_GS_LOTs Lt On Lt.LOTID =p.LOTID
                               left join FAS_Models M On M.ModelID = Lt.ModelID
                               left join FAS_Liter As L on L.ID = P.LiterID
                               where p.SerialNumber in 
                               (
                            select  TOP({NUM.Value}) t.SerialNumber from( 
                            
                            select *, (case when BoxCapacity = inBox then 1 else 0 end) ПолнаяКоробка from  (
                            select s.SerialNumber ,ROW_NUMBER() over(order by format(ManufDate , 'dd.MM.yyyy'), pac.BoxNum) num
                            ,(select g.BoxCapacity from FAS_GS_LOTs g where pac.LOTID = g.LOTID) BoxCapacity
                            ,count(pac.UnitNum) OVER ( partition by BoxNum,LiterID,LiterIndex,pac.LotID) inBox
                            from FAS_SerialNumbers s
                            left join FAS_Start st on s.SerialNumber = st.SerialNumber 
                               left join FAS_PackingGS pac on s.SerialNumber =pac.SerialNumber
                            where s.LOTID in (select g.LOTID from FAS_GS_LOTs g where g.LOTID = {Object.LotID}) and s.ShipedStatus is null and s.IsPacked = 1 ) as tt

                            ) as t where ПолнаяКоробка in ({FullBox}) order by num 
                            )) TA group by num order by по";


            Object.QueryUpdate = $@" use fas update FAS_SerialNumbers
                                 set ShipedStatus = 0
                                 where SerialNumber in ( 

                                    select TOP({NUM.Value}) t.SerialNumber from( 
                                 
                                  select *, (case when BoxCapacity = inBox then 1 else 0 end) ПолнаяКоробка from  (
                                 select s.SerialNumber ,ROW_NUMBER() over(order by format(ManufDate , 'dd.MM.yyyy'), pac.BoxNum) num, pac.BoxNum,pac.LiterID, pac.LiterIndex
                                 ,(select g.BoxCapacity from FAS_GS_LOTs g where pac.LOTID = g.LOTID) BoxCapacity
                                 ,count(pac.UnitNum) OVER ( partition by BoxNum,LiterID,LiterIndex,pac.LotID) inBox
                                 from FAS_SerialNumbers s
                                 left join FAS_Start st on s.SerialNumber = st.SerialNumber 
                                 left join FAS_PackingGS pac on s.SerialNumber =pac.SerialNumber
                                 where s.LOTID in (select g.LOTID from FAS_GS_LOTs g where g.LOTID = {Object.LotID}) and s.ShipedStatus is null and s.IsPacked = 1 ) as tt

                                        ) as t where ПолнаяКоробка in ({FullBox}) order by t.LiterID, t.LiterIndex, t.BoxNum
                                 )";


        }

        void GetQueryBox(string query, string FullBox)
        {
            Object.QuerySN = $@"use fas
                                 
                                select * from (
                                 select *, (case when inBox = BoxCapacity then 1 else 0 end) Полнаякоробка from(
                               SELECT 
                               (select ModelName from FAS_Models m where m.ModelID = (select ModelID from FAS_GS_LOTs gg where gg.LOTID = p.LOTID) ) ModelName,
							   FullSTBSN ,p.[SerialNumber],CASID,SmartCardID	,MAC ,format(ManufDate , 'dd.MM.yyyy') ManufDate
                               ,([LiterName] + convert ( nvarchar(2),p.LiterIndex)) Liter ,[PalletNum] ,[BoxNum] ,[UnitNum], 
							   (select FULL_LOT_Code from FAS_GS_LOTs where p.LOTID = LOTID) FULL_LOT_Code,  
							   (select Specification from FAS_GS_LOTs where p.LOTID = LOTID) Specification,  
                               (select g.BoxCapacity from FAS_GS_LOTs g where p.LOTID = g.LOTID) BoxCapacity
                               ,count(p.UnitNum) OVER ( partition by p.BoxNum,p.LiterID,p.LiterIndex,p.LotID) inBox
                               FROM [FAS].[dbo].[FAS_PackingGS]  p
                               left join FAS_Start  st on st.SerialNumber = p.SerialNumber 
                               left join FAS_Upload U on U.SerialNumber = p.SerialNumber 
                               left join FAS_Liter As L on L.ID = P.LiterID

                               where p.SerialNumber in ({query}) and p.lotid = {Object.LotID}) as ttt) as tttt 

                               where Полнаякоробка in ({FullBox})   order by tttt.Liter, BoxNum,UnitNum";


            Object.QueryAggregat = $@"select   min(num1) as по, max(num1) as шт, min(ta.SerialNumber) 'с Диапазон серийных номеров', max(ta.SerialNumber) 'по Диапазон серийных номеров', max(num1) - min(num1) + 1 'Шт'
                               from(
 select *, [SerialNumber] - ROW_NUMBER() over (order by [SerialNumber]) as num from (
                                 select *, (case when inBox = BoxCapacity then 1 else 0 end) Полнаякоробка from(

                               SELECT SerialNumber , ROW_NUMBER() over (order by p.[SerialNumber]) as num1,
                               (select g.BoxCapacity from FAS_GS_LOTs g where p.LOTID = g.LOTID) BoxCapacity
                               ,count(p.UnitNum) OVER ( partition by p.BoxNum,p.LiterID,p.LiterIndex,p.LotID) inBox

                               FROM [FAS].[dbo].[FAS_PackingGS]  p        
                               where p.SerialNumber in ({query}) and p.lotid = {Object.LotID}

                                ) as tt ) as ttt   where Полнаякоробка in ({FullBox})
                             ) TA group by num order by по";

            Object.QueryUpdate = $@" use fas update FAS_SerialNumbers
                                 set ShipedStatus = 0
                                 where SerialNumber in ( select  t.SerialNumber from( 
                                select *, (case when BoxCapacity = inBox then 1 else 0 end) ПолнаяКоробка from  (
                                 select s.SerialNumber ,ROW_NUMBER() over(order by format(ManufDate , 'dd.MM.yyyy'), pac.BoxNum) num
                                ,(select g.BoxCapacity from FAS_GS_LOTs g where pac.LOTID = g.LOTID) BoxCapacity
                                ,count(pac.UnitNum) OVER ( partition by BoxNum,LiterID,LiterIndex,pac.LotID) inBox
                                 from FAS_SerialNumbers s
                                 left join FAS_Start st on s.SerialNumber = st.SerialNumber 
                                 left join FAS_PackingGS pac on s.SerialNumber =pac.SerialNumber
                                 where pac.SerialNumber in ({query})  ) as tt
                                ) as t where ПолнаяКоробка in ({FullBox})
                                 ) ";
        }

      

        string ReturnQuery()
        {
            string Q = "";
            if (listBox1.Items.Count == 1)
            {
                Q = $@"select pac.SerialNumber from FAS_PackingGS pac
                      
                       where pac.LOTID = {Object.LotID} and (select ShipedStatus from FAS_SerialNumbers where pac.SerialNumber = SerialNumber) is null
                       and concat(LiterID, LiterIndex) = {ReturnLiterIndex(0) + listBox1.Items[0].ToString().Substring(1,1)}
                       and pac.BoxNum between {listBox1.Items[0].ToString().Substring(3).Split('-').ToList()[0]} and {listBox1.Items[0].ToString().Substring(3).Split('-').ToList()[1]}";

                return Q;
            }

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                Q += $@"select pac.SerialNumber from FAS_PackingGS pac
                      
                       where pac.LOTID = {Object.LotID} and (select ShipedStatus from FAS_SerialNumbers where pac.SerialNumber = SerialNumber) is null
                       and  concat(LiterID, LiterIndex) = {ReturnLiterIndex(i) + listBox1.Items[i].ToString().Substring(1, 1)}
                       and pac.BoxNum between {listBox1.Items[i].ToString().Substring(3).Split('-').ToList()[0]} and {listBox1.Items[i].ToString().Substring(3).Split('-').ToList()[1]} ";

                if (i != listBox1.Items.Count - 1)               
                    Q += "union all \n";
                
            }

            return Q;
        }

        int ReturnLiterIndex(int i)
        {
            using (var fas = new FASEntities())
            {
                var r = listBox1.Items[i].ToString().Substring(0, 1);
                return fas.FAS_Liter.FirstOrDefault(c => c.LiterName == r).ID;
            }
        }

        private void Check()
        {
            if (CBClient.Text == "")
            {
                MessageBox.Show("Не заполнены поля"); return;
            }
            if (CBModel.Text == "")
            {
                MessageBox.Show("Не заполнены поля"); return;
            }
            if (CBLOT.Text == "")
            {
                MessageBox.Show("Не заполнены поля"); return;
            }
            
        }
      

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            GC.Collect();            
        }

        private void ClearBT_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) {        
                if (listBox1.Items.Count != 0)                
                    listBox1.Items.RemoveAt(0); return;
            }

            listBox1.Items.RemoveAt(listBox1.SelectedIndex);



        }

       
    }
}
