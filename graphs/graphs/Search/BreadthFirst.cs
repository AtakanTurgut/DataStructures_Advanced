using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graphs.Search
{
    public class BreadthFirst<T>
    {
        public bool Find(IGraph<T> graph, T vertexKey)
        {
            return bfs(graph.ReferenceVertex, new HashSet<T>(), vertexKey);
        }

        private bool bfs(IGraphVertex<T> referenceVertex, HashSet<T> visited, T searchVertexKey)
        {
            var queue = new Queue<IGraphVertex<T>>();
            queue.Enqueue(referenceVertex);

            visited.Add(referenceVertex.Key);

            Console.Write($"{referenceVertex.Key,-3}");

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();

                if (current.Key.Equals(searchVertexKey)) return true;

                foreach (var edge in current.Edges)
                {
                    if (visited.Contains(edge.TargetVertexKey)) continue;

                    visited.Add(edge.TargetVertexKey);

                    Console.Write($"{edge.TargetVertexKey,-3}");

                    queue.Enqueue(edge.TargetVertex);
                }
            }

            return false;
        }
    }
}
