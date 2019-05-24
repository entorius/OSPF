using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Laboratorinis_OSPFWinForm
{
    public class ShortestPath
    {
        List<Router> routers;
        bool[] visited;
        Dictionary<Router, int> shortestPaths;
        List<Network.Path> paths;
        Router[,] routersPath;
        List<Router> finalRoute;
        public Dictionary<Router, int> SPDijkstra(Router startRouter, Network network)
        {

            shortestPaths = new Dictionary<Router, int>();
            paths = new List<Network.Path>();
            paths = network.GetPaths();
            routers = new List<Router>();
            routers = network.GetRouters();
            routersPath = SetDoubleDimensionRouterToNull(routers.Count, routers.Count);
            finalRoute = new List<Router>();
            visited = new bool[routers.Count];
            bool ending = false;
            int lengthToCurrentRouter;
            int lengthCurrent;
            int lengthToNext;
            int memberNumber = 0;
            for (int i = 0; i < routers.Count; i++)
            {
                if (routers[i] == startRouter)
                {
                    shortestPaths.Add(routers[i], 0);
                }
                else
                {
                    shortestPaths.Add(routers[i], int.MaxValue);
                }
                visited[i] = false;
            }
            shortestPaths = SortDictionary(shortestPaths);
            while (!ending)
            {
                int CurrentRoutePathMember = 0;
                
                Router currentRouter = shortestPaths.Keys.ToArray<Router>()[memberNumber];
                for (int i = 0; i < paths.Count; i++)
                {
                    Router firstRouter = paths[i].GetFirstRouter();
                    Router secondRouter = paths[i].GetSecondRouter();
                    if (paths[i].EqualsFirstRouter(currentRouter))
                    {
                       
                        if (!HasBeenVisited(secondRouter))
                        {
                            shortestPaths.TryGetValue(secondRouter, out lengthCurrent);
                            shortestPaths.TryGetValue(currentRouter, out lengthToCurrentRouter);
                            lengthToNext = paths[i].getCost();
                            int cost = lengthToNext + lengthToCurrentRouter;
                            if (cost < lengthCurrent)
                            {
                                shortestPaths.Remove(secondRouter);
                                shortestPaths.Add(secondRouter, lengthToCurrentRouter + lengthToNext);
                                shortestPaths = SortDictionary(shortestPaths);
                                routersPath[memberNumber, CurrentRoutePathMember] = secondRouter;
                                CurrentRoutePathMember++;
                            }
                        }
                    }
                    else if (paths[i].EqualsSecondRouter(currentRouter))
                    {
                        if (!HasBeenVisited(firstRouter))
                        {
                            shortestPaths.TryGetValue(firstRouter, out lengthCurrent);
                            shortestPaths.TryGetValue(currentRouter, out lengthToCurrentRouter);
                            lengthToNext = paths[i].getCost();
                            int cost = lengthToNext + lengthToCurrentRouter;
                            if (cost < lengthCurrent)
                            {
                                shortestPaths.Remove(firstRouter);
                                shortestPaths.Add(firstRouter, lengthToCurrentRouter + lengthToNext);
                                shortestPaths = SortDictionary(shortestPaths);
                                routersPath[memberNumber, CurrentRoutePathMember] = firstRouter;
                                CurrentRoutePathMember++;
                            }
                        }
                    }
                }
                CheckVisited(currentRouter);
                if (memberNumber + 1 == shortestPaths.Count)
                {
                    ending = true;
                }
                shortestPaths = SortDictionary(shortestPaths);
                memberNumber = memberNumber + 1;

            }
            return shortestPaths;
        }
        private Dictionary<Router, int> SortDictionary(Dictionary<Router, int> currentDictionary)
        {
            var sortedDictionary = currentDictionary.OrderBy(length => length.Value);
            return sortedDictionary.ToDictionary(pair => pair.Key, pair => pair.Value);
        }
        private Router[,] SetDoubleDimensionRouterToNull(int length1Dimension, int length2Dimension)
        {
            Router[,] routers = new Router[length1Dimension, length2Dimension];
            for (int i = 0; i < length1Dimension; i++)
            {
                for (int j = 0; j < length2Dimension; j++)
                {
                    routers[i, j] = null;
                }
            }
            return routers;
        }
        private void CheckVisited(Router router)
        {
            for (int i = 0; i < routers.Count; i++)
            {
                if (router.Equals(routers[i]))
                {
                    visited[i] = true;
                }
            }
        }
        private bool HasBeenVisited(Router router)
        {
            for (int i = 0; i < routers.Count; i++)
            {
                if (router.Equals(routers[i]) && visited[i])
                {
                    return true;
                }
            }
            return false;
        }
        public Dictionary<Router, int> GetBetweenTwoRoutes(Router startRouter, Router destRouter, Network network)
        {
            Dictionary<Router, int> shortestPaths = SPDijkstra(startRouter,network);

            if(shortestPaths.TryGetValue(destRouter,out int value1)) 
            {
                int shortestPathValue;
                Router neededRouter = destRouter;
                shortestPaths.TryGetValue(destRouter, out shortestPathValue);
                for (int i = routers.Count - 1; i >= 0; i--)
                {
                    for (int j = 0; j<routers.Count; j++)
                    {
                        if (routersPath[i, j] == null)
                        {
                            j = routers.Count-1;
                        }
                        if (neededRouter == startRouter)
                        {
                            i = 0;
                        }
                        if (routersPath[i, j] == neededRouter)
                        {
                            finalRoute.Add(routersPath[i, j]);
                            neededRouter = shortestPaths.Keys.ToArray<Router>()[i];
                            j = routers.Count-1;
                        }
                    }
                }
                Dictionary<Router, int> finalDictionary = new Dictionary<Router, int>();
                for (int i = 0; i<finalRoute.Count; i++)
                {
                    int value;
                    shortestPaths.TryGetValue(finalRoute[i], out value);
                    finalDictionary.Add(finalRoute[i], value);
                }
                shortestPaths.TryGetValue(startRouter, out int valueDest);
                finalDictionary.Add(startRouter, valueDest);
                return finalDictionary;
            }
            else
            {
                return new Dictionary<Router, int>();
            }
        }
    }
}
