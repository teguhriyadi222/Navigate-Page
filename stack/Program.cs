

namespace page;

class Program 
{
    static void Main()
    {
        Navigation stack = new Navigation();
        string massage;

        massage = stack.NavigationTo(Page.Home);
        Console.WriteLine(massage);

        massage = stack.NavigationTo(Page.Galeries);
        Console.WriteLine(massage);

        massage = stack.NavigationTo(Page.Settings);
        Console.WriteLine(massage);

        massage = stack.NavigationBack();
        Console.WriteLine(massage);

        massage = stack.NavigationBack();
        Console.WriteLine(massage);

        massage = stack.NavigationBack();
        Console.WriteLine(massage);
    }
}