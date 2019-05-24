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
    public partial class SeeTable : Form
    {
        Form1 form1;
        public SeeTable(Form1 form)
        {
            form1 = form;
            InitializeComponent();
        }

        private void button_Atsaukti_Click(object sender, EventArgs e)
        {
            form1.Show();
            Hide();
        }

        private void button_Parodyti_Click(object sender, EventArgs e)
        {
            bool parsedRouterNumber = Int32.TryParse(this.textBox_RouterNumber.Text, out int RouterNumber);
            if(parsedRouterNumber && RouterNumber < form1.network.GetRouters().Count && RouterNumber >0)
            {
                Dictionary<Router, int> routesTable = form1.network.GetRouters()[RouterNumber - 1].getRoutesTable();
                int length = routesTable.Count;
                System.Console.WriteLine("Routes: ");
                for (int i = 0; i < length; i++)
                {
                    Router key = routesTable.Keys.ToArray()[i];
                    int number = i + 1;
                    System.Console.WriteLine(number + ". Name: " + key.Name + " Length: " + routesTable[key]);
                }
            }
            Hide();
            form1.Show();
        }
    }
}
