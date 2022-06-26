using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.IO;
using WpfApp1.Services;
using System.Windows.Input;


namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        bool isEmpty = true;
        bool isEmptyTwo = true;

        public MainWindow()
        {
            InitializeComponent();
          
        }

        private void BtnSignIn_Click(object sender, RoutedEventArgs e)
        {
            var login = "admin";
            var password = "admin";
            if (loginInputBox.Text == login && passwordInputBox.Text == password)
            {
                Main main = new Main();
                main.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Ошибка!");
            }
        }

        private void passwordInputBox_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (isEmptyTwo)
            {
                passwordInputBox.Text = "";
                isEmptyTwo = false;
            }
            if (loginInputBox.Text == "")
            {
                loginInputBox.Text = "Логин";
            }
            if (passwordInputBox.Text == "Пароль")
            {
                passwordInputBox.Text = "";
            }
        }

        private void loginInputBox_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (isEmpty)
            {
                loginInputBox.Text = "";
                isEmpty = false;
            }
            if (passwordInputBox.Text == "")
            {
                passwordInputBox.Text = "Пароль";
            }
            if (loginInputBox.Text == "Логин")
            {
                loginInputBox.Text = "";
            }
        }
    }
}
