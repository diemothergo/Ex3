﻿namespace Ex3.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public bool Lock { get; set; }
    }
}