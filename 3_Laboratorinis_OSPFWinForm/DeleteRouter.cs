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
    public partial class DeleteRouter : Form
    {
        Form1 form1;
        public DeleteRouter(Form1 form)
        {
            form1 = form;
            InitializeComponent();
        }

        private void button_Atsaukti_Click(object sender, EventArgs e)
        {
            form1.Show();
            Hide();
        }

        private void button_Istrinti_Click(object sender, EventArgs e)
        {
            bool parsedRouterNumber = Int32.TryParse(this.textBox_RouterNumber.Text, out int RouterNumber);
            if (form1.network.paths.Count > RouterNumber && RouterNumber > 0 && parsedRouterNumber)
            {
                form1.network.DeleteRouter(form1.network.GetRouters()[RouterNumber]);
                System.Console.WriteLine("Routeris ištrintas sėkmingai");
                form1.Show();
                Hide();
            }
            else
            {
                System.Console.WriteLine("Routrio ištrinti nepavyko");
            }
        }
    }
}
