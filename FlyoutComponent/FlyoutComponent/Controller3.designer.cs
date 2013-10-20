// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace FlyoutComponent
{
	[Register ("Controller3")]
	partial class Controller3
	{
		[Outlet]
		MonoTouch.UIKit.UITextField txtField1 { get; set; }

		[Action ("btnClick:")]
		partial void btnClick (MonoTouch.Foundation.NSObject sender);
		partial void btnClick (MonoTouch.Foundation.NSObject sender){
			new UIAlertView("You Have Clicked me!!!", txtField1.Text
			                , null, "ok", null).Show();
		}

		void ReleaseDesignerOutlets ()
		{
			if (txtField1 != null) {
				txtField1.Dispose ();
				txtField1 = null;
			}
		}
	}
}
