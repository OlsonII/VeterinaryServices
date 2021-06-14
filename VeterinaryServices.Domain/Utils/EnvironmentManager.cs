using System;

namespace VeterinaryServices.Domain.Utils
{
    public static class EnvironmentManager
    {
        public static string Server => Environment.GetEnvironmentVariable("SERVER");
        public static string Port => Environment.GetEnvironmentVariable("PORT");
        public static string DbName => Environment.GetEnvironmentVariable("DBNAME");
        public static string Username => Environment.GetEnvironmentVariable("USERNAME");
        public static string Password => Environment.GetEnvironmentVariable("PASSWORD");
        
    }
}