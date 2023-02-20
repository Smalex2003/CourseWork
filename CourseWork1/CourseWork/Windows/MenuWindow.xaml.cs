using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Win32;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
namespace CourseWork.Windows
{
    /// <summary>
    /// Логика взаимодействия для MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        PhotoStorageContext db =new PhotoStorageContext();
        public MenuWindow()
        {
            InitializeComponent();
        }
        

        public void AddUser()
        {
            User user = new User();

        }

        private void YourPhotoBtn_Click(object sender, RoutedEventArgs e)
        {
            GalleryWindow galleryWindow = new GalleryWindow();
            galleryWindow.Show();
            this.Close();
        }

        private void ChangePasBtn_Click(object sender, RoutedEventArgs e)
        {
            
            ChangePasWindow changew = new ChangePasWindow();
            changew.Show();
        }

        private void AddPhotoBtn_Click(object sender, RoutedEventArgs e)
        {
            User thisuser = new User();
            thisuser = Windows.AutorizationWindow.CurrentAuthorizedUser;
            Photo photo = new Photo();
            AutorizationWindow authwind = new AutorizationWindow();

            OpenFileDialog Files = new OpenFileDialog();
            Files.Filter = "Image Files(*.PNG; *.GIF; *.JPG)|*.BMP;*.GIF; *.JPG|All files (*.*)|*.*";
            Files.ShowDialog();
            FileInfo FileInfo = new FileInfo(Files.FileName);
            Image MapBit = new Image();
            MapBit.Source = new BitmapImage(new Uri(Files.FileName));
            int gg = Convert.ToInt32(MapBit.Source.Height);
            int gg1 = Convert.ToInt32(MapBit.Source.Width);
            photo.Photo1 = Convert.ToBase64String(File.ReadAllBytes(Files.FileName));
            photo.Name = FileInfo.Name;
            photo.Size = (int)(FileInfo.Length * 0.0009765625);
            photo.Format = FileInfo.Extension;
            photo.AddTime = DateTime.Now.ToString();
            photo.UserId = thisuser.Id;
            if(thisuser.Storage + (int)(FileInfo.Length * 0.0009765625) > thisuser.MaxStorage)
            {
                MessageBox.Show("Вам не хватает места в личном хранилище чтобы добавить эту фотографию");
                MessageBox.Show("На данный момент у вас занято " + thisuser.Storage + " КБ и вы пытаетесь добавить фото весом в " + ((int)(FileInfo.Length * 0.0009765625)) + " КБ");
            }
            else
            {
                db.Photo.Add(photo);
                foreach(User user in db.User)
                {
                    if (user.Id == thisuser.Id)
                    {
                        user.Storage += (int)(FileInfo.Length * 0.0009765625);
                    }
                }
                db.SaveChanges();
                MessageBox.Show("Фотография успешно добавлена");
            }

        } 
        private void AdminPanelBtn_Click(object sender, RoutedEventArgs e)
        {
            User thisuser = new User();
            thisuser = Windows.AutorizationWindow.CurrentAuthorizedUser;

            if (thisuser.Role == "Admin")
            {
                AdminWindow windadm = new AdminWindow();
                windadm.Show();
            }
            else
            {
                MessageBox.Show("Вы не администратор");
            }
            
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
