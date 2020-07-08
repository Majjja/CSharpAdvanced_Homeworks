using System;
using System.IO;

namespace CustomReaderWriter
{
    public class CustomReader : IDisposable
    {
        private string _path;
        private StreamReader _sr;
        private bool _disposedValue;
        public CustomReader(string path)
        {
            _path = path;
            _sr = new StreamReader(_path);
        }

        public void ReadFromFile()
        {
            Console.WriteLine(_sr.ReadToEnd());
        }
        private void _dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    _sr.Dispose();
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
