using System;

namespace ContosoUniversity.Application.Services.Interfaces
{
    public interface ILoggerService
    {
        void LogInfo(string text);
        void LogInfo(string text, Exception ex);
        void LogError(string text);
        void LogError(Exception ex);
        void LogError(string text, Exception ex);
        void LogWarning(string text);
        void LogWarning(string text, Exception ex);
    }
}
