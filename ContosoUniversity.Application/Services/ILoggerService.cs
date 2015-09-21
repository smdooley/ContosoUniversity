using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoUniversity.Application.Services
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
