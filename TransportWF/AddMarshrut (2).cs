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
    public partial class AddMarshrut : Form
    {
        Transport.TransPort TPStemp = new Transport.TransPort();
        bool ChangeItem = false;
        int IndexChange = 0;
        public AddMarshrut(Transport.TransPort TPS)
        {
            InitializeComponent();
            TPStemp = TPS;
            ChangeItem = false;
        }
        public AddMarshrut(Transport.TransPort TPS, int index)
        {
            InitializeComponent();
            TPStemp = TPS;
            numericUpDown1.Value = (decimal)TPStemp.Marshrut_A_B_List[index].Price;
            if (TPStemp.Marshrut_A_B_List[index].Name == "Эконом класс") radioButton1.Checked = true;
            if (TPStemp.Marshrut_A_B_List[index].Name == "Бизнес класс") radioButton2.Checked = true;
            if (TPStemp.Marshrut_A_B_List[index].Name == "Первый класс") radioButton3.Checked = true;
            IndexChange = index;
            ChangeItem = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ChangeItem)
            {
                TPStemp.DeleteItemMarshrut_A_B_List(TPStemp.Marshrut_A_B_List[IndexChange]);
            }
                if (radioButton1.Checked)
                {
                    Transport.Ecomon TPE = new Transport.Ecomon(Convert.ToDouble(numericUpDown1.Value), radioButton1.Text);
                    TPStemp.AddItemMarshrut_A_B_List(TPE);

                };
                if (radioButton2.Checked)
                {
                    Transport.Business TPB = new Transport.Business(Convert.ToDouble(numericUpDown1.Value), radioButton2.Text);
                    TPStemp.AddItemMarshrut_A_B_List(TPB);

                };
                if (radioButton3.Checked)
                {
                    Transport.VIP TPV = new Transport.VIP(Convert.ToDouble(numericUpDown1.Value), radioButton3.Text);
                    TPStemp.AddItemMarshrut_A_B_List(TPV);

                };
         
            
      

        }

    }
}
