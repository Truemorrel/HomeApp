﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HomeApp.Pages
{
	public partial class LoginPage : ContentPage
	{
		// Константа для текста кнопки
		public const string BUTTON_TEXT = "Войти";
		// Переменная счетчика
		public static int loginCouner = 0;

		public LoginPage()
		{
			InitializeComponent();
		}

		/// <summary>
		/// По клику обрабатываем счётчик и выводим разные сообщения
		/// </summary>
		private void Login_Click(object sender, EventArgs e)
		{
			if (loginCouner == 0)
			{
				// Если первая попытка - просто меняем сообщения
				loginButton.Text = $"Выполняется вход..";
			}
			else if (loginCouner > 5) // Слишком много попыток - показываем ошибку
			{
				// Деактивируем кнопку
				loginButton.IsEnabled = false;

				// Добавляем элемент через свойство Children
				stackLayout.Children.Add(new Label
				{
					Text = "Слишком много попыток! Попробуйте позже.",
					TextColor = Color.Red,
					VerticalTextAlignment = TextAlignment.Center,
					HorizontalTextAlignment = TextAlignment.Center,
					Padding = new Thickness()
					{
						Bottom = 30,
						Left = 10,
						Right = 10,
						Top = 30
					}
				});
			}
			else
			{
				// Изменяем текст кнопки и показываем количество попыток входа
				loginButton.Text = $"Выполняется вход...   Попыток входа: {loginCouner}";
			}

			// Увеличиваем счетчик
			loginCouner += 1;
		}
	}
}