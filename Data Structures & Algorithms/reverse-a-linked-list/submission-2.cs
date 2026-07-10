/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
 
public class Solution {
       public ListNode ReverseList(ListNode? head)
    {
           if (head == null)
            return head;

        var tmp = head;
        List<int> nodes = new();
        while (tmp != null)
        {
            nodes.Add(tmp.val);
            tmp = tmp.next;
        }

        nodes.Reverse();
        var resultHead = new ListNode(nodes[0]);
        var tmpresult = resultHead;
        for (int i = 1; i < nodes.Count; i++)
        {
            tmpresult.next = new ListNode(nodes[i]);
            tmpresult = tmpresult.next;

        }

        return resultHead;
    }
}
