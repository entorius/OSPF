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
    public partial class SendingMessageStates : Form
    {
        Form1 form1;
        List<Router> routers;
        Router startRouter;
        Router destRouter;
        Router currentRouter;
        public SendingMessageStates(Form1 form)
        {
            form1 = form;
            InitializeComponent();
        }

        private void button_DeleteRouter_Click(object sender, EventArgs e)
        {
            bool parsed = Int32.TryParse(textBox_DeletingRouterNumber.Text, out int routerNumber);
            if (!parsed)
            {
                Console.WriteLine("Įvedėte neteisingą skaičių");
            }
            int routersNumber = form1.network.GetRouters().Count;
            if (parsed && routerNumber <= routersNumber && routerNumber>0)
            {
                Router deletingRouter = form1.network.GetRouters()[routerNumber-1];
                form1.network.DeleteRouter(deletingRouter);
                if (routers.Contains(deletingRouter))
                {
                    routers = form1.network.FindShotertPath(routers[routers.Count - 1], destRouter);
                    if (routers.Count <= 1)
                    {
                        Hide();
                        form1.Show();
                        System.Console.WriteLine("There is no route anymore after deleting router {0} to router {1}", deletingRouter.Name, destRouter.Name);
                    }
                }
            }
            ChangeTextBoxRoutersText(this.routers, this.textBox_Way);
            ChangeTextBoxRoutersText(form1.network.GetRouters(), this.textBox_AllRouters);
        }
        private void ChangeTextBoxRoutersText(List<Router> routers, TextBox textBox)
        {
            string text = "";
            for (int i = routers.Count-1; i >= 0; i--)
            {
                text = text + (i+1) + ". " + routers[i].Name + Environment.NewLine;
            }
            textBox.Text = text;
        }
        private void ChangeTextBoxRoutesText(List<Network.Path> paths, TextBox textBox)
        {
            string text = "";
            for (int i = paths.Count - 1; i >= 0; i--)
            {
                text = text + (i + 1) + ". " + paths[i].GetFirstRouter().Name + " to " + paths[i].GetSecondRouter().Name + Environment.NewLine;
            }
            textBox.Text = text;
        }
        public void setRouters(List<Router> routers, Router startRouter, Router destRouter)
        {
            this.routers = routers;
            this.startRouter = startRouter;
            this.destRouter = destRouter;
            currentRouter = startRouter;
            ChangeTextBoxRoutersText(this.routers, this.textBox_Way);
            ChangeTextBoxRoutersText(form1.network.GetRouters(), this.textBox_AllRouters);
            ChangeTextBoxRoutesText(form1.network.GetPaths(), this.textBox_AllRoutes);
        }
        private void button_SendToOtherRouter_Click(object sender, EventArgs e)
        {
            if (routers.Count <= 2)
            {
                routers.Remove(routers[routers.Count - 1]);
                if (routers[0] == destRouter)
                {
                    Console.WriteLine("žinutė sėkmingai nusiųsta");
                }
                else if(routers.Count <= 1)
                {
                    Console.WriteLine("žinutės nusiųsti nepavyko");
                }
                
                Hide();
                form1.Show();
            }
            else
            {
                currentRouter.SendMessage(routers[routers.Count - 2], currentRouter.message);
                routers.Remove(routers[routers.Count - 1]);
                currentRouter = routers[routers.Count - 1];
                ChangeTextBoxRoutersText(routers,textBox_Way);
            }
        }

        private void button_DeleteRoute_Click(object sender, EventArgs e)
        {
            bool parsed = Int32.TryParse(textBox_DeletingRoute.Text, out int routeNumber);
            int routersNumber = form1.network.GetPaths().Count;
            if (parsed && routeNumber <= routersNumber && routeNumber > 0)
            {
                Network.Path deletingRoute = form1.network.GetPaths()[routeNumber - 1];
                form1.network.DeleteRoute(deletingRoute);
                if (routers.Contains(deletingRoute.GetFirstRouter())||routers.Contains(deletingRoute.GetSecondRouter()))
                {
                    routers = form1.network.FindShotertPath(routers[routers.Count - 1], destRouter);
                    if (routers.Count <= 1)
                    {
                        Hide();
                        form1.Show();
                        System.Console.WriteLine("There is no route anymore after deleting route {0}", routeNumber);
                    }
                }
            }
            ChangeTextBoxRoutersText(this.routers, this.textBox_Way);
            ChangeTextBoxRoutersText(form1.network.GetRouters(), this.textBox_AllRouters);
        }
    }
}
