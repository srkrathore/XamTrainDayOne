using System;

using Xamarin.Forms;

namespace XamTrainDayOne
{
	public class CodePage : ContentPage
	{
		public CodePage ()
		{
			Content = new StackLayout { 
				VerticalOptions = LayoutOptions.Center,
				Children = {
					new Label {
						HorizontalTextAlignment = TextAlignment.Center,
						Text = "Welcome to Xamarin Forms! & this is a Code Page Example"
					}
				}
			};
		}
	}
}


