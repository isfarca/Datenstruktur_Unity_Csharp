using UnityEngine;

public class Node
{
    #region Declare variables

    public Node next;
    public int value;

    #endregion

    #region Constructs

    public Node()
    {
        next = null;
        value = 0;
    }

    public Node(int value)
    {
        next = null;
        this.value = value;
    }

    #endregion
}

public class List
{
    #region Declare variables

    private Node first;
    private Node last;
    private int count = 0;

    #endregion

    #region Custom functions

    #region Other auxilary functions

    public void Add(int param)
    {
        // Declare variables
        Node newNode = new Node() { value = param };

        if (first == null)
            first = newNode;
        else
        {
            last = first;

            while (last.next != null)
                last = last.next; // Find last element

            last.next = newNode; // Add element at end of list
        }

        count++;
    }

    public void GetLength()
    {
        Debug.LogFormat("The length from list is ' {0} '.", count);
    }

    public void Remove()
    {
        // Declare variables
        Node current = first;

        while (current.next != null)
        {
            // Find last element
            last = current;
            current = current.next; 
        }

        Debug.LogFormat("' {0} ' is removed.", last.next.value);
        last.next = null; // Remove element at end of list

        count--;
    }

    public void RemoveAt(int index)
    {
        // Declare variables
        int i = 0;
        Node current = first;
        Node previous = current;

        while (i <= index)
        {
            if (i == index)
            {
                previous.next = current.next;

                Debug.LogFormat("For the index ' {0} ' is ' {1} ' removed.", index, current.value);
                current = null;
            }
            else
            {
                previous = current;
                current = current.next;
            }

            i++;
        }

        count--;
    }

    public void PrintAllNodes()
    {
        // Declare variables
        Node current = first;

        while (current != null)
        {
            Debug.LogFormat("current.value: ' {0} '.", current.value);
            current = current.next;
        }
    }

    #endregion

    #endregion
}

public class Stack
{
    #region Declare variables

    private Node top;

    #endregion

    #region Custom functions

    #region Other auxilary functions

    public void Push(int param)
    {
        // Declare variables
        Node newNode = new Node(param);

        if (top == null)
            newNode.next = null;
        else
            newNode.next = top;

        top = newNode;
        Debug.LogFormat("' {0} ' pushed to stack.", param);
    }

    public void Pop()
    {
        if (top == null)
        {
            Debug.Log("Stack Underflow. Deletion not possible!");

            return;
        }

        Debug.LogFormat("Item popped is ' {0} '.", top.value);
        top = top.next;
    }

    public void Peek()
    {
        if (top == null)
        {
            Debug.Log("Stack Underflow!");

            return;
        }

        Debug.LogFormat("' {0} ' is on the top of stack.", top.value);
    }

    #endregion

    #endregion
}

public class Queue
{
    #region Declare variables

    private Node front;
    private Node rear;

    #endregion

    #region Custom functions 

    #region Other auxilary functions

    public void Enqueue(int param)
    {
        // Declare variables
        Node newNode = new Node(param);

        // If queue is empty, then new node is front and rear both.
        if (this.rear == null)
            this.front = this.rear = newNode;
        else
        {
            // Add the new node at the end of queue and change rear.
            this.rear.next = newNode;
            this.rear = newNode;
        }

        Debug.LogFormat("' {0} ' inserted into Queue.", param);
    }

    public void Dequeue()
    {
        // Declare variables
        Node temp;

        // If queue is empty, return NULL.
        if (this.front == null)
        {
            Debug.Log("The Queue is empty!");
            return;
        }

        // Store previous front and move front one node ahead.
        temp = this.front;
        this.front = this.front.next;

        // If front becomes NULL, then change rear also as NULL.
        if (this.front == null)
            this.rear = null;

        Debug.LogFormat("Item deleted is ' {0} '.", temp.value);
    }

    #endregion

    #endregion
}
