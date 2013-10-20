// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace FlyoutComponent
{
	[Register ("Controller2")]
	partial class Controller2
	{
		[Outlet]
		MonoTouch.UIKit.UIImageView imgController2 { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (imgController2 != null) {
				imgController2.Dispose ();
				imgController2 = null;
			}
		}
	}
}
