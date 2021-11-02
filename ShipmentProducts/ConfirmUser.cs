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
    public partial class ConfirmUser : Form
    {
        public ConfirmUser()
        {
            InitializeComponent();
            textBox1.Select();
        }

        public string Error { get; set; }
        public int UserID { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!GetUser())
            {                
                textBox1.Clear();
                textBox1.Select();
                return;
            }

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!GetUser())
                {
                    MessageBox.Show("Не верный логин");
                    textBox1.Clear();
                    textBox1.Select();
                    return;
                }

                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        bool GetUser()
        {
            using (FASEntities FAS = new FASEntities())
            {
                //UserName = FAS.FAS_Users.Where(c => c.RFID == textBox1.Text && c.IsActiv == true).Select(c => c.UserName).FirstOrDefault();
                //if (string.IsNullOrEmpty(UserName))
                //    return true;

                var r = FAS.FAS_Users.Where(c => c.RFID == textBox1.Text && c.IsActiv == true).Select(c => c.UserID == c.UserID).FirstOrDefault();
                if (!r)
                {
                    Error = "Не верный логин!";
                    return false;
                }

                r = FAS.FAS_Users.Where(c => c.RFID == textBox1.Text && c.IsActiv == true && new List<int>() { 1, 3 }.Contains(c.UsersGroupID)).Select(c => c.UserID == c.UserID).FirstOrDefault();
                //BaseC.ArrayList.Add(Name);
                if (!r)
                {
                    Error = "Недостаточно прав доступа для этой операции";
                    return false; //Нет прав доступа
                }

                UserID = FAS.FAS_Users.Where(c => c.RFID == textBox1.Text && c.IsActiv == true && new List<int>() { 1, 3 }.Contains(c.UsersGroupID)).Select(c => c.UserID).FirstOrDefault();
                return true;// Верный

            }
        }
    }
}
