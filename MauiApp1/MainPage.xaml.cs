﻿namespace MauiApp1;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
    }
    private void OnCounterClicked(object sender, EventArgs e)
    {
        var viewHelper = DependencyService.Get<IViewHelper>();
        var rect = viewHelper.GetViewGlobalRectangle(CounterBtn);
    }
}

