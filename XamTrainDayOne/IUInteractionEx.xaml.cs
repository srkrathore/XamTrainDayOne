using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamTrainDayOne
{
	public partial class UInteractionEx : ContentPage
	{
		int iClickCount = 0;
		public UInteractionEx ()
		{
			InitializeComponent ();
		}

		public void OnButtonClick (object sender, EventArgs args){
			iClickCount++;
			lblMessage.Text = " You Clicked the button " + iClickCount.ToString() +" times";
		}
	}
}

