using Foundation;
using System;
using UIKit;
using InfColorPicker;

namespace InfColorPickerSample
{
    public partial class ViewController : UIViewController
    {
        ColorSelectedDelegate selector;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            ChangeColorButton.TouchUpInside += HandleTouchUpInsideWithStrongDelegate;
            selector = new ColorSelectedDelegate(this);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        private void HandleTouchUpInsideWithStrongDelegate(object sender, EventArgs e)
        {
            InfColorPickerController picker = InfColorPickerController.ColorPickerViewController;
            picker.Delegate = selector;
            picker.PresentModallyOverViewController(this);
        }
    }
}