using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportWF
{
    public partial class Form1 : Form
    {
        Transport.TransPort TPS = new Transport.TransPort();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddMarshrut AM = new AddMarshrut(TPS);
            AM.ShowDialog();
            UpdateInfo();
        }
        private void UpdateInfo()
        {
            Info.Items.Clear();
            double Sum = 0;
            for (int i=0;i< TPS.Marshrut_A_B_List.Count;i++)
            {
                Sum += TPS.Marshrut_A_B_List[i].Price;
                Info.Items.Add(TPS.Marshrut_A_B_List[i].Name.ToString() + "  " + TPS.Marshrut_A_B_List[i].Price.ToString());
            }
            numericUpDown1.Value = (decimal)Sum;
            Info.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddMarshrut AM = new AddMarshrut(TPS, Info.SelectedIndex);
            AM.ShowDialog();
            UpdateInfo();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TPS.DeleteItemMarshrut_A_B_List(TPS.Marshrut_A_B_List[Info.SelectedIndex]);
            UpdateInfo();
        }

      
    }
}
