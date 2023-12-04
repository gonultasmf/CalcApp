using CalcApp.Helpers;
using CalcApp.ViewModels.Common;

namespace CalcApp.Pages.Common;

public abstract class BasePage<TViewModel> : ContentPage where TViewModel : BaseViewModel
{
	protected BasePage(TViewModel viewModel) => base.BindingContext = viewModel;

	protected new TViewModel BindingContext => (TViewModel)base.BindingContext;

	public abstract void Build();

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
#if DEBUG
		HotReloadService.UpdateApplicationEvent += ReloadUI;
#endif
	}

    protected override void OnNavigatingFrom(NavigatingFromEventArgs args)
    {
        base.OnNavigatingFrom(args);
#if DEBUG
        HotReloadService.UpdateApplicationEvent += ReloadUI;
#endif
    }

    private void ReloadUI(Type[]? obj)
    {
        MainThread.BeginInvokeOnMainThread(() =>
        {
            Build();
        });
    }
}