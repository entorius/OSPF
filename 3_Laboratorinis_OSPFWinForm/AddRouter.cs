using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_Laboratorinis_OSPFWinForm
{
    public partial class AddRouter : Form
    {
        Form1 form1;
        public AddRouter(Form1 form)
        {
            form1 = form;
            InitializeComponent();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            form1.Show();
            Hide();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if(form1.network.AddRouter(textBox_RouterId.Text, textBox_RouterName.Text))
            {
                System.Console.WriteLine("Routeris pridėtas sėkmingai");
                Hide();
                form1.Show();
            }
            else
            {
                System.Console.WriteLine("Įvedėte neteisingo formato routerio ID arba Rauterio pavadinimą arba routeris jau egzistuoja");
            }
        }
    }
}
