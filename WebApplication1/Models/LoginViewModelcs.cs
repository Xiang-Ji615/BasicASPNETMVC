using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [DisplayName("LoginViewModelCs")]
    public class LoginViewModelcs
    {
        String username;
        String password;

        public LoginViewModelcs(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public LoginViewModelcs()
        {
        }

        [DisplayName("JJ Username Display")]
        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

    }
}