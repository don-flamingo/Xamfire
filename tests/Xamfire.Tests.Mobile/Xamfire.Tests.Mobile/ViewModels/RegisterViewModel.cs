﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Xamfire.Tests.Mobile.ViewModels
{
    public class RegisterViewModel : ViewModelBase
    {
        private string _email;
        private string _password;

        public string Email { get => _email; set => SetProperty(ref _email, value); }
        public string Password { get => _password; set => SetProperty(ref _password, value); }

        public ICommand SendRegisterRequestCommand => new Command( async () => await RegisterAsync());

        private async Task RegisterAsync()
        {
            await Xamfire.Shared.Xamfire.AuthenticationContext.RegisterUserAsync(Email, Password);
        }


    }
}
