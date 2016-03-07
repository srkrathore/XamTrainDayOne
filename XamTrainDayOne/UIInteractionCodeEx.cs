using System;
using Xamarin.Forms;

namespace XamTrainDayOne
{
	public class UIInteractionCodeEx : ContentPage
	{
		Label lblMessage;
		int iClickCount=0;
		public UIInteractionCodeEx ()
		{
			lblMessage = new Label ();
			Button btnExample = new Button{ Text = "Click Me"};
			btnExample.Clicked += OnButtonClick;
			var vMainStack = new StackLayout { 
				VerticalOptions = LayoutOptions.Center,
				Children = {
					new Label { Text = "UI Interaction Code example" },
					lblMessage, btnExample

				}
			};			
			Content = vMainStack;
		}

		public void OnButtonClick (object sender, EventArgs args){
			iClickCount++;
			lblMessage.Text = " You Clicked the button " + iClickCount.ToString() +" times";
		}
	}
}


