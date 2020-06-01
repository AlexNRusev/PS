using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Newtonsoft.Json;
using UserLogin;
using Microsoft.EntityFrameworkCore;

namespace StudentInfoSystem
{
    public static class Logger
    {
        private static string _logFile = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, LoggerConfiguration.LogFile);

        private static string _attemptsFile = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, LoggerConfiguration.AttemptsLogFile);


        private static List<string> currentSessionActivities = new List<string>();
        private static JsonSerializerSettings _jsonSettings = new JsonSerializerSettings()
        {
            Formatting = Formatting.Indented
        };

        public static void LogActivity(string activity)
        {
            var activityLine = $"[{ DateTime.Now.ToString("yyyy-dd-MM HH:mm:ss")}] {LoginValidation.CurrentUserUsername} - {LoginValidation.CurrentUserRole.ToString()} - {activity}";
            currentSessionActivities.Add(activityLine);
            LogToFile(activityLine, _logFile);
        }

        public static void LogToAttempts(string username, LoginStatusCode statusCode)
        {
            var logAttempts = GetAttempts();

            if (logAttempts == null)
            {
                logAttempts = new List<LogAttempt>();
            }

            logAttempts.Add(new LogAttempt()
            {
                Username = username,
                StatusCode = statusCode
            });

            var json = JsonConvert.SerializeObject(logAttempts, _jsonSettings);

            File.WriteAllText(_attemptsFile, json);

            //using(var context = new StudentInfoContext())
            //{
                
            //     context.Logs.Add(
            //    new LogAttempt
            //    {
            //        Username = username,
            //        StatusCode = statusCode
            //    });
            //    context.SaveChanges();
            //}

        }

        public static List<LogAttempt> GetAttempts()
        {
            if (!File.Exists(_attemptsFile) ||
                FileIsEmpty(_attemptsFile))
            {
                return null;
            }

            var json = File.ReadAllText(_attemptsFile);

            var logAttempts = JsonConvert.DeserializeObject<List<LogAttempt>>(json, _jsonSettings);

            return logAttempts;
        }

        private static void LogToFile(string activityLine, string filePath)
        {
            File.AppendAllText(filePath, activityLine);
            File.AppendAllText(filePath, Environment.NewLine);
        }

        public static string ReadFile(string filePath)
        {
            if (!File.Exists(filePath) || FileIsEmpty(filePath))
            {
                return null;
            }

            return File.ReadAllText(filePath);
        }

        private static bool FileIsEmpty(string filePath)
        {
            return new FileInfo(filePath).Length == 0;
        }

        public static string GetCurrentSessionActivities()
        {
            var sb = new StringBuilder();
            currentSessionActivities.ForEach(a => sb.Append(a));
            sb.Append(Environment.NewLine);
            return sb.ToString();
        }

        

    }
}
