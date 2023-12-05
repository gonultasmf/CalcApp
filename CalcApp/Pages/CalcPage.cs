using CalcApp.Pages.Common;
using CalcApp.Resources;
using CalcApp.ViewModels;
using CommunityToolkit.Maui.Markup;
using static CommunityToolkit.Maui.Markup.GridRowsColumns;

namespace CalcApp.Pages;

public class CalcPage : BasePage<CalcViewModel>
{
	public CalcPage(CalcViewModel calcView) : base(calcView)
	{
        Build();
	}

    public override void Build()
    {
        Content = new Grid
        {
            RowDefinitions = Rows.Define(Stars(3), Stars(2), Stars(5)),
            BackgroundColor = Colors.Orange,

            Children =
            {
                new Label()
                    .Text("My CALCULATER", Colors.Red)
                    .Font(size:40, bold: true)
                    .Center()
                    .Row(0),

                new VerticalStackLayout
                {
                    Children =
                    {
                        new Frame
                        {
                            Content = new Label()
                                            .Style(Styles.FormulaLabelStyle)
                                            .Bind(Label.TextProperty,
                                                    static (CalcViewModel vm) => vm.Formula)
                        }
                        .Style(Styles.FormulaFrameStyle)
                        .Margin(10,0),

                        new Frame
                        {
                            Content = new Label()
                                            .End()
                                            .Style(Styles.ResultLabelStyle)
                                            .Bind(Label.TextProperty,
                                                    static (CalcViewModel vm) => vm.Result)
                        }
                        .Style(Styles.ResultFrameStyle)
                        .Margin(10)
                    }
                }
                .Row(1)
                .Bottom(),

                new Grid
                {
                    new BoxView()
                        .Style(Styles.BoxViewStyle),

                    new Grid
                    {
                        RowSpacing = 15,
                        ColumnSpacing = 15,
                        RowDefinitions = Rows.Define(GridLength.Star,
                                                     GridLength.Star,
                                                     GridLength.Star,
                                                     GridLength.Star,
                                                     GridLength.Star),
                        ColumnDefinitions = Columns.Define(GridLength.Star,
                                                           GridLength.Star,
                                                           GridLength.Star,
                                                           GridLength.Star),

                        Children =
                        {
                            #region ROW 0
                            new Button()
                                .Text("AC")
                                .Row(0)
                                .Column(0)
                                .Style(Styles.YellowButtonStyle)
                                .BindCommand(static (CalcViewModel vm) => vm.ResetCommand),

                            new Button()
                                .Text("⌫")
                                .Row(0)
                                .Column(1)
                                .Style(Styles.YellowButtonStyle)
                                .BindCommand(static (CalcViewModel vm) => vm.BackSpaceCommand),

                            new Button()
                                .Text("%")
                                .Row(0)
                                .Column(2)
                                .Style(Styles.RedButtonStyle)
                                .BindCommand(static (CalcViewModel vm) => vm.OperationCommand)
                                .Bind(Button.CommandParameterProperty, source: "%"),

                            new Button()
                                .Text("/")
                                .Row(0)
                                .Column(3)
                                .Style(Styles.RedButtonStyle)
                                .BindCommand(static (CalcViewModel vm) => vm.OperationCommand)
                                .Bind(Button.CommandParameterProperty, source: "/"),
	                        #endregion

                            #region ROW 1
                            new Button()
                                .Text("7")
                                .Row(1)
                                .Column(0)
                                .Style(Styles.NormalButtonStyle)
                                .BindCommand(static (CalcViewModel vm) => vm.OperationCommand)
                                .Bind(Button.CommandParameterProperty, source: "7"),

                            new Button()
                                .Text("8")
                                .Row(1)
                                .Column(1)
                                .Style(Styles.NormalButtonStyle)
                                .BindCommand(static (CalcViewModel vm) => vm.OperationCommand)
                                .Bind(Button.CommandParameterProperty, source: "8"),

                            new Button()
                                .Text("9")
                                .Row(1)
                                .Column(2)
                                .Style(Styles.NormalButtonStyle)
                                .BindCommand(static (CalcViewModel vm) => vm.OperationCommand)
                                .Bind(Button.CommandParameterProperty, source: "9"),

                            new Button()
                                .Text("*")
                                .Row(1)
                                .Column(3)
                                .Style(Styles.RedButtonStyle)
                                .BindCommand(static (CalcViewModel vm) => vm.OperationCommand)
                                .Bind(Button.CommandParameterProperty, source: "*"),
	                        #endregion
                            
                            #region ROW 2
                            new Button()
                                .Text("4")
                                .Row(2)
                                .Column(0)
                                .Style(Styles.NormalButtonStyle)
                                .BindCommand(static (CalcViewModel vm) => vm.OperationCommand)
                                .Bind(Button.CommandParameterProperty, source: "4"),

                            new Button()
                                .Text("5")
                                .Row(2)
                                .Column(1)
                                .Style(Styles.NormalButtonStyle)
                                .BindCommand(static (CalcViewModel vm) => vm.OperationCommand)
                                .Bind(Button.CommandParameterProperty, source: "5"),

                            new Button()
                                .Text("6")
                                .Row(2)
                                .Column(2)
                                .Style(Styles.NormalButtonStyle)
                                .BindCommand(static (CalcViewModel vm) => vm.OperationCommand)
                                .Bind(Button.CommandParameterProperty, source: "6"),

                            new Button()
                                .Text("-")
                                .Row(2)
                                .Column(3)
                                .Style(Styles.RedButtonStyle)
                                .BindCommand(static (CalcViewModel vm) => vm.OperationCommand)
                                .Bind(Button.CommandParameterProperty, source: "-"),
                            #endregion

                            #region ROW 3
                            new Button()
                                .Text("1")
                                .Row(3)
                                .Column(0)
                                .Style(Styles.NormalButtonStyle)
                                .BindCommand(static (CalcViewModel vm) => vm.OperationCommand)
                                .Bind(Button.CommandParameterProperty, source: "1"),

                            new Button()
                                .Text("2")
                                .Row(3)
                                .Column(1)
                                .Style(Styles.NormalButtonStyle)
                                .BindCommand(static (CalcViewModel vm) => vm.OperationCommand)
                                .Bind(Button.CommandParameterProperty, source: "2"),

                            new Button()
                                .Text("3")
                                .Row(3)
                                .Column(2)
                                .Style(Styles.NormalButtonStyle)
                                .BindCommand(static (CalcViewModel vm) => vm.OperationCommand)
                                .Bind(Button.CommandParameterProperty, source: "3"),

                            new Button()
                                .Text("+")
                                .Row(3)
                                .Column(3)
                                .Style(Styles.RedButtonStyle)
                                .BindCommand(static (CalcViewModel vm) => vm.OperationCommand)
                                .Bind(Button.CommandParameterProperty, source: "+"),
	                        #endregion

                            #region ROW 4
                            new Button()
                                .Text("0")
                                .Row(4)
                                .Column(0)
                                .ColumnSpan(2)
                                .Style(Styles.NormalButtonStyle)
                                .BindCommand(static (CalcViewModel vm) => vm.OperationCommand)
                                .Bind(Button.CommandParameterProperty, source: "0"),

                            new Button()
                                .Text(".")
                                .Row(4)
                                .Column(2)
                                .Style(Styles.NormalButtonStyle)
                                .BindCommand(static (CalcViewModel vm) => vm.OperationCommand)
                                .Bind(Button.CommandParameterProperty, source: "."),


                            new Button()
                                .Text("=")
                                .Row(4)
                                .Column(3)
                                .Style(Styles.RedButtonStyle)
                                .BindCommand(static (CalcViewModel vm) => vm.CalculateCommand),
	                        #endregion
                        }
                    }
                    .Padding(15)
                }
                .Row(2)
                .Margins(0,10,0,0)
            }
        }
        .Fill();
    }
}