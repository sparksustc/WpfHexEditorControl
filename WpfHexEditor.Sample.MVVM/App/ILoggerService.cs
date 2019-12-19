using System;
using System.Runtime.CompilerServices;
using WpfHexEditor.Sample.MVVM.Contracts.Common;

namespace WpfHexEditor.Sample.MVVM.Contracts.App {
    public interface ILoggerService {
        void WriteLine(string msg);
        void WriteCallerLine(string msg, [CallerMemberName] string callerName = null);
        void WriteException(Exception ex, [CallerMemberName] string callerName = null);
        void WriteStack(string msg, [CallerMemberName] string callerName = null);
    }
    public class LoggerService:GenericServiceStaticInstance<ILoggerService> {
        public static void WriteLine(string msg) => Current?.WriteLine(msg);

        public static void WriteCallerLine(string msg, [CallerMemberName] string callerName = null) => Current?.WriteCallerLine(msg, callerName);

        public static void WriteException(Exception ex, [CallerMemberName] string callerName = null) => Current?.WriteException(ex, callerName);

        public static void WriteStack(string msg, [CallerMemberName] string callerName = null) => Current?.WriteStack(msg, callerName);
    }
}
