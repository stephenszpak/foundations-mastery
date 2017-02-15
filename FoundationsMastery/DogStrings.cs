using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoundationsMastery.Interfaces;

namespace FoundationsMastery
{
    public class DogStrings : ICustomString
    {
        public DogStrings(char[] inputArray)
        {
            this.Contents = inputArray;
        }

        public IEnumerable<char> Contents { get; set; }
            
        public int Length
        {
            get
            {
                return this.Contents.Count();
            }
        }

        public void Clear()
        {
            this.Contents = null;
        }

        public string Concat(IEnumerable<char> rhs)
        {
            string dogString = new string(Contents.ToArray()).ToString();
            return dogString + string.Join("", rhs);
        }

        public string Interleave(IEnumerable<char> rhs)
        {
            //string contentInput = new string(rhs.ToArray());
            string firstString = "";
            string secondString = "";
            int counter = 0;

            foreach(char Contents in firstString)
            {
                secondString = secondString.Insert(counter, Contents.ToString());
                counter = counter + 2;
            }
            return secondString;

        }

        public string Print()
        {
            throw new NotImplementedException();
        }
    }
}
