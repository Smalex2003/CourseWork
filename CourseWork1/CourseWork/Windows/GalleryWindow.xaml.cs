using System;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Collections.Generic;
using System.Drawing;
namespace CourseWork.Windows

{
    /// <summary>
    /// Логика взаимодействия для GalleryWindow.xaml
    /// </summary>
    public partial class GalleryWindow : Window
    {
        
        PhotoStorageContext db=new PhotoStorageContext();
        public GalleryWindow()
        {
            InitializeComponent();
            Refresh();
           
            
        }
        public void Refresh()
        {
            MyListView.Items.Clear();
            PhotoStorageContext db = new PhotoStorageContext();
            User thisuser = new User();
            thisuser = AutorizationWindow.CurrentAuthorizedUser;
            List<PhotoF> mylist = new List<PhotoF>();
            foreach (Photo photo in db.Photo)
            {
                if (photo.UserId == thisuser.Id)
                {
                    using (MemoryStream stream = new MemoryStream(Convert.FromBase64String(photo.Photo1)))
                    {

                        Image image1 = new Image();
                        image1.Source = BitmapFrame.Create(stream, BitmapCreateOptions.None, BitmapCacheOption.OnLoad);
                        PhotoF photof = new PhotoF();
                        photof.Id = photo.Id;
                        photof.Name = photo.Name;
                        photof.image = new Image();
                        photof.image.Source = image1.Source;
                        MyListView.Items.Add(photof);
                    }

                }
            }
        }
        public class PhotoF
        {
           public long Id { get; set; }
            public string Name { get; set; }
            public Image image { get; set; }

        }
       

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MyListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        { PhotoF selectphoto = new PhotoF();
            selectphoto = MyListView.SelectedItem as PhotoF;
            SelectPhotoWindow wind=new SelectPhotoWindow(selectphoto,this);
            wind.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MenuWindow menu = new MenuWindow();
            menu.Show();
            this.Close();
        }
    }
}
