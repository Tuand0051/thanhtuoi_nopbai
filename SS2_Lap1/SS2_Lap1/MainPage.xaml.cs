using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Resources.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SS2_Lap1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void btnTranslate_Click(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            if (b!=null)
            {
                var context = new ResourceContext();
                var lang = ddlLang.SelectedValue;
                if (lang != null)
                {
                    var strlang = new List<string>();
                    strlang.Add(strlang.ToString());
                    context.Languages = strlang;
                    var rstring = ResourceManager.Current.MainResourceMap.GetSubtree("Resoures");
                    this.lblResult.Text = rstring.GetValue("UserDefined", context).ValueAsString;

                }
            }
        }
    }
}
