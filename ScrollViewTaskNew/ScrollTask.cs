using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ScrollViewTaskNew
{
	public class ScrollTask : ContentPage
	{
		public ScrollTask ()
		{
            // Recommended Products Stack

            StackLayout stackRecommendedProducts = new StackLayout();
            stackRecommendedProducts.Orientation = StackOrientation.Horizontal;
            stackRecommendedProducts.HeightRequest = 150;
            stackRecommendedProducts.Children.Add(new Image { Source = "s1.jpg", WidthRequest = 120, HeightRequest = 70 });
            stackRecommendedProducts.Children.Add(new Image { Source = "Samsung.png", WidthRequest = 120, HeightRequest = 70 });
            stackRecommendedProducts.Children.Add(new Image { Source = "s1.jpg", WidthRequest = 120, HeightRequest = 70 });
            stackRecommendedProducts.Children.Add(new Image { Source = "Samsung.png", WidthRequest = 120, HeightRequest = 70 });
            stackRecommendedProducts.Children.Add(new Image { Source = "s1.jpg", WidthRequest = 120, HeightRequest = 70 });
            stackRecommendedProducts.Children.Add(new Image { Source = "Samsung.png", WidthRequest = 120, HeightRequest = 70 });
            stackRecommendedProducts.Children.Add(new Image { Source = "s1.jpg", WidthRequest = 120, HeightRequest = 70 });
            stackRecommendedProducts.Children.Add(new Image { Source = "Samsung.png", WidthRequest = 120, HeightRequest = 70 });
            stackRecommendedProducts.Children.Add(new Image { Source = "s1.jpg", WidthRequest = 120, HeightRequest = 70 });
            stackRecommendedProducts.Children.Add(new Image { Source = "Samsung.png", WidthRequest = 120, HeightRequest = 70 });
            stackRecommendedProducts.Children.Add(new Image { Source = "s1.jpg", WidthRequest = 120, HeightRequest = 70 });
            stackRecommendedProducts.Children.Add(new Image { Source = "Samsung.png", WidthRequest = 120, HeightRequest = 70 });
            stackRecommendedProducts.Children.Add(new Image { Source = "s1.jpg", WidthRequest = 120, HeightRequest = 70 });
            stackRecommendedProducts.Children.Add(new Image { Source = "Samsung.png", WidthRequest = 120, HeightRequest = 70 });
            stackRecommendedProducts.Children.Add(new Image { Source = "s1.jpg", WidthRequest = 120, HeightRequest = 70 });
            stackRecommendedProducts.Children.Add(new Image { Source = "Samsung.png", WidthRequest = 120, HeightRequest = 70 });
            stackRecommendedProducts.Children.Add(new Image { Source = "s1.jpg", WidthRequest = 120, HeightRequest = 70 });
            stackRecommendedProducts.Children.Add(new Image { Source = "Samsung.png", WidthRequest = 120, HeightRequest = 70 });
            stackRecommendedProducts.Children.Add(new Image { Source = "s1.jpg", WidthRequest = 120, HeightRequest = 70 });
            stackRecommendedProducts.Children.Add(new Image { Source = "Samsung.png", WidthRequest = 120, HeightRequest = 70 });
            stackRecommendedProducts.Children.Add(new Image { Source = "s1.jpg", WidthRequest = 120, HeightRequest = 70 });
            stackRecommendedProducts.Children.Add(new Image { Source = "Samsung.png", WidthRequest = 120, HeightRequest = 70 });
            stackRecommendedProducts.Children.Add(new Image { Source = "s1.jpg", WidthRequest = 120, HeightRequest = 70 });
            stackRecommendedProducts.Children.Add(new Image { Source = "Samsung.png", WidthRequest = 120, HeightRequest = 70 });

            // Scroll view for RecommendedProducts

            ScrollView scrollviewRecommendedProducts = new ScrollView
            {
                HorizontalOptions = LayoutOptions.Fill,
                Orientation = ScrollOrientation.Horizontal,
                Content = stackRecommendedProducts
            };

            // Featured Offers Stack

            StackLayout stackFeaturedOffers = new StackLayout();
            stackFeaturedOffers.Orientation = StackOrientation.Horizontal;
            stackFeaturedOffers.HeightRequest = 150;

            for (var j = 0; j < 20; j++)
            {
                stackFeaturedOffers.Children.Add(new Image { Source = "s1.jpg", WidthRequest = 120, HeightRequest = 70 });
            }

            // Scroll view for Featured Offers

            ScrollView scrollviewFeaturedOffers = new ScrollView
            {
                HorizontalOptions = LayoutOptions.Fill,
                Orientation = ScrollOrientation.Horizontal,
                Content = stackFeaturedOffers

            };

            //FeaturedCategories stack

            StackLayout stackFeaturedCategories = new StackLayout();
            stackFeaturedCategories.Orientation = StackOrientation.Horizontal;
            stackFeaturedCategories.HeightRequest = 150;

            for (var k = 0; k < 20; k++)
            {
                stackFeaturedCategories.Children.Add(new Image { Source = "s1.jpg", WidthRequest = 120, HeightRequest = 70 });
            }

            // Scroll view for FeaturedCategories

            ScrollView scrollviewFeaturedCategories = new ScrollView
            {
                HorizontalOptions = LayoutOptions.Fill,
                Orientation = ScrollOrientation.Horizontal,
                Content = stackFeaturedCategories
            };

            //Stack for Top Brands

            StackLayout stackTopBrands = new StackLayout();
            stackTopBrands.Orientation = StackOrientation.Horizontal;
            stackTopBrands.HeightRequest = 150;

            for (var a = 0; a < 20; a++)
            {
                var image = new Image();
                image.Source = ImageSource.FromResource("ScrollViewTaskNew.star_selected.png");
                image.WidthRequest = 120;
                image.HeightRequest = 70;
                //stackTopBrands.Children.Add(new Image { Source = "s1.jpg", WidthRequest = 120, HeightRequest = 70 });
                TapGestureRecognizer imageTap = new TapGestureRecognizer();
                imageTap.Tapped += ImageTap_Tapped;
                image.GestureRecognizers.Add(imageTap);
                stackTopBrands.Children.Add(image);
            }

            //Scroll View For top brands

            ScrollView scrollviewTopBrands = new ScrollView
            {
                HorizontalOptions = LayoutOptions.Fill,
                Orientation = ScrollOrientation.Horizontal,
                Content = stackTopBrands
            };

            //StackLayout For imge banner

            StackLayout imgbannerStack = new StackLayout();
            imgbannerStack.Orientation = StackOrientation.Horizontal;
            imgbannerStack.Children.Add(new Image { Source = "offer.jpg", Aspect = Aspect.Fill, WidthRequest = base.WidthRequest, HeightRequest = 150 });
            imgbannerStack.Children.Add(new Image { Source = "offer1.jpg", Aspect = Aspect.Fill, WidthRequest = base.WidthRequest, HeightRequest = 150 });

            // Scroll view for Image Banner Stack

            ScrollView ScrollViewImgBanner = new ScrollView
            {
                Orientation = ScrollOrientation.Horizontal,
                Content = imgbannerStack
            };

            StackLayout x = new StackLayout();
            x.Children.Add(ScrollViewImgBanner);

            //Main Stack Layout

            StackLayout mainStack = new StackLayout();
            mainStack.Children.Add(x);
            StackLayout stackProducts = new StackLayout();
            stackProducts.Children.Add(new Label { Text = "Recommended Products", FontFamily = "Bold", FontSize = 25, TextColor = Color.Black });
            stackProducts.Children.Add(scrollviewRecommendedProducts);
            stackProducts.Children.Add(new Label { Text = "Featured offers", FontFamily = "Bold", FontSize = 25, TextColor = Color.Black });
            stackProducts.Children.Add(scrollviewFeaturedOffers);
            stackProducts.Children.Add(new Label { Text = "Featured Categories", FontFamily = "Bold", FontSize = 25, TextColor = Color.Black });
            stackProducts.Children.Add(scrollviewFeaturedCategories);
            stackProducts.Children.Add(new Label { Text = "Top Brands", FontFamily = "Bold", FontSize = 25, TextColor = Color.Black });
            stackProducts.Children.Add(bindData());
            stackProducts.Orientation = StackOrientation.Vertical;

            // Scroll View For Products
            ScrollView scrollviewProducts = new ScrollView
            {
                VerticalOptions = LayoutOptions.Fill,
                Orientation = ScrollOrientation.Vertical,
                Content = stackProducts

            };

            mainStack.Children.Add(scrollviewProducts);

            //Content = mainStack;
            Title = "scrollView";
            //Content = new Frame
            //{
            //    BorderColor = Color.Accent,
            //    HasShadow = true,
            //    HorizontalOptions = LayoutOptions.Center,
            //    VerticalOptions = LayoutOptions.CenterAndExpand,
            //    Content = mainStack
            //};
            Content = new Frame
            {
                BorderColor = Color.Accent,
                HasShadow = true,
                //HorizontalOptions = LayoutOptions.Center,
                //VerticalOptions = LayoutOptions.Center,
                Content = mainStack
            };
        }

        public void ImageTap_Tapped(object sender, EventArgs e)
        {
            Image imagetext = (Image)sender;
            DisplayAlert("message", imagetext.Source.ToString(),"ok");
        }

        public ScrollView bindData()
        {
            StackLayout stackTopBrands = new StackLayout();
            stackTopBrands.Orientation = StackOrientation.Horizontal;
            stackTopBrands.HeightRequest = 150;

            for (var a = 0; a < 20; a++)
            {
                var image = new Image();
                image.Source = ImageSource.FromResource("ScrollViewTaskNew.star_selected.png");
                image.WidthRequest = 120;
                image.HeightRequest = 70;
                //stackTopBrands.Children.Add(new Image { Source = "s1.jpg", WidthRequest = 120, HeightRequest = 70 });
                TapGestureRecognizer imageTap = new TapGestureRecognizer();
                imageTap.Tapped += ImageTap_Tapped;
                image.GestureRecognizers.Add(imageTap);
                stackTopBrands.Children.Add(image);
            }

            //Scroll View For top brands

            ScrollView scrollviewTopBrands = new ScrollView
            {
                HorizontalOptions = LayoutOptions.Fill,
                Orientation = ScrollOrientation.Horizontal,
                Content = stackTopBrands
            };
            //Frame frame = new Frame
            //{
            //    BorderColor = Color.Accent,
            //    HasShadow = true,
            //    HorizontalOptions = LayoutOptions.Center,
            //    VerticalOptions = LayoutOptions.Center,
            //    Content = scrollviewTopBrands
            //};
            return scrollviewTopBrands;
        }

        public Frame bindstackData(int i)
        {
            //StackLayout stackProducts = new StackLayout();
            //Frame frame =null;
            //for (int i = 0; i < 7; i++)
            //{
                //stackProducts.Children.Add(new Label { Text = "Top Brands"+i, FontFamily = "Bold", FontSize = 25, TextColor = Color.Black });
                //stackProducts.Children.Add(bindData());
                //stackProducts.Orientation = StackOrientation.Vertical;

            //var frame = new Frame();

            //frame.BorderColor = Color.Accent;
            //frame.HasShadow = true;
            //frame.HorizontalOptions = LayoutOptions.Center;
            //frame.VerticalOptions = LayoutOptions.Center;
            //frame.Content = stackProducts;



            //}

            return new Frame
            {
                BorderColor = Color.Accent,
                CornerRadius=10,
                Margin=2,
                HasShadow = true,
                //Padding = new Thickness(30, 10, 10, 20),
                Content = new StackLayout
                {
                    Orientation = StackOrientation.Vertical,
                    Children =
                    {
                        new Label { Text = "Top Brands"+i, FontFamily = "Bold", FontSize = 25, TextColor = Color.Black },
                        new ScrollView{Content=bindData()}
                    }

                }

            };

        }
        
    }
}