using System.Collections.Generic;

namespace AppNumeroDaSorte;

public partial class MainPage : ContentPage
{
    public MainPage()
	{
		InitializeComponent();
	}

	private void OnGenerateLuckyNumbers(Object sender, EventArgs e)
	{
        AppName.IsVisible = false;
		ContainerLuckyNumbers.IsVisible = true;

		var set = GenerateLuckyNumbers();

		LuckyNumber01.Text = set.ElementAt(0).ToString("D2");
        LuckyNumber02.Text = set.ElementAt(1).ToString("D2");
        LuckyNumber03.Text = set.ElementAt(2).ToString("D2");
        LuckyNumber04.Text = set.ElementAt(3).ToString("D2");
        LuckyNumber05.Text = set.ElementAt(4).ToString("D2");
        LuckyNumber06.Text = set.ElementAt(5).ToString("D2");
    }

	private SortedSet<int> GenerateLuckyNumbers()
	{
        var set = new SortedSet<int>();

		while (set.Count < 6)
		{
			var random = new Random();
			var luckyNumber = random.Next(1, 60);

			set.Add(luckyNumber);
		}

		return set;
	}
}
