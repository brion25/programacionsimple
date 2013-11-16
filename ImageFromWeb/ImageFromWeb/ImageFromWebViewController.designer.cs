// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace ImageFromWeb
{
	[Register ("ImageFromWebViewController")]
	partial class ImageFromWebViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIImageView imgImage { get; set; }

		[Action ("btnImg1:")]
		partial void btnImg1 (MonoTouch.Foundation.NSObject sender);
		partial void btnImg1 (MonoTouch.Foundation.NSObject sender){
			imgImage.Image=this.FromUrl("http://bilmoore.com/wp-content/uploads/2012/01/friends-tv-show-wallpapers-1280x1024.jpg");//When you click this button the Image view will download the image of Friends
		}

		[Action ("btnImg2:")]
		partial void btnImg2 (MonoTouch.Foundation.NSObject sender);
		partial void btnImg2 (MonoTouch.Foundation.NSObject sender){
			imgImage.Image=this.FromUrl("http://www.8music.es/wp-content/uploads/2012/01/nickelback-7016.jpg");//when you click this button the Image of Nickelback will be downloaded
		}

		[Action ("btnImg3:")]
		partial void btnImg3 (MonoTouch.Foundation.NSObject sender);
		partial void btnImg3 (MonoTouch.Foundation.NSObject sender){
			imgImage.Image=this.FromUrl("http://www.orgullobianconero.vavel.com/wp-content/uploads/2013/03/Il-futuro-di-Del-Piero.jpg");//and Finally if you click this button you will see the Image of Alessandro del Piero
		}

		void ReleaseDesignerOutlets ()
		{
			if (imgImage != null) {
				imgImage.Dispose ();
				imgImage = null;
			}
		}



	}
}
