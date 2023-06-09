﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View;
using Validator = View.Model.Services.Validator;

namespace View.Model
{
    public class Contact
    {
        private string _name;

        private string _email;

        private int _phoneNumberNumber;

        public string Name
        {
            get => (_name == null) ? null : _name;
            set
            {
                _name = value;
            }
        }

        public string Email
        {
            get => (_email == null) ? null : _email;
            set
            {
                _email = value;
            }
        }

        public int PhoneNumber
        {
            get => _phoneNumberNumber;
            set
            {
                _phoneNumberNumber = value;
            }
        }

        public Contact()
        {

        }

        public Contact(string name, string email, int phoneNumber)
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
        }
    }
}