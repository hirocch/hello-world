// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace helloworld
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
        AppKit.NSButton HelloButton { get; set; }

		[Outlet]
		AppKit.NSTextField HelloLabel { get; set; }

		[Action ("OnClickHelloButton:")]
		partial void OnClickHelloButton (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (HelloButton != null) {
				HelloButton.Dispose ();
				HelloButton = null;
			}

			if (HelloLabel != null) {
				HelloLabel.Dispose ();
				HelloLabel = null;
			}
		}
	}
}
