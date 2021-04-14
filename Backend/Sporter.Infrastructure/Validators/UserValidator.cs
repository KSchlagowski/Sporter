using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Sporter.Core.Entities;
using Sporter.Infrastructure.Validators.Interfaces;

namespace Sporter.Infrastructure.Validators
{
    public class UserValidator : IUserValidator
    {
        public List<string> Validate(User user)
        {
            var errors = new List<string>();

            try
            {
                ValidateEmail(user.Email);
                ValidateLogin(user.Login);                             
                ValidatePassword(user.Password);
                ValidateName(user.Name);
                ValidateSurname(user.Surname);                
            }
            catch(FormatException ex) 
            { 
                errors.Add(ex.Message);
            }

            return errors;
        }

        private void ValidateEmail (string Email)
        {
            if(!string.IsNullOrWhiteSpace(Email))
            {
                var match = Regex.Match(Email, @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
                                                + "@"
                                                + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$", RegexOptions.IgnoreCase);

                if (!match.Success)
                {
                    throw new FormatException("Please enter a valid Email."); 
                }
            } else
            throw new FormatException("Please enter an Email.");            
        }

        private void ValidateLogin (string Login)
        { 
            if(!string.IsNullOrWhiteSpace(Login))
            {
                var match = Regex.Match(Login, @"^[a-zA-Z0-9]{1,30}$", RegexOptions.IgnoreCase);

                if (!match.Success)
                {
                    throw new FormatException("Please enter a valid Login.");
                }
            } else
            throw new FormatException("Please enter a Login.");
        }

        private void ValidatePassword (byte[] password)
        {
            if(password != null && password.Length > 0)
            {   
                string Password = Encoding.Default.GetString(password);
                var match = Regex.Match(Password, @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,30}$", RegexOptions.IgnoreCase);

                if (!match.Success)
                {
                    throw new FormatException("Please enter a valid Password (minimum eight characters, at least one letter and one number).");
                }
            } else 
            throw new FormatException("Please enter a Password.");
        }

        private void ValidateName (string Name)
        {
            if(!string.IsNullOrWhiteSpace(Name))
            {
                var match = Regex.Match(Name, @"^[a-zA-Z]{1,30}$", RegexOptions.IgnoreCase);

                if (!match.Success)
                {
                    throw new FormatException("Please enter a valid Name.");
                }
            } else
            throw new FormatException("Please enter a Name.");
        }
        
        private void ValidateSurname (string Surname)
        {
            if(!string.IsNullOrWhiteSpace(Surname))
            {
                var match = Regex.Match(Surname, @"^[a-zA-Z]{1,30}$", RegexOptions.IgnoreCase);

                if (!match.Success)
                {
                    throw new FormatException("Please enter a valid Surname.");
                }
            } else
            throw new FormatException("Please enter a Surname.");
        }
    }
}