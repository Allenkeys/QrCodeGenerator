﻿namespace TodoList.BLL.Models
{
    public class CreateUserVM
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string? MiddleName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
        //public string ConfirmPassword { get; set; }

    }
}