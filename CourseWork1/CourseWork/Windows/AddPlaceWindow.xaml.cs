using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CourseWork.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddPlaceWindow.xaml
    /// </summary>
    public partial class AddPlaceWindow : Window
    {
        PhotoStorageContext db=new PhotoStorageContext();
        Photo thisphoto=new Photo();
        public AddPlaceWindow(Photo photo)
        {
            InitializeComponent();
            thisphoto=photo;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PlaceOfPhoto place = new PlaceOfPhoto();
            place.City = CityTb.Text;
            place.Street = StreetTb.Text;
            place.Country = CountryTb.Text;
            db.PlaceOfPhoto.Add(place);
            db.SaveChanges();
            foreach(PlaceOfPhoto place1 in db.PlaceOfPhoto)
            {
                if (place1.City == place.City && place1.Country == place.Country && place1.Street == place.Street)
                {
                    foreach(Photo photo in db.Photo)
                    {
                        if (photo.Id == thisphoto.Id)
                        {
                            photo.PlaceOfPhotoId = place1.Id;
                            db.SaveChanges();
                        }
                    }
                }
            }
            MessageBox.Show("Место фотографии добавленно");
            this.Close();
        }
    }
}
