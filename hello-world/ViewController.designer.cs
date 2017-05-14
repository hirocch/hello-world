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
		AppKit.NSButton _mButton { get; set; }

		[Outlet]
		AppKit.NSTextField _mLabel { get; set; }

		[Action ("OnClickButton:")]
		partial void OnClickButton (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (_mButton != null) {
				_mButton.Dispose ();
				_mButton = null;
			}

			if (_mLabel != null) {
				_mLabel.Dispose ();
				_mLabel = null;
			}
		}
	}
}
