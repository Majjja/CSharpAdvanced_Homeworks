using System;
using System.IO;

namespace CustomReaderWriter
{
    public class CustomWriter : IDisposable
    {
        private string _path;
        private StreamWriter _sw;
        private bool _disposedValue = false;
        public CustomWriter(string path)
        {
            _path = path;
            _sw = new StreamWriter(path, true);
        }

        public void WriteInFile(string text)
        {
            _sw.WriteLine(text);
        }
        private void _dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    _sw.Dispose();
                }
                _path = "";
                _disposedValue = true;
            }
        }
        public void Dispose()
        {
            _dispose(true);
        }
    }
}
