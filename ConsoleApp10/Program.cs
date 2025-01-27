using System;

public interface ISelectable
{
    void OnSelect();
}
public interface IUpdatable
{
    void Refresh();
}
public class Screen : ISelectable, IUpdatable
{
    public void OnSelect()
    {
        Console.WriteLine("Screen has been selected.");
    }

    public void Refresh()
    {
        Console.WriteLine("Screen has been refreshed.");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Screen screen = new Screen();

        screen.OnSelect();
        screen.Refresh();
    }
}
