﻿using NotificationListenerActionCenterApp.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Notifications;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace NotificationListenerActionCenterApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

     
      public MainPage()
        {
            this.InitializeComponent();
        }

        public MainPageViewModel ViewModel { get; private set; } = new MainPageViewModel();

        private void ListViewNotifications_ItemClick(object sender, ItemClickEventArgs e)
        {
            UserNotification clickedNotif = (UserNotification)e.ClickedItem;

            ViewModel.RemoveNotification(clickedNotif.Id);
        }

        private void ButtonClearAll_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.ClearAll();
        }
    }
}
