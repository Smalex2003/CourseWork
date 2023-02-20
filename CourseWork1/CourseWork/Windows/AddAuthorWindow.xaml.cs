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
    /// Логика взаимодействия для AuthorWindow.xaml
    /// </summary>
    public partial class AuthorWindow : Window
    {
        int idphoto;
        PhotoStorageContext db = new PhotoStorageContext();
        public AuthorWindow(Photo photo)
        {
            InitializeComponent();
            idphoto = (int)photo.Id;
        }

        private void AcceptBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                AuthorOfPhoto author = new AuthorOfPhoto();
                author.Name = NameTb.Text;
                author.Surname = SurnameTb.Text;
                author.Country = CountryTb.Text;
                author.City = CityTb.Text;
                author.Street = StreetTb.Text;
                author.House = HouseTb.Text;
                author.Email = EmailTb.Text;
                db.AuthorOfPhoto.Add(author);
                db.SaveChanges();
                foreach (Photo photo in db.Photo)
                {
                    if (photo.Id == idphoto)
                    {
                        foreach (AuthorOfPhoto authorforid in db.AuthorOfPhoto)
                        {
                            if (authorforid.Email == EmailTb.Text)
                            {
                                photo.AuthorOfPhotoId = authorforid.Id;
                            }
                        }
                    }
                }
                db.SaveChanges();
                MessageBox.Show("Автор фотографии добавлен");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Проверьте правильность введенных данных");
            }
        }
    }
}
