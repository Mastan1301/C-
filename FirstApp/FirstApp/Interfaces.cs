interface IFile
{
    void ReadFile();
    void WriteFile(string text);
}

class File : IFile
{
    public void ReadFile()
    {
        Console.WriteLine("Reading file.");
    }

    public void WriteFile(string text)
    {
        Console.WriteLine("Writing text to file.");
    }
}