using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DepthInCSharp
{

    class Program
    {        
        static void Main(string[] args)
        {


        
            Console.WriteLine(("a\b/c/d/e").Length.ToString());
            Console.Read();
        }
    }

    public class Node
    {
        public Object Element;
        public Node Link;
        public Node()
        {
            Element = null;
            Link = null;
        }

        public Node(object theElement)
        {
            Element = theElement;
            Link = null;
        }
    }

    public class LinkedList
    {
        protected Node header;
        public LinkedList()
        {
            header = new Node("header");
        }
    }
    
}
