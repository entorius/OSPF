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
    public partial class SendMessage : Form
    {
        Form1 form1;
        SendingMessageStates statesWindow;
        public SendMessage(Form1 form , SendingMessageStates statesWindow)
        {
            form1 = form;
            this.statesWindow = statesWindow;
            InitializeComponent();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            form1.Show();
            Hide();
        }

        private void button_Send_Click(object sender, EventArgs e)
        {
            System.Console.WriteLine("Routeriu sąrašas:");
            List<Router> routers = form1.network.GetRouters();
            for(int i = 0; i < routers.Count; i++)
            {
                System.Console.WriteLine(i + 1 + ". " + routers[i].Name);
            }
            Int32.TryParse(this.textBox_StartRouter.Text, out int startRouterNumber);
            Int32.TryParse(this.textBox_EndingRouter.Text, out int endingRouterNumber);
            if (startRouterNumber <= routers.Count && startRouterNumber > 0 && endingRouterNumber <= routers.Count && endingRouterNumber > 0)
            {
                List <Router> routersWay = form1.network.FindShotertPath(routers[startRouterNumber - 1], routers[endingRouterNumber - 1]);
                Hide();
                routers[startRouterNumber - 1].message = textBox_Message.Text;
                statesWindow.setRouters(routersWay, routers[startRouterNumber - 1], routers[endingRouterNumber - 1]);
                statesWindow.Show();
            }
        }
    }
}
