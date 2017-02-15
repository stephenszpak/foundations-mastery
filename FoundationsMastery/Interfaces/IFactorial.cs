using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationsMastery.Interfaces
{
    interface IFactorial
    {
        //research what Factorial is...msdn has javascript formula
        //goes over numbers...look up what iterative and recursive mean
        int Iterative(int n); // good when n >= 1

        //ecample
        //public int Interative(int n)
        //{
        //    //Make a Enumerable up to n
        //    //or something else
        //    // then iterate over your enunumerable
        //    //maybe stash temp results
        //    //return some number
        //}
       

        //calls itself
        int Recursive(int n); // good when n >= 1

        //example
        //public int Recursive(int value)
        //{
        //    if(/*this makes the recursion stop*/)
        //    {
        //        /*return some number */
        //    }
        //    else
        //    {
        //        //Recursion Keeps Going
        //        return Recursive(/*mutate value and pass it into itself*/);
        //    }
        //}


    }
}
