using CalcApp.Pages;

namespace CalcApp;

public class AppShell : Shell
{
    public AppShell(CalcPage calcPage)
    {
        Items.Add(calcPage);
    }
}
