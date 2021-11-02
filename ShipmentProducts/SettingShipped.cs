using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShipmentProducts
{
    public partial class SettingShipped : Form
    {

        int id;
        BaseClass BaseClass;
        public SettingShipped(int id, BaseClass baseClass)
        {
            InitializeComponent();
            this.id = id;
            this.BaseClass = baseClass;
        }

        public SettingShipped(int id, BaseClass baseClass, int index)
        {
            InitializeComponent();
            this.id = id;
            this.BaseClass = baseClass;
            button2.Enabled = false;
        }

        string GetLotName()
        {
            using (var fas = new FASEntities())
            {
                return fas.FAS_Shipped_Table.Where(c => c.ID == id).Select(c => fas.FAS_GS_LOTs.Where(v => v.LOTID == c.LOTID).Select(b => b.FULL_LOT_Code).FirstOrDefault()).FirstOrDefault();
            }
        }

        private void button1_Click(object sender, EventArgs e) //Удалить отгрузку
        {
            var Result = MessageBox.Show($"Вы точно уверены, что хотите удалить отгрузку по лоту - \n {GetLotName()}  ??", "Предупреждение!",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (Result == DialogResult.Yes) {

                var conf = new ConfirmUser();
                var dialog = conf.ShowDialog();
                if (dialog != DialogResult.OK)
                {
                    MessageBox.Show(conf.Error,"Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);  return;
                }

                BaseClass.RemoveShipped(id);    
                
                BaseClass.GridReport = BaseClass.GridReport;
                BaseClass.GetGridReport();
                this.Close();
            }
        }

        async void AsyncStart(int id,bool check = true)
        {
            int number = 0;
            GS gs = new GS();
            await Task.Run(() =>
            {
               number = gs.GetTricolorReport(id,check); //Выгрузка TricolorReport       
            });
            if (number == 0)
            {
                MessageBox.Show("Не удалось сформировать отчёт TricolorReport по какой то причине","Отгрузка не удалась",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if (check)
            {
                gs.addReportShipped(id, (short)number);
                BaseClass.SetShipped(id);
                BaseClass.GetGridReport();
            }

           

        }

        

        private void button2_Click(object sender, EventArgs e) //Отгрузка
        {
            var Result = MessageBox.Show($"Вы подтвержаете, что выбранные данные по лоту - \n {GetLotName()} отгружены??", "Предупреждение!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.Yes) {
                                
                BaseClass.GridReport = BaseClass.GridReport;
                AsyncStart(id);



                //BaseClass.SetShipped(id); //Update статусов отгрузки
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SettingShipped_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Загрузка отчёта началась, пожалуйста подождите!", "", MessageBoxButtons.OK, MessageBoxIcon.Question);
            AsyncStart(id,false);
            
        }
    }
}
