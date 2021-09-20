using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnblockMe.Models;

namespace UnblockMe.Services
{
    public class CircularBlockingVerifierService : ICircularBlockingVerifier
    {
        private readonly UnblockMeContext _dbContext;

        public CircularBlockingVerifierService(UnblockMeContext dbContext)
        {
            _dbContext = dbContext;
        }
        public bool VerifyBlocking(Tuple<string,string> edge)
        {
            var graph = new Dictionary<string, List<string>>();
            var recursionStack = new Dictionary<string, bool>();
            var viz = new Dictionary<string, bool>();
            foreach (var car in _dbContext.Cars)
            {
                graph.Add(car.LicensePlate, new List<string>());
                recursionStack.Add(car.LicensePlate, false);
                viz.Add(car.LicensePlate, false);
            }
            foreach (var car in _dbContext.Cars)
                if (car.BlocksCar != null)
                    graph[car.LicensePlate].Add(car.BlocksCar);
            graph[edge.Item1].Add(edge.Item2);

            foreach(var node in _dbContext.Cars)
                    if (isCycleInternal(node.LicensePlate,viz,recursionStack,graph))
                            return true;
            return false;
        }

        private bool isCycleInternal(string node, Dictionary<string, bool> viz, Dictionary<string, bool> recursionStack, Dictionary<string, List<string>> graph)
        {
            if(viz[node] == false)
            {
                viz[node] = recursionStack[node] = true;
                foreach (var nextNode in graph[node])
                    if (viz[nextNode] == false && isCycleInternal(nextNode, viz, recursionStack, graph))
                        return true;
                    else if (recursionStack[node])
                        return true;
                    
            }
            recursionStack[node] = false;  
            return false;
        }
    }
    public interface ICircularBlockingVerifier
    {
        public bool VerifyBlocking(Tuple<string, string> edge);
    }
}
