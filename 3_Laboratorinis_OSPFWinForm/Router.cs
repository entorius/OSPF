using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace _3_Laboratorinis_OSPFWinForm
{
    public class Router
    {
        public struct Neighbour
            {
            Router Router;
            int Cost;
            public Neighbour (Router router,int cost)
            {
                this.Router = router;
                this.Cost = cost;
            }
            }
        public string Id { set; get; }
        public string Name { set; get; }
        List<Router> AllRouters = new List<Router>();
        private List<Neighbour> neighbours = new List<Neighbour>();
        private bool mainRouter = false;
        public bool sentMessageDeleted = false;
        public string message;
        private Network network;
        public Router(string routerId,string routerName, Network network)
        {
            AllRouters = network.GetRouters();
            Id = routerId;
            Name = routerName;
            this.network = network;
            
        }
        public Dictionary<Router, int> getRoutesTable()
        {
            return network.SPath.SPDijkstra(this, network);
        }
        public void RefreshAllRouters(List<Router> routers)
        {
            AllRouters = routers;
        }
        public void addNeighbour(Router router,int length)
        {
            neighbours.Add(new Neighbour(router,length));
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 10000;
            timer.Elapsed += (sender, e) => MyElapsedMethod(sender, e, router);
            timer.Start();

        }
        public void MyElapsedMethod(object sender, ElapsedEventArgs e, Router router)
        {
            sendHelloMessage(router);
        }
        public void sendDeletedMessage(Network network)
        {
            network.GetDeletedMessage(Name);
        }
        public void GetDeletedRouterName(string routerName)
        {
            if(mainRouter == true && sentMessageDeleted == false)
            {
                sentMessageDeleted = true;
                network.GetDeletedMessage(routerName);
            }
        }
        public void SetMainRouter()
        {
            mainRouter = true;
        }
        public bool IsMainRouter()
        {
            return mainRouter;
        }
        public void ReceiveMessage(Router router, string message)
        {
            this.message = message;
            System.Console.WriteLine("Message received from {0}: {1}", router.Name, message);
        }
        public void SendMessage(Router router, string message)
        {
            router.ReceiveMessage(this, message);
        }
        public void ReceiveHelloMessage(string helloMessage)
        {
            network.console.textBox_Console.Invoke(new Action(() => network.console.textBox_Console.AppendText(helloMessage.ToString())));
        }
        public void sendHelloMessage(Router router)
        {
            
            router.ReceiveHelloMessage("Hello message from "+this.Name+" to " +router.Name +" at " + DateTime.Now.ToString() + Environment.NewLine);
        }
    }
}
