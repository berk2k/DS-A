using System;

public class Node
{
    public int Data;
    public Node Next;

    public Node(int data)
    {
        this.Data = data;
        this.Next = null;
    }
}

public class LinkedList
{
    private Node head;

   
    public void InsertAtEnd(int data)
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            head = newNode;
            return;
        }

        Node temp = head;
        while (temp.Next != null)
        {
            temp = temp.Next;
        }
        temp.Next = newNode;
    }

    public void InsertAtBeginning(int data)
    {
        Node newNode = new Node(data);
        newNode.Next = head;
        head = newNode;
    }

    public void InsertAtPosition(int data, int position)
    {
        Node newNode = new Node(data);

        if (position == 0)
        {
            newNode.Next = head;
            head = newNode;
            return;
        }

        Node temp = head;
        int count = 0;

        while (temp != null && count < position - 1)
        {
            temp = temp.Next;
            count++;
        }

        if (temp == null)
        {
            Console.WriteLine("Position out of bounds.");
            return;
        }

        newNode.Next = temp.Next;
        temp.Next = newNode;
    }

    
    public void DeleteAtBeginning()
    {
        if (head == null)
        {
            Console.WriteLine("List is empty.");
            return;
        }
        head = head.Next;
    }

    public void DeleteAtEnd()
    {
        if (head == null)
        {
            Console.WriteLine("List is empty.");
            return;
        }

        if (head.Next == null)
        {
            head = null;
            return;
        }

        Node temp = head;
        while (temp.Next.Next != null)
        {
            temp = temp.Next;
        }
        temp.Next = null;
    }

    public void DeleteAtPosition(int position)
    {
        if (head == null)
        {
            Console.WriteLine("List is empty.");
            return;
        }

        if (position == 0)
        {
            head = head.Next;
            return;
        }

        Node temp = head;
        int count = 0;

        while (temp.Next != null && count < position - 1)
        {
            temp = temp.Next;
            count++;
        }

        if (temp.Next == null)
        {
            Console.WriteLine("Position out of bounds.");
            return;
        }

        temp.Next = temp.Next.Next;
    }

    
    public void Display()
    {
        Node temp = head;
        while (temp != null)
        {
            Console.Write(temp.Data + " -> ");
            temp = temp.Next;
        }
        Console.WriteLine("None");
    }
}
