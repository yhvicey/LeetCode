﻿using P0007;

namespace Runner
{
    static class Program
    {

        //static ListNode CreateNode(int val)
        //    => new ListNode(val);

        //static ListNode CreateList(params int[] vals)
        //{
        //    if (vals.Length == 0) return null;
        //    var current = CreateNode(vals[0]);
        //    var start = current;
        //    for (var i = 1; i < vals.Length; i++)
        //    {
        //        current.next = CreateNode(vals[i]);
        //        current = current.next;
        //    }
        //    return start;
        //}

        static void Main(string[] args)
        {
            var sln = new Solution();


            var result = sln.Reverse(-0);
        }
    }
}
