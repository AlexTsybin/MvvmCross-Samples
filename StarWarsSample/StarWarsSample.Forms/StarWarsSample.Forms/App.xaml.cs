using MvvmCross.Forms.Core;
using Xamarin.Forms;

namespace StarWarsSample.Forms
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();
		}

		protected override void OnStart ()
		{
            base.OnStart();
		}

		protected override void OnSleep ()
		{
            base.OnSleep();
		}

		protected override void OnResume ()
		{
            base.OnResume();
		}
	}
}
