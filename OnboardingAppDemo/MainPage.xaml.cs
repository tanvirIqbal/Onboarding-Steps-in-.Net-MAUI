using OnboardingAppDemo.ViewModels;

namespace OnboardingAppDemo;

public partial class MainPage : ContentPage
{
	private readonly OnBoardingVM _onboardingVM;
	public MainPage()
	{
		InitializeComponent();
		_onboardingVM = new OnBoardingVM();
		BindingContext = _onboardingVM;
	}

    private void CarouselView_PositionChanged(object sender, PositionChangedEventArgs e)
    {
		_onboardingVM.IsLastStep = e.CurrentPosition == (_onboardingVM.OnboardingModels.Count - 1);
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {

    }

    private void Button_Pressed(object sender, EventArgs e)
    {

    }
}

