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
    /// Логика взаимодействия для SelectPhotoWindow.xaml
    /// </summary>
    public partial class SelectPhotoWindow : Window
    {
        GalleryWindow galwind;
        PhotoStorageContext db=new PhotoStorageContext();
        Photo thisphoto = new Photo();
        public SelectPhotoWindow(GalleryWindow.PhotoF photof,GalleryWindow galwind)
        {
            InitializeComponent();
            
                PhotoImage.Source = photof.image.Source;
                this.galwind = galwind;
                foreach (Photo photo in db.Photo)
                {
                    if (photo.Id == photof.Id)
                    {

                        thisphoto = photo;
                    }
                }
            
           
        }

        private void SelectAuthorBtn_Click(object sender, RoutedEventArgs e)
        {
            AuthorWindow wind = new AuthorWindow(thisphoto);
            wind.Show();
        }

        private void SelectPlaceBtn_Click(object sender, RoutedEventArgs e)
        {
            AddPlaceWindow wind = new AddPlaceWindow(thisphoto);
            wind.Show();
        }

        private void InfBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Информация о фото\n" + "Название: " + thisphoto.Name + "\n" + "Формат: " + thisphoto.Format + "\n" + "Размер: " + thisphoto.Size + "Кб" + "\n" + "Дата добавления: " + thisphoto.AddTime + "\n");
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            
            db.Photo.Remove(thisphoto);
            db.SaveChanges();
            GalleryWindow gal = new GalleryWindow();
            gal.Show();
            MessageBox.Show("Фото удалено");
            this.Close();
           
        }

        private void InMainBtn_Click(object sender, RoutedEventArgs e)
        {
            GalleryWindow gal = new GalleryWindow();
            gal.Show();
            this.Close();
        }
    }
}
