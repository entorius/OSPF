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
    public partial class Form1 : Form
    {
        public Network network;
        private AddRouter addRouter;
        private AddRoute addRoute;
        private DeleteRouter deleteRouter;
        private DeleteRoute deleteRoute;
        private SeeTable seeTable;
        private SendMessage sendMessage;
        private SendingMessageStates statesWindow;
        public Form1(Network network)
        {
            this.network = network;
            addRouter = new AddRouter(this);
            addRoute = new AddRoute(this) ;
            deleteRouter = new DeleteRouter(this);
            deleteRoute = new DeleteRoute(this) ;
            seeTable = new SeeTable(this);
            statesWindow = new SendingMessageStates(this);
            sendMessage = new SendMessage(this,statesWindow);
            addRouter.Hide();
            addRoute.Hide();
            deleteRouter.Hide();
            deleteRoute.Hide();
            seeTable.Hide();
            sendMessage.Hide();
            InitializeComponent();
        }
        private void button_Ivykdyti_Click(object sender, EventArgs e)
        {
            Hide();
            switch (this.textBox_Komanda.Text)
            {
                case "1":
                    addRouter.Show();
                    break;
                case "2":
                    string routers = "";
                    for (int i = 0; i < network.routers.Count; i++)
                    {
                        routers = routers + (i+1) + ". " + network.routers[i].Name + Environment.NewLine;
                    }
                    addRoute.AddTextToTextBox(addRoute.textBox_Routers, routers);
                    addRoute.Show();
                    
                    break;
                case "3":
                    deleteRouter.Show();
                    break;
                case "4":
                    deleteRoute.Show();
                    break;
                case "5":
                    sendMessage.Show();
                    break;
                case "6":
                    seeTable.Show();
                    break;
                case "7":
                    break;
                default:
                    System.Console.WriteLine("Neteisingas komandos numeris");
                    break;

            }
        }

        private void textBox_Komanda_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
