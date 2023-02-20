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
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        PhotoStorageContext db=new PhotoStorageContext();
        public AdminWindow()
        {
            InitializeComponent();
            Refresh();

        }
        public void Refresh()
        {
            PhotoStorageContext _db = new PhotoStorageContext();
            UsersGrid.ItemsSource = _db.User.ToList();
            PhotoGrid.ItemsSource = _db.Photo.ToList();
        }
       

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            User selecteduser = new User();
            selecteduser = (sender as Button).DataContext as User;
            EditUserWindow wind = new EditUserWindow(selecteduser,this);
            wind.Show();
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            User selecteduser = new User();
            selecteduser = (sender as Button).DataContext as User;
            db.User.Remove(selecteduser);
            db.SaveChanges();
            MessageBox.Show("Пользователь удален");
            Refresh();
        }

        private void DeletePhotoBtn_Click(object sender, RoutedEventArgs e)
        {
            Photo photofordelete = new Photo();
            photofordelete = (sender as Button).DataContext as Photo;
            db.Photo.Remove(photofordelete);
            db.SaveChanges();
            MessageBox.Show("Фотография удалена");
            Refresh();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
