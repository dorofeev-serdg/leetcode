namespace AddTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var list1 = new ListNode(2, new ListNode(4, new ListNode(3, null)));
            var list2 = new ListNode(5, new ListNode(6, new ListNode(4, null)));

            var result = Solution.AddTwoNumbers(list1, list2);
        }
    }
}

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var initSum = l1.val + l2.val;
        ListNode resultNode = new ListNode(initSum % 10);
        int move = initSum >= 10 ? 1 : 0;
        var currentNode = resultNode;

        while (l1?.next != null || l2?.next != null || move > 0)
        {
            int l1Value = l1?.next?.val ?? 0;
            int l2Value = l2?.next?.val ?? 0;

            int summ = l1Value + l2Value + move;
            int nextValue = summ % 10;
            move = summ == 20 ? 2 : summ >= 10 ? 1 : 0;

            var nextNode = new ListNode();
            nextNode.val = nextValue;
            currentNode.next = nextNode;
            currentNode = nextNode;

            l1 = l1?.next;
            l2 = l2?.next;
        }

        return resultNode;
    }
}