using System;

using AppKit;
using Foundation;

namespace helloworld
{
    /// <summary>
    /// View controller.
    /// </summary>
    public partial class ViewController : NSViewController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:helloworld.ViewController"/> class.
        /// </summary>
        /// <param name="handle">Handle.</param>
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        /// <summary>
        /// Views the did load.
        /// </summary>
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
        }

        /// <summary>
        /// Gets or sets the represented object.
        /// </summary>
        /// <value>The represented object.</value>
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
        /// Ons the click hello button.
        /// </summary>
        /// <param name="sender">Sender.</param>
		partial void OnClickHelloButton(Foundation.NSObject sender)
        {
            HelloLabel.StringValue = "ボタン押したょ！";
        }
	}
}
