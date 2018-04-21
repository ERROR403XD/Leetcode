
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Clone_Graph
    {
        public UndirectedGraphNode CloneGraph(UndirectedGraphNode node)
        {
            if (node == null) return null;
            UndirectedGraphNode res = new UndirectedGraphNode(node.label);
            UndirectedGraphNode current_old = node;
            UndirectedGraphNode current_new = res;
            List<UndirectedGraphNode> worklist_old = new List<UndirectedGraphNode>() { node};
            List<UndirectedGraphNode> worklist_new = new List<UndirectedGraphNode>() { res };
            Dictionary<int, UndirectedGraphNode> dic = new Dictionary<int, UndirectedGraphNode>();
            dic.Add(res.label, res);
            while(worklist_old.Count!=0)
            {
                current_old = worklist_old[0];
                current_new = worklist_new[0];
                worklist_old.RemoveAt(0);
                worklist_new.RemoveAt(0);
                foreach(UndirectedGraphNode neighbor in current_old.neighbors)
                {
                    if(neighbor==current_old)
                    {
                        current_new.neighbors.Add(current_new);
                        continue;
                    }
                    UndirectedGraphNode temp;
                    if (!dic.ContainsKey(neighbor.label))
                    {
                        temp = new UndirectedGraphNode(neighbor.label);
                        dic.Add(temp.label, temp);
                    }
                    else
                    {

                        temp = dic[neighbor.label];
                    }
                    current_new.neighbors.Add(temp);
                    temp.neighbors.Add(current_new);
                    worklist_old.Add(neighbor);
                    worklist_new.Add(temp);
                }
            }
            return res;
        }
    }
}
