using graphs.heaps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graphs.MinimumSpanningTree
{
    public class Prims<T, TW> where T : IComparable where TW : IComparable
    {
        public List<MSTEdge<T, TW>> FindMinimumSpanningTree(IGraph<T> graph)
        {
            var edges = new List<MSTEdge<T, TW>>();

            dfs(graph, 
                graph.ReferenceVertex, 
                new BinaryHeap<MSTEdge<T, TW>>(heaps.Shared.SortDirection.Ascending),
                new HashSet<T>(),
                edges);

            return edges;
        }

        private void dfs(IGraph<T> graph,
                 IGraphVertex<T> currentVertex,
                 BinaryHeap<MSTEdge<T, TW>> spNeighours,
                 HashSet<T> spVertices,
                 List<MSTEdge<T, TW>> spEdges)
        {
            while (true)
            {
                // edges
                foreach (var edge in currentVertex.Edges)
                {
                    // min-heap
                    spNeighours.Add(new MSTEdge<T, TW>(currentVertex.Key,
                        edge.TargetVertexKey,
                        edge.Weight<TW>()));
                }

                var minEdge = spNeighours.DeleteMinMax();

                // check the edges 
                while (spVertices.Contains(minEdge.Source) && spVertices.Contains(minEdge.Destination))
                {
                    minEdge = spNeighours.DeleteMinMax();

                    if (spNeighours.Count == 0) return;
                }

                // vertex tracking
                if (!spVertices.Contains(minEdge.Source))
                {
                    spVertices.Add(minEdge.Source);
                }

                spVertices.Add(minEdge.Destination);
                spEdges.Add(minEdge);

                currentVertex = graph.GetVertex(minEdge.Destination);
            }
        }
    }
}
