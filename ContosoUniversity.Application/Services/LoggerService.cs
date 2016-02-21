using ContosoUniversity.Application.Services.Interfaces;
using System;

namespace ContosoUniversity.Application.Services
{
    public class LoggerService : ILoggerService
    {
        public void LogInfo(string text)
        {
            throw new NotImplementedException();
        }

        public void LogInfo(string text, Exception ex)
        {
            throw new NotImplementedException();
        }

        public void LogError(string text)
        {
            throw new NotImplementedException();
        }

        public void LogError(Exception ex)
        {
            throw new NotImplementedException();
        }

        public void LogError(string text, Exception ex)
        {
            throw new NotImplementedException();
        }

        public void LogWarning(string text)
        {
            throw new NotImplementedException();
        }

        public void LogWarning(string text, Exception ex)
        {
            throw new NotImplementedException();
        }
    }
}
