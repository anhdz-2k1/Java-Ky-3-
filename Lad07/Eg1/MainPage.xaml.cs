using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Eg1.Models;
using System.Collections.ObjectModel;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Eg1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<AvatarBook> AvatarBooks;
        private ObservableCollection<Books> Books;
        public MainPage()
        {
            this.InitializeComponent();

            AvatarBooks = new List<AvatarBook>();
            AvatarBooks.Add(new AvatarBook { avatarBook = "Assets/Assets/male-01.png" });
            AvatarBooks.Add(new AvatarBook { avatarBook = "Assets/Assets/male-02.png" });
            AvatarBooks.Add(new AvatarBook { avatarBook = "Assets/Assets/male-03.png" });
            
            

            Books = new ObservableCollection<Books>();
        }

        private void NewBookButton_Click(object sender, RoutedEventArgs e)
        {
            string avatar = ((AvatarBook)AvatarComboBox.SelectedValue).avatarBook;
            Books.Add(new Books { Title = TitleTextBox.Text, Author = AuthorTextBox.Text, Price = PriceTextBox.Text, ImgBook = avatar });

            TitleTextBox.Text = "";
            AuthorTextBox.Text = "";
            PriceTextBox.Text = "";
            AvatarComboBox.SelectedIndex = -1;
            TitleTextBox.Focus(FocusState.Programmatic);
            AuthorTextBox.Focus(FocusState.Programmatic);
            PriceTextBox.Focus(FocusState.Programmatic);
        }
    }
}
