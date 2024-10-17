using System;

namespace MyProject.Models
{
    public class User
    {
        public int Id { get; set; 
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public long Mobile { get; set; }
        public bool IsConfirmed { get; set; } = false; /
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
