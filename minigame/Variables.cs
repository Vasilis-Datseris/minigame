using System;
using System.ComponentModel.DataAnnotations;
using System.Data.OleDb;

namespace minigame
{
    public class Variables
    {
        public static int ID { get; set; }
        [Required, RegularExpression(@"^.*[a-zA-Z]")]
        public static string Username { get; set; }
        [Required, EmailAddress]
        public static string email { get; set; }
        [Required]
        public static string specialization { get; set; }
        [Required]
        public static string password { get; set; }
        public static string Highscore { get; set; }
        public static string Currentscore { get; set; }
        public static bool RegisterConfim { get; set; }
        public static bool ColorFlag { get; set; }
        public static string TimesPlayed { get; set; }
        public static string connection { get; set; }
        
    }
}
