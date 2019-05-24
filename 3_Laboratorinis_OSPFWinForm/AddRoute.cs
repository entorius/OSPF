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
    public partial class AddRoute : Form
    {
        Form1 form1;
        public AddRoute(Form1 form)
        {
            form1 = form;
            InitializeComponent();
        }
        
        private void button_Atsaukti_Click(object sender, EventArgs e)
        {
            form1.Show();
            Hide();
        }
        public void AddTextToTextBox(TextBox textBox,string text)
        {
            textBox.Text = text;
        }

        private void button_Prideti_Click(object sender, EventArgs e)
        {
            List<Router> routers = form1.network.GetRouters();
            bool parsed1 = Int32.TryParse(this.textBox_RouterOne.Text, out int firstRouterNumber);
            bool parsed2 = Int32.TryParse(this.textBox_RouterTwo.Text, out int secondRouterNumber);
            bool parsedLength = Int32.TryParse(this.textBox_RouterTwo.Text, out int Length);
            if (parsed1 && parsed2 && parsedLength && firstRouterNumber <= routers.Count && firstRouterNumber >0 && secondRouterNumber >0 && secondRouterNumber <= routers.Count)
            {
                Router firstRouter = routers[firstRouterNumber-1];
                Router secondRouter = routers[secondRouterNumber-1];
                if(form1.network.AddPath(firstRouter, secondRouter, Length))
                {
                    System.Console.WriteLine("Kelias pridėtas sėkmingai");
                    form1.Show();
                    Hide();
                }
                else
                {
                    System.Console.WriteLine("Nepavyko pridėti kelio");
                }
            }
            else
            {
                System.Console.WriteLine("Nepavyko pridėti kelio");
            }
        }
    }
}
