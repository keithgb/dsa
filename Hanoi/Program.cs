using System;
using System.Collections.Generic;

namespace Hanoi
{

    class Program
    {
        /*
         * Goal: Move n disks from src to dest
         * 
         * 
         */

        static void Main(string[] args)
        {

            var src = new Stack<int>();
            var dest = new Stack<int>();
            var aux = new Stack<int>();
            src.Push(2);
            src.Push(1);
            src.Push(0);

            Hanoi(3, src, dest, aux);
        }

        private static void Hanoi(
            int discs,
            Stack<int> src,
            Stack<int> dest,
            Stack<int> aux)
        {
            //Base condition stop calling if disc = 0;
            if (discs == 0) { return; }

            Hanoi(discs - 1, src, aux, dest); // move n-1 from src to aux
            dest.Push(src.Pop());   //move from src to dest
            Hanoi(discs - 1, aux, dest, src);  //move n-1 from aux to dest
        }
    }
}
