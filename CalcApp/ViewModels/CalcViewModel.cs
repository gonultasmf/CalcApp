using CalcApp.ViewModels.Common;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Dangl.Calculator;
using System.Windows.Input;

namespace CalcApp.ViewModels;

public partial class CalcViewModel : BaseViewModel
{
    [ObservableProperty]
    private string? _formula;

    [ObservableProperty]
    private string? _result;

    [RelayCommand]
    public void Operation(string operation)
    {
        Formula += operation;
    }

    public ICommand ResetCommand => new Command(() =>
    {
        Formula = string.Empty;
        Result = "0";
    });

    public ICommand BackSpaceCommand => new Command(() =>
    {
        if (Formula?.Length > 0)
        {
            Formula = Formula.Substring(0, Formula.Length - 1);
        }
    });

    public ICommand CalculateCommand => new Command(() =>
    {
        if (Formula?.Length <= 0)
            return;

        var calculation = Calculator.Calculate(Formula);
        Result = calculation.Result.ToString();
    });
}
