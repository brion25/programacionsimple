using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using FlyoutNavigation;
using MonoTouch.Dialog;

namespace FlyoutComponent
{
	public partial class FlyoutComponentViewController : UIViewController
	{
		public FlyoutComponentViewController () : base ("FlyoutComponentViewController", null)
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
			var LateralBar = new FlyoutNavigationController {//this will create a new instance of the FlyoutComponent
				NavigationRoot = new RootElement("Menu"){ //Here we create the root of the alements
					new Section("Seccion 1"){//with this code we create Sections
						new StringElement("Header"),
						new StringElement("Controller 1"),//With this code we create the elements on the sections
						new StringElement("Controller 2"),
					},
					new Section("Seccion 2"){
						new StringElement("Controller 3"),
					},
				},
				ViewControllers =  new [] {//here we link Controllers to the elements on the sections
					new UIViewController{View=new UILabel{
							Text = "This is the header"
						}},// The flyout component needs an initializer, and this initializer always needs to be like this, with a new UIViewController{}
					new Controller1(),//here we create the instances for the Controllers
					new Controller2(),
					new Controller3(),
				}
			};

			LateralBar.ToggleMenu();
			View.AddSubview (LateralBar.View);

			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			// Return true for supported orientations
			return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
		}
	}
}

