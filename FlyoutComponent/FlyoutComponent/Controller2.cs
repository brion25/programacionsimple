using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace FlyoutComponent
{
	public partial class Controller2 : UIViewController
	{
		public Controller2 () : base ("Controller2", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			imgController2.Image = UIImage.FromFile ("Logo2.0.png");//here when the controller loads, the Image View will load the picture
			// Perform any additional setup after loading the view, typically from a nib.
		}
	}
}

