using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.Runtime.InteropServices;
using System.Security;

namespace 医药管理系统wpf
{
    /// <summary>
    /// 可以实现对PasswordBox的交互，要不然无法使用binding
    /// </summary>
    public static class PasswordHelper
    {
        public static readonly DependencyProperty BoundPasswordProperty =
            DependencyProperty.RegisterAttached("BoundPassword", typeof(SecureString), typeof(PasswordHelper), new PropertyMetadata(null, OnBoundPasswordChanged));

        public static SecureString GetBoundPassword(DependencyObject obj)
        {
            return (SecureString)obj.GetValue(BoundPasswordProperty);
        }

        public static void SetBoundPassword(DependencyObject obj, SecureString value)
        {
            obj.SetValue(BoundPasswordProperty, value);
        }

        private static void OnBoundPasswordChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is PasswordBox passwordBox)
            {
                passwordBox.PasswordChanged -= PasswordBox_PasswordChanged;
                passwordBox.Password = SecureStringToString(e.NewValue as SecureString);
                passwordBox.PasswordChanged += PasswordBox_PasswordChanged;
            }
        }

        private static void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (sender is PasswordBox passwordBox)
            {
                SetBoundPassword(passwordBox, StringToSecureString(passwordBox.Password));
            }
        }

        private static SecureString StringToSecureString(string value)
        {
            SecureString secureString = new SecureString();
            foreach (char c in value)
            {
                secureString.AppendChar(c);
            }
            return secureString;
        }

        private static string SecureStringToString(SecureString value)
        {
            IntPtr ptr = Marshal.SecureStringToBSTR(value);
            try
            {
                return Marshal.PtrToStringBSTR(ptr);
            }
            finally
            {
                Marshal.ZeroFreeBSTR(ptr);
            }
        }
    }


  


}
