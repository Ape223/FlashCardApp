﻿using System;
using System.CodeDom.Compiler;
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
        private int count;
        public DoublyLinkedList()
        {   
            head = new Node(null);
            count = 0;
        }
        //Pushes a value into the first place of the list
        public void push(Flashcard f)
        {
            Node new_node = new Node(f);
            new_node.next = head;
            if (last != null)
            {
                new_node.prev = last;
            }
            else
            {
                new_node.prev = null;
            }
            if (head != null)
            {
                head.prev = new_node;
            }
            head = new_node;
            count++;
        }
        //Adds a value to the last place of the list
        public void Queue(Flashcard f)
        {
            if (count == 0)
            {
                head = new Node(f);
                head.next = head.prev = head;
            }
            else
            {
                Node new_node = new Node(f);
                new_node.next = head;
                new_node.prev = last;
                last.next = new_node;
                head.prev = new_node;
                last = new_node;
            }
            count++;
        }

        //Inserts a node after the specified one
        public void insert(Flashcard f, Node prev)
        {
            count++;
            Node new_node = new Node(f);
            if (last != null)
            {
                new_node.next = prev.next;
                prev.next = new_node;
                new_node.prev = prev;
                if (new_node.next != null)
                {
                    new_node.next.prev = new_node;
                }
                else
                {
                    MessageBox.Show("This node is the last node. Use a queue method here.");
                }
            }
            else
            {
                MessageBox.Show("The previous node is null. use the push method.");
            }
        }
        public Flashcard index(int index)
        {
            Node temp = head;
            for(int i = 0; i < index; i++)
            {
                temp = temp.next;
            }
            return temp.data;
        }
        public Node find(Flashcard f)
        {
            //Finds the node that belongs to flashcard f
            Node temp = head;
            while (temp.data != f)
            {
                temp = temp.next;
                if (temp == last && temp.data != f)
                {
                    return null;
                    MessageBox.Show("Node corresponding to flashcard not found.");
                }
            }
            return temp;
        }
        public void remove(Flashcard c)
        {
            //This will find the node that is associated with the flashcard f
            Node f = find(c);
            Node temp = f.prev;
            f.prev = f.next;
            f.next = temp;
        }
        public void RemoveByIndex(int index)
        {
            Node f = head;
            for (int i = 0; i<index; i++)
            {
                f = f.next;
            }
            Node temp = f.prev;
            f.prev = f.next;
            f.next = temp;

        }
        public int Count()
        {
            return count;
        }
        public void delAll()
        {
            Node current = head;
            while (current!= null)
            {
                Node nextNode = current.next;
                current.prev = null;
                current.next = null;
                current = nextNode;
            }
            count = 0;
            head = null;
            last = null;
        }
    }
}
