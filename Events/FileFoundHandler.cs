namespace DelegatesAndHandlers.Events
{
    public static class FileFoundHandler
    {
        public static void Handle(object sender, FileArgs fileArgs)
        {
            Console.WriteLine($"Найден файл: {fileArgs.FileName}");

            if (fileArgs.FileName.Contains("Отчет"))
            {
                Console.WriteLine("Поиск прекращен");
                ((FileSearcher)sender).CancelSearch();
            }
        }
    }
}
