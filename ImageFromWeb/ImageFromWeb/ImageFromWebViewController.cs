using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace ImageFromWeb
{
	public partial class ImageFromWebViewController : UIViewController
	{
		public ImageFromWebViewController () : base ("ImageFromWebViewController", null)
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
			
			// Perform any additional setup after loading the view, typically from a nib.
		}
		/*
		 * this method will download the Images from the web, so now you just need to pass the link on the variable uri
		 */
		UIImage FromUrl (string uri)
		{
			using (var url = new NSUrl (uri))//Here we convert our String into a URL
				using (var data = NSData.FromUrl (url))//Here we download the images of that URL
					return UIImage.LoadFromData (data);//and with this part of code you will return your new Image
		}
	}
}

