﻿using System;
using System.Linq;
using System.Net.Mail;
using System.Windows.Forms;
using FundManager.Core.Component;
using FundManager.Core.Model;
using FundManager.Core.Services;
using FundManager.Desktop.Model;

namespace FundManager.Desktop.Forms
{
    public partial class RegistrationForm : Form
    {
        private readonly AuthenticationService _authenticationService;

        public MainForm OwnerForm { get; set; }

        public RegistrationForm()
        {
            InitializeComponent();
            _authenticationService = new AuthenticationService();
        }

        private async void RegistrationButton_Click(object sender, EventArgs e)
        {
            ValidationErrorsLabel.Text = string.Empty;

            var validationResult = ValidateForm();
            if (validationResult.IsValid)
            {
                var userName = UserNameTextBox.Text;
                var password = PasswordTextBox.Text;
                var email = EmailTextBox.Text;

                var registrationModel = new RegistrationModel
                {
                    Email = email,
                    UserName = userName,
                    Password = password
                };

                if (await _authenticationService.CheckIfExist(userName))
                {
                    SetErrorMessage($"User '{userName}' is already exist");
                    return;
                }

                var result = await _authenticationService.RegisterUser(registrationModel);
                if (result.IsSuccessful)
                {
                    var loginModel = new LoginModel
                    {
                        UserName = userName,
                        Password = password
                    };

                    var loginResult = await _authenticationService.LoginUser(loginModel);

                    if (loginResult.IsSuccessful)
                    {
                        GlobalSession.StartDesktopSession(loginResult.Data);
                        OwnerForm.ChangeHeader(true);
                        Close();
                    }
                    else
                    {
                        SetErrorMessage(loginResult.ErrorMessage);
                    }
                }
                else
                {
                    SetErrorMessage(result.ErrorMessage);
                }
            }
            else
            {
                foreach (var error in validationResult.ErrorMessages)
                {
                    SetErrorMessage(error);
                }
            }
        }

        private ValidationModel ValidateForm()
        {
            var validationModel = new ValidationModel();

            var userName = UserNameTextBox.Text;
            var email = EmailTextBox.Text;
            var password = PasswordTextBox.Text;
            var confirmPassword = ConfirmPasswordTextBox.Text;

            if (string.IsNullOrEmpty(userName))
            {
                validationModel.ErrorMessages.Add("UserName field is empty");
            }

            if (string.IsNullOrEmpty(email))
            {
                validationModel.ErrorMessages.Add("Email field is empty");
            }

            if (string.IsNullOrEmpty(password))
            {
                validationModel.ErrorMessages.Add("Password field is empty");
            }

            if (string.IsNullOrEmpty(confirmPassword))
            {
                validationModel.ErrorMessages.Add("Confirm Password field is empty");
            }

            if (password != confirmPassword)
            {
                validationModel.ErrorMessages.Add("Password must match Confirm password");
            }

            if (!IsEmail(email))
            {
                validationModel.ErrorMessages.Add("Not valid email");
            }

            validationModel.IsValid = !validationModel.ErrorMessages.Any();

            return validationModel;
        }

        private bool IsEmail(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void SetErrorMessage(string errorMessage)
        {
            ValidationErrorsLabel.Text += $@" • {errorMessage}{Environment.NewLine}";
        }
    }
}
