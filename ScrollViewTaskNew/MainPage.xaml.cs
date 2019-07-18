using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ScrollViewTaskNew
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            ScrollTask scTask = new ScrollTask();
            var content = new StackLayout();
            var maindata=new Frame();
            for (int i = 0; i < 6; i++)
            {
                maindata=scTask.bindstackData(i);
                content.Spacing = 20;
                content.Children.Add(maindata);
            }
            mylayout.Content = content;
        }
    }
}
