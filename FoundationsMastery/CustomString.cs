﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoundationsMastery.Interfaces;

namespace FoundationsMastery
{
    public class CustomString
    {
        private char[] myChar;

        public CustomString()
        {

        }

        public CustomString(char[] myChar)
        {
            this.myChar = myChar;
        }

        public char[] RetrieveChars()
        {
            return myChar;
        }

        public string ConvertCharToString()
        {
            string convertedCharToString = new string(myChar);
            return convertedCharToString;
        }

        public virtual void Clear()
        {
            this.myChar = null;
        }
    }
}
