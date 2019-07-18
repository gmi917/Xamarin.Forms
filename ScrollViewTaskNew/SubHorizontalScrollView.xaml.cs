using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ScrollViewTaskNew
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SubHorizontalScrollView : ContentPage
	{
		public SubHorizontalScrollView ()
		{
			InitializeComponent ();
            for (var a = 0; a < 20; a++)
            {
                //var image = new Image();
                imageHorizontal.Source = ImageSource.FromResource("ScrollViewTaskNew.star_selected.png");
                //image.WidthRequest = 120;
                //image.HeightRequest = 70;
                //stackTopBrands.Children.Add(new Image { Source = "s1.jpg", WidthRequest = 120, HeightRequest = 70 });
                TapGestureRecognizer imageTap = new TapGestureRecognizer();
                imageTap.Tapped += ImageTap_Tapped;
                imageHorizontal.GestureRecognizers.Add(imageTap);
                //stackTopBrands.Children.Add(image);
            }
        }
        //public Image bindData()
        //{
        //    //var image= new Image();
        //    for (var a = 0; a < 20; a++)
        //    {                
        //        //var image = new Image();
        //        imageHorizontal.Source = "s1.jpg";
        //        //image.WidthRequest = 120;
        //        //image.HeightRequest = 70;
        //        //stackTopBrands.Children.Add(new Image { Source = "s1.jpg", WidthRequest = 120, HeightRequest = 70 });
        //        TapGestureRecognizer imageTap = new TapGestureRecognizer();
        //        imageTap.Tapped += ImageTap_Tapped;
        //        imageHorizontal.GestureRecognizers.Add(imageTap);
        //        //stackTopBrands.Children.Add(image);
        //    }
        //    return image;
        //}

        private void ImageTap_Tapped(object sender, EventArgs e)
        {
            Image imagetext = (Image)sender;
            DisplayAlert("message", imagetext.Source.ToString(), "ok");
        }
    }
}