namespace P0002
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            if (l1 == null && l2 == null)
                return null;
            var current = l1 ?? l2;
            var other = current == l1 ? l2 : l1;
            var start = current;
            var end = current;

            var plusOne = false;
            while (current != null)
            {
                if (other != null)
                {
                    var val = current.val + other.val + (plusOne ? 1 : 0);
                    current.val = val % 10;
                    plusOne = val >= 10;
                    if (current.next == null)
                    {
                        current.next = other.next;
                        other = null;
                    }
                    else
                        other = other.next;
                }
                else
                {
                    var val = current.val + (plusOne ? 1 : 0);
                    current.val = val % 10;
                    plusOne = val >= 10;
                }
                end = current;
                current = current.next;
            }
            if (plusOne)
                end.next = new ListNode(1);
            return start;
        }
    }
}
