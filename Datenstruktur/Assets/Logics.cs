using UnityEngine;

public class Logics : MonoBehaviour
{
    #region Main function "Start()"

    // Use this for initialization
    void Start()
    {
        // Declare variables
        List list = new List();
        Stack stack = new Stack();
        Queue queue = new Queue();

        Debug.Log("-----LIST-----");

        for (int i = 0; i < 5; i++)
            list.Add(Random.Range(0, 100));

        list.GetLength();
        list.PrintAllNodes();
        list.Remove();
        list.RemoveAt(2);

        Debug.Log("-----STACK-----");

        for (int i = 0; i < 5; i++)
            stack.Push(Random.Range(0, 100));

        stack.Pop();
        stack.Peek();

        Debug.Log("-----QUEUE-----");

        for (int i = 0; i <= 5; i++)
            queue.Enqueue(Random.Range(0, 100));

        queue.Dequeue();
    }

    #endregion
}