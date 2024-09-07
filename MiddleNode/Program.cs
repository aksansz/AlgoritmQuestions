namespace MiddleNode{
    /*
    Given the head of a singly linked list, return the middle node of the linked list.
    If there are two middle nodes, return the second middle node.
    Example:
    Input: head = [1,2,3,4,5,6]
    Output: [4,5,6]
    Explanation: Since the list has two middle nodes with values 3 and 4, we return the second one.
    */
    public class Program
    {
        public static void Main(string[] args)
        {
            //Test Case 1:
            ListNode head1 = new ListNode(1);
            head1.next = new ListNode(2);
            head1.next.next = new ListNode(3);
            head1.next.next.next = new ListNode(4);
            head1.next.next.next.next = new ListNode(5);
            head1.next.next.next.next.next = new ListNode(6);
            MiddleNode_Solution1(head1);
            PrintLinkedList(MiddleNode_Solution2(head1));
            System.Console.WriteLine(MiddleNode_Solution1(head1).val);
        }
        public class ListNode {
            public int val;
            public ListNode next;
            public ListNode(int val=0, ListNode next=null) {
                this.val = val;
                this.next = next;
            }
        }
        public static ListNode MiddleNode_Solution1(ListNode head)
        {
            List<ListNode> list = new List<ListNode>();
            while(head != null)
            {
                list.Add(head);
                head = head.next;
            }
            return list[list.Count/2];
        }
        public static ListNode MiddleNode_Solution2(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;

            while(fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            return slow;
        }
        public static void PrintLinkedList(ListNode node)
        {
            while (node != null)
            {
                System.Console.Write(node.val + " ");
                node = node.next;
            }
            System.Console.WriteLine();
        }
    }
}