using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    public static void Main()
    {
        //StoreGraphUsingAdjacencyMatrix();

        //StoreGraphUsingAdjacencyList();

        //graph 0->1,2  1->2,   2->0,3  3->3

        Graph grp = new Graph(4);
        //load data
        grp.vertexPaths[0].Add(1);
        grp.vertexPaths[0].Add(2);

        grp.vertexPaths[1].Add(2);

        grp.vertexPaths[2].Add(0);
        grp.vertexPaths[2].Add(3);

        grp.vertexPaths[3].Add(3);

        bool[] visited = new bool[4];

        Queue<int> verticesqueue = new Queue<int>();
        int startVertex = 3;
        Console.Write($"{startVertex}  ");
        verticesqueue.Enqueue(startVertex);
        visited[startVertex] = true;

        while (verticesqueue.Any())
        {
            int v = verticesqueue.Dequeue();

            foreach (var item in grp.vertexPaths[v])
            {
                if (!visited[item])
                {
                    Console.Write($"{item}   ");
                    verticesqueue.Enqueue(item);
                    visited[item] = true;
                }
            } 
        }
        Console.Read();


    }

    class Graph {
        public int VerticesCount;

        public Dictionary<int,List<int>> vertexPaths = new  Dictionary<int,List<int>>();

        public Graph(int v)
        {
            VerticesCount = v;
            for (int i = 0; i < v; i++)
            {
                vertexPaths.Add(i, new List<int>());
            }
        }


    }

    private static void StoreGraphUsingAdjacencyList()
    {
        //Load graph as adjacency matrix
        //0->1, 0->4, 1->4,1->3, 1->2,3->4,3->2

        int[][] adjList = new int[5][];

        adjList[0] = new int[2] { 1, 4 };
        adjList[1] = new int[4] { 0, 2, 3, 4 };
        adjList[2] = new int[2] { 1, 3 };
        adjList[3] = new int[3] { 1, 2, 4 };
        adjList[4] = new int[3] { 0, 1, 3 };

        for (int i = 0; i < adjList.GetLength(0); i++)
        {
            for (int j = 0; j < adjList.GetLength(0); j++)
            {
                bool exists = false;
                for (int k = 0; k < adjList[i].GetLength(0); k++)
                {

                    if (adjList[i][k] == j)
                    {
                        exists = true;
                        break;
                    }
                }
                Console.Write((exists ? "1" : "0") + "      ");
            }
            Console.WriteLine();
        }

        _ = Console.ReadLine();
    }

    private static void StoreGraphUsingAdjacencyMatrix()
    {
        //Load graph as adjacency matrix
        //0->1, 0->4, 1->4,1->3, 1->2,3->4,3->2

        int[,] graphStore = new int[5, 5];

        graphStore[0, 1] = 1;
        graphStore[0, 4] = 1;

        graphStore[1, 0] = 1;
        graphStore[1, 4] = 1;
        graphStore[1, 3] = 1;
        graphStore[1, 2] = 1;

        graphStore[2, 1] = 1;
        graphStore[2, 3] = 1;

        graphStore[3, 1] = 1;
        graphStore[3, 2] = 1;
        graphStore[3, 4] = 1;

        graphStore[4, 0] = 1;
        graphStore[4, 1] = 1;
        graphStore[4, 3] = 1;


        for (int i = 0; i < graphStore.GetLength(0); i++)
        {
            for (int j = 0; j < graphStore.GetLength(1); j++)
            {
                Console.Write($"{graphStore[i, j]}      ");
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }


}