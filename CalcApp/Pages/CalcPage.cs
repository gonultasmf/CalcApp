using CalcApp.Pages.Common;
using CalcApp.ViewModels;

namespace CalcApp.Pages;

public class CalcPage : BasePage<CalcViewModel>
{
	public CalcPage(CalcViewModel calcView) : base(calcView)
	{
        Build();
	}

    public override void Build()
    {
        throw new NotImplementedException();
    }
}