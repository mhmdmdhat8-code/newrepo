using System;
using System.Collections.Generic;
using System.Text;

namespace asigment__1
{
    public class Book
    {
        public string title;
        public int page;
        public override string ToString()
        {
            return $"{title},{page}";
        }
    }
}
