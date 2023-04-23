/*
 * An event can be declared in two steps:
1. Declare a delegate.
2. Declare a variable of the delegate with event keyword.
 * */

public delegate void Notify();

// Publisher class
public class ProcessBusinessLogic
{
    public event Notify ProcessCompleted;

    public void StartProcess()
    {
        Console.WriteLine("Process Started");
        OnProcessCompleted();
    }

    // Raises an event
    protected virtual void OnProcessCompleted()
    {
        ProcessCompleted?.Invoke();
    }
}


// Subscriber class
class Subscriber
{
    public static void Main1()
    {
        ProcessBusinessLogic bl = new ProcessBusinessLogic();
        bl.ProcessCompleted += bl_ProcessCompleted;
        bl.StartProcess();
    }

    // Event handler
    public static void bl_ProcessCompleted()
    {
        Console.WriteLine("Process Completed");
    }
}
