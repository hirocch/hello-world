using System;

using AppKit;
using Foundation;

namespace helloworld
{
    public partial class ViewController : NSViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }

        /// <summary>
        /// Ons the click button.
        /// </summary>
        /// <param name="sender">Sender.</param>
		partial void OnClickButton(Foundation.NSObject sender)
        {
            _mLabel.StringValue = "ボタン押したょ！";
        }
	}
}
