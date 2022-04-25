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
    public partial class AddBoxForm : Form
    {
        int LOTID;
       public string SettingBox { get; set; }
        public AddBoxForm(int LOTID)
        {
            InitializeComponent();            
            this.LOTID = LOTID;
            GetListLiter();
            GetmaxandMin();
        }

        void GetmaxandMin()
        {
            var min = minBox();
            var max = maxBox();
            boxStart.Minimum = min;
            boxStart.Maximum = max;
            BoxEnd.Minimum = min;
            BoxEnd.Maximum = max;
        }

        void GetListLiter()
        {
            using (var fas = new FASEntities())
            {
                CBLiter.DataSource = fas.FAS_PackingGS.OrderBy(c=>c.LiterID & c.LiterIndex).Where(c => c.LOTID == LOTID).Select(c => fas.FAS_Liter.Where(b => b.ID == c.LiterID).Select(b => b.LiterName).FirstOrDefault() + c.LiterIndex).Distinct().ToList();
                
            }
            
        }

        int maxBox()
        {
            
            using (var fas = new FASEntities())
            {                
                
                var litid = fas.FAS_Liter.Where(c => c.LiterName == CBLiter.Text.Substring(0, 1)).Select(c => c.ID).FirstOrDefault();
                var litindex = short.Parse(CBLiter.Text.Substring(1));
                return fas.FAS_PackingGS.Where(c => c.LOTID == LOTID &&  c.LiterID == litid && c.LiterIndex == litindex).Max(c => c.BoxNum);
            }
        }

        int minBox()
        {
            using (var fas = new FASEntities())
            {
                return fas.FAS_PackingGS.Where(c => c.LOTID == LOTID).Min(c => c.BoxNum);
            }
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CBLiter.Text))
            {
                MessageBox.Show("Не выбрана Литера","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error); return;
            }

            if (boxStart.Value == 0)
            {
                MessageBox.Show("Стартовая коробка не может быть равна 0", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }

            if (BoxEnd.Value == 0)
            {
                MessageBox.Show("Последняя коробка не может быть равна 0", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }

            if (boxStart.Value > BoxEnd.Value)
            {
                MessageBox.Show("Стартовая коробка не может быть больше последней", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }

            SettingBox = CBLiter.Text + "," + boxStart.Value.ToString() + "-" + BoxEnd.Value.ToString();
            DialogResult = DialogResult.OK;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

        private void BoxEnd_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void BoxEnd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GetmaxandMin();
            }
        }

        private void CBLiter_TextUpdate(object sender, EventArgs e)
        {
        
        }

        private void CBLiter_TextChanged(object sender, EventArgs e)
        {
            GetmaxandMin();
        }
    }
}
