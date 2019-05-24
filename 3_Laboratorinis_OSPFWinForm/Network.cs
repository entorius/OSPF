using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Laboratorinis_OSPFWinForm
{
   public class Network
    {
        public Consolecs console = new Consolecs();
        private int mask;
        public struct Path
        {
            Router firstRouter;
            Router secondRouter;
            int cost;
            public Path(Router firstRouter,Router secondRouter,int cost)
            {
                this.firstRouter = firstRouter;
                this.secondRouter = secondRouter;
                this.cost = cost;
            }
            public bool EqualsFirstRouter(Router router)
            {
                if (this.firstRouter == router)
                    return true;
                else
                    return false;
            }
            public bool EqualsSecondRouter(Router router)
            {
                if (this.secondRouter == router)
                    return true;
                else
                    return false;
            }
            public Router GetFirstRouter()
            {
                return firstRouter;
            }
            public Router GetSecondRouter()
            {
                return secondRouter;
            }
            public int getCost()
            {
                return cost;
            }
        }

        public List<Path> paths = new List<Path>();
        public List<Router> routers = new List<Router>();
        public ShortestPath SPath = new ShortestPath();
        private string currentDeletedRouterName = "";
        private int sentMessagesWithCurrentName = 0;
        public Network()
        {
            
            console.Show();
        }
        public bool AddPath(Router router1,Router router2,int cost)
        {
            Path path = new Path(router1, router2, cost);
            router1.addNeighbour(router2, cost);
            router2.addNeighbour(router1, cost);
            paths.Add(path);
            return true;
        }
        public bool AddRouter(string routerId,string routerName)
        {
            for(int i = 0; i < routers.Count; i++)
            {
                if (routers[i].Name.Equals(routerName) || routers[i].Id.Equals(routerId))
                {
                    return false;
                }
            }
            Router router = new Router(routerId, routerName, this);
            routers.Add(router);
            for (int i = 0; i < routers.Count; i++)
            {
                routers[i].RefreshAllRouters(routers);
            }
            return true;
        }
        public int FindShotertPathLength(Router startRouter, Router destRouter)
        {
            int pathLength = 0;
            ShortestPath SPath = new ShortestPath();
            Dictionary<Router, int> shortestPaths = SPath.GetBetweenTwoRoutes(startRouter, destRouter, this);
            pathLength = shortestPaths[shortestPaths.Keys.ToArray()[0]];
            return pathLength;
        }
        public List<Router> FindShotertPath(Router startRouter, Router destRouter)
        {
            
            Dictionary<Router, int> shortestPaths = SPath.GetBetweenTwoRoutes(startRouter, destRouter, this);
            List<Router> routers = new List<Router>();
            for(int i = 0; i < shortestPaths.Count; i++)
            {
                routers.Add(shortestPaths.Keys.ToArray()[i]);
            }
            return routers;
        }
        public bool DeleteRouter(Router router)
        {
            if (routers.Contains(router))
            {
                routers.Remove(router);
                return true;
            }
            return false;
        }
        public bool DeleteRoute(Path route)
        {
            if (paths.Contains(route))
            {
                paths.Remove(route);
                return true;
            }
            return false;
        }
        public List<Path> GetPaths()
        {
            return paths;
        }
        public List<Router> GetRouters()
        {
            return routers;
        }
        public void GetDeletedMessage(string routerName)
        {
            if (sentMessagesWithCurrentName == 0)
            {
                for (int i = 0; i < routers.Count; i++)
                {
                    routers[i].sentMessageDeleted = false;
                }
            }
            Router deletingRouter;
            try
            {
                deletingRouter = routers.Find(item => item.Name == routerName);
            }
            catch (ArgumentNullException e)
            {
                deletingRouter = null;
            }
            if (deletingRouter != null)
            {
                routers.Remove(deletingRouter);
            }
            for(int i = 0; i < routers.Count; i++)
            {
                SendDeletedRouterMessage(routerName, routers[i]);
            }
        }
        public void SendDeletedRouterMessage(string routerName, Router router)
        {
            router.GetDeletedRouterName(routerName);
        }
    }
}
