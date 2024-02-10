// See https://aka.ms/new-console-template for more information
Solution solution = new();

int[][] edges={ new int[]{0, 1}, new int[]{1, 2}, new int[]{2, 3}, new int[]{1, 3}, new int[]{1, 4}};
Console.WriteLine(solution.ValidTree(5, edges));

class Solution
{
    /**
         * @param n: An integer
         * @param edges: a list of undirected edges
         * @return: true if it's a valid tree, or false
         */
    public bool ValidTree(int n, int[][] edges)
    {
        Dictionary<int, List<int>> adj = new();

        for (var i = 0; i < n; i++)
        {
            adj[i] = new();
            adj[i] = new();
        }

        foreach (int[] edge in edges)
        {
            adj[edge[0]].Add(edge[1]);
            adj[edge[1]].Add(edge[0]);
        }

        HashSet<int> visited = new();
        
        return Dfs(0,-1,adj,visited);
    }

    bool Dfs(int node, int prev, Dictionary<int, List<int>> adj, HashSet<int> visited)
    {
        if (visited.Contains(node))
        {
            return false;
        }
        
        visited.Add(node);

        for (int i = 0; i < adj[node].Count; i++)
        {
            if (prev == adj[node][i])
            {
                continue;
            }

            if (!Dfs(adj[node][i], node, adj, visited))
            {
                return false;
            }
        }

        return true;
    }
}