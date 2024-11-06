namespace DelegatesAndHandlers.Events
{
    public class FileSearcher
    {
        public event EventHandler<FileArgs> FileFound;

        private bool _cancelSearch;

        public void SearchFiles(string directory)
        {
            string[] files = Directory.GetFiles(directory);

            foreach (string file in files)
            {
                FileArgs fileArgs = new FileArgs(file);

                OnFileFound(fileArgs);

                if (_cancelSearch)
                    break;
            }
        }
        public void CancelSearch()
        {
            _cancelSearch = true;
        }

        private void OnFileFound(FileArgs fileArgs)
        {
            FileFound?.Invoke(this, fileArgs);
        }
    }
}
