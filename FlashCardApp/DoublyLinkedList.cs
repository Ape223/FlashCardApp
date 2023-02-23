using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using FlashCardApp;
using Microsoft.Identity.Client;

namespace FlashCardApp
{
    internal class DoublyLinkedList
    {
        private Node head;
        private Node last;
        public DoublyLinkedList()
        {
            head = new Node(null);
        }
        //Pushes a value into the first place of the list
        public void push(Flashcard f)
        {
            Node new_node = new Node(f);
            new_node.next = head;
            new_node.prev = null;

            if (head != null)
            {
                head.prev = new_node;
            }
            head = new_node;
        }
        //Adds a value to the last place of the list
        public void Queue(Flashcard f)
        {
            Node new_node = new Node(f);
            new_node.next = head;
            new_node.prev = findLast();
            findLast().next = new_node;
            head.prev = new_node;
        }
        public Node findLast()
        {
            Node cur = head;
            while (cur.next != null)
            {
                cur = cur.next;
            }
            return cur;
        }
    }
}
