using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Copy_List_with_Random_Pointer
    {
        public RandomListNode CopyRandomList(RandomListNode head)
        {
            if (head == null) return null;
            RandomListNode current_old = head;
            RandomListNode start_new = new RandomListNode(head.label);
            RandomListNode current_new = start_new;
            Dictionary<RandomListNode, RandomListNode> dic = new Dictionary<RandomListNode, RandomListNode>();
            dic.Add(start_new, head);
            while(current_old!=null)
            {
                current_old = current_old.next;
                if(current_old!=null)
                {
                    current_new.next = new RandomListNode(current_old.label);
                    current_new = current_new.next;
                    dic.Add(current_old, current_new);
                }
            }
            current_new = start_new;
            current_old = head;
            while(current_old!=null)
            {
                current_new.random = dic[current_old.random];
                current_old = current_old.next;
                current_new = current_new.next;
            }
            return start_new;
        }
        public RandomListNode CopyRandomList_(RandomListNode head)
        {
            if (head == null) return null;
            RandomListNode current = head;
            while(current!=null)
            {
                RandomListNode temp = current.next;
                current.next = new RandomListNode(current.label);
                current.next.next = temp;
                current = temp;
            }
            current = head;
            RandomListNode res = head.next;
            while(current!=null)
            {
                if(current.random!=null)current.next.random = current.random.next;
                current = current.next.next;
            }
            current = head;
            while(current.next!=null)
            {
                RandomListNode temp = current.next;
                current.next = current.next.next;
                current = temp;
            }
            return res;
        }
    }
}
