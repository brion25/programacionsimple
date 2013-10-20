// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using MonoTouch.UIKit;//this class will help us to create the Alerts
using System.CodeDom.Compiler;

namespace FlyoutComponent
{
	[Register ("Controller1")]
	partial class Controller1
	{
		[Action ("btnClick1:")]
		partial void btnClick1 (MonoTouch.Foundation.NSObject sender);
		partial void btnClick1 (MonoTouch.Foundation.NSObject sender){
			new UIAlertView("You Have Clicked me!!!", "Please share this post to your friends"
			                , null, "ok", null).Show();
		}//When you have clicked this button, a new Alert will Appear

		void ReleaseDesignerOutlets ()
		{
		}
	}
}
