using CoreLayer.Services.Abstracts;

namespace CoreLayer.Services.Concretes
{
    public class MultiLoggerFacade : IMultiLoggerFacade
    {
        IFileLogger _fileLogger;
        IDebugLogger _debugLogger;

        public MultiLoggerFacade(IDebugLogger debugLogger, IFileLogger fileLogger)
        {

            _debugLogger = debugLogger;
            _fileLogger = fileLogger;
        }

        public void Log(string message)
        {
            _fileLogger.Log(message);
            _debugLogger.Log(message);
        }
    }

}
