using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCardApp
{
    internal class Node
    {
        public Flashcard data;
        public Node prev, next;

        public Node(Flashcard value)
        {
            this.data = value;
        }
    }
}
