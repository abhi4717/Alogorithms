using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructuresAlgorithms.List
{
    class DoubleLinkedList
    {
        private DoubleLinkedList objPre;
        private DoubleLinkedList objNext;

        public string Element{ get; set; }
        public DoubleLinkedList Previous 
        {
            get
            {
                return objPre;
            }
            set
            {
                objPre = value;
            }
        }

        public DoubleLinkedList Next
        {
            get
            {
                return objNext;
            }
            set
            {
                objNext = value;
            }
        }

        public DoubleLinkedList(string strElement,DoubleLinkedList objNext, DoubleLinkedList objPrevious)
        {
            Element = strElement;
            Next = objNext;
            Previous = objPrevious;
        }
    }
}
