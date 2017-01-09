using System;

using UIKit;

namespace czy
{
	public partial class ViewController : UIViewController
	{
		partial void clickInfoButton(UIButton sender)
		{
			var storyboard = this.Storyboard;
			var aboutViewController = (AboutViewController)
				storyboard.InstantiateViewController("AboutViewController");
			this.PresentViewController(aboutViewController, true, null);
		}

		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
