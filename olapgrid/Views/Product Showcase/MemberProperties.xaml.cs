#region Copyright Syncfusion Inc. 2001 - 2024
// Copyright Syncfusion Inc. 2001 - 2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

namespace syncfusion.olapgriddemos.wpf
{
    using syncfusion.demoscommon.wpf;
    using System.Windows.Controls;

    /// <summary>
    /// Interaction logic for MemberProperties.xaml
    /// </summary>
    public partial class MemberProperties : DemoControl
    {
        public MemberProperties()
        {
            InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            // Release all resources
            (this.DataContext as MemberPropertiesViewModel).Dispose();
            this.DataContext = null;
            if (this.olapgrid1 != null)
            {
                this.olapgrid1.Dispose();
                this.olapgrid1 = null;
            }
        }
    }
}
