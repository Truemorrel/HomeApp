﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HomeApp.Pages;

namespace HomeApp
{
	public partial class App : Application
	{
		public App()
		{
			// инициализация интерфейса
			InitializeComponent();
			// Инициализация главного экрана
			// new LoadingPage();
			// new MainPage();
			// new LoginPage();
			// new Register();
			// new DevicesPage();
			// new RoomsPage();
			// DevicesPage();
			MainPage = new ClimatePage();
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
