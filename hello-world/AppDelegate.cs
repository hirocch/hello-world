using AppKit;
using Foundation;

namespace helloworld
{
    /// <summary>
    /// App delegate.
    /// </summary>
    [Register("AppDelegate")]
    public class AppDelegate : NSApplicationDelegate
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:helloworld.AppDelegate"/> class.
        /// </summary>
        public AppDelegate()
        {
        }

        /// <summary>
        /// Dids the finish launching.
        /// </summary>
        /// <param name="notification">Notification.</param>
        public override void DidFinishLaunching(NSNotification notification)
        {
            // Insert code here to initialize your application
        }

        /// <summary>
        /// Wills the terminate.
        /// </summary>
        /// <param name="notification">Notification.</param>
        public override void WillTerminate(NSNotification notification)
        {
            // Insert code here to tear down your application
        }
    }
}
