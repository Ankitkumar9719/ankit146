using System;
using System.Collections.Generic;

// Q1: Generic Storage<T>
public class Storage<T>
{
    public T Item { get; set; }
}

// Q2: Generic Pair<T1, T2>
public class Pair<T1, T2>
{
    public T1 First { get; set; }
    public T2 Second { get; set; }

    public Pair(T1 first, T2 second)
    {
        First = first;
        Second = second;
    }

    public void PrintPair()
    {
        Console.WriteLine($"Pair: ({First}, {Second})");
    }
}

// Q3: Generic Calculator<T> with constraints
public class Calculator<T>
{
    public T Add(T a, T b)
    {
        return (dynamic)a + (dynamic)b;
    }

    public T Subtract(T a, T b)
    {
        return (dynamic)a - (dynamic)b;
    }

    public T Multiply(T a, T b)
    {
        return (dynamic)a * (dynamic)b;
    }

    public T Divide(T a, T b)
    {
        return (dynamic)a / (dynamic)b;
    }
}

// Q4: Generic Stack<T>
public class MyStack<T>
{
    private List<T> stack = new List<T>();

    public void Push(T item)
    {
        stack.Add(item);
    }

    public T Pop()
    {
        if (stack.Count == 0)
            throw new InvalidOperationException("Stack is empty.");
        T item = stack[stack.Count - 1];
        stack.RemoveAt(stack.Count - 1);
        return item;
    }

    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= stack.Count)
                throw new IndexOutOfRangeException();
            return stack[index];
        }
    }
}

// Q5: Generic Queue<T>
public class MyQueue<T>
{
    private List<T> queue = new List<T>();

    public void Enqueue(T item)
    {
        queue.Add(item);
    }

    public T Dequeue()
    {
        if (queue.Count == 0)
            throw new InvalidOperationException("Queue is empty.");
        T item = queue[0];
        queue.RemoveAt(0);
        return item;
    }

    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= queue.Count)
                throw new IndexOutOfRangeException();
            return queue[index];
        }
    }
}

// Main Program
public class Program
{
    public static void Main(string[] args)
    {
        // ---------- Q1: Storage<T> ----------
        Console.WriteLine("=== Q1: Storage<T> ===");
        Storage<int> intStorage = new Storage<int> { Item = 42 };
        Storage<string> stringStorage = new Storage<string> { Item = "Hello Generics" };
        Storage<double> doubleStorage = new Storage<double> { Item = 99.99 };

        Console.WriteLine($"Integer Storage: {intStorage.Item}");
        Console.WriteLine($"String Storage: {stringStorage.Item}");
        Console.WriteLine($"Double Storage: {doubleStorage.Item}\n");

        // ---------- Q2: Pair<T1, T2> ----------
        Console.WriteLine("=== Q2: Pair<T1, T2> ===");
        Pair<int, string> pair1 = new Pair<int, string>(1, "One");
        Pair<string, double> pair2 = new Pair<string, double>("Pi", 3.14159);

        pair1.PrintPair();
        pair2.PrintPair();
        Console.WriteLine();

        // ---------- Q3: Calculator<T> ----------
        Console.WriteLine("=== Q3: Calculator<T> ===");
        Calculator<int> intCalc = new Calculator<int>();
        Calculator<double> doubleCalc = new Calculator<double>();

        Console.WriteLine($"Int Add: {intCalc.Add(10, 5)}");
        Console.WriteLine($"Int Subtract: {intCalc.Subtract(10, 5)}");
        Console.WriteLine($"Double Multiply: {doubleCalc.Multiply(2.5, 4.2)}");
        Console.WriteLine($"Double Divide: {doubleCalc.Divide(10.0, 2.0)}\n");

        // ---------- Q4: Stack<T> ----------
        Console.WriteLine("=== Q4: MyStack<T> ===");
        MyStack<string> stack = new MyStack<string>();
        stack.Push("First");
        stack.Push("Second");
        stack.Push("Third");

        Console.WriteLine($"Element at index 0 (bottom): {stack[0]}");
        Console.WriteLine($"Element at index 2 (top): {stack[2]}");
        Console.WriteLine($"Popped element: {stack.Pop()}\n");

        // ---------- Q5: Queue<T> ----------
        Console.WriteLine("=== Q5: MyQueue<T> ===");
        MyQueue<int> queue = new MyQueue<int>();
        queue.Enqueue(100);
        queue.Enqueue(200);
        queue.Enqueue(300);

        Console.WriteLine($"Element at index 0 (front): {queue[0]}");
        Console.WriteLine($"Element at index 2 (rear): {queue[2]}");
        Console.WriteLine($"Dequeued element: {queue.Dequeue()}");
        Console.WriteLine("\nDeveloped by: Aryansh Chaudhary (11)");
    }
}