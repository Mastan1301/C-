class Program2
{
    public static void Main1()
    {
        ProcessBusinessLogic2 bl = new ProcessBusinessLogic2();
        bl.ProcessCompleted += bl_ProcessCompleted;
        bl.StartProcess();
    }

    // Event handler
    public static void bl_ProcessCompleted(object sender, bool IsSuccessful)
    {
        Console.WriteLine("Process " + (IsSuccessful ? "Completed successfully" : "failed"));
    }
}

public class ProcessBusinessLogic2
{
    // declaring an event using built-in EventHandler
    public event EventHandler<bool> ProcessCompleted;

    public void StartProcess()
    {
        try
        {
            Console.WriteLine("Process started!");
            OnProcessCompleted(true);
        }
        catch(Exception ex)
        {
            OnProcessCompleted(false);
        }
    }

    protected virtual void OnProcessCompleted(bool IsSuccessful)
    {
        ProcessCompleted?.Invoke(this, IsSuccessful);
    }
}