using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP
{
    public static class BookDataService
    {
        /// <summary>
        /// Загружает список книг из TXT файла.
        /// </summary>
        public static List<Book> LoadBooksFromTxt(string dataFileName)
        {
            // Разделитель определяется локально
            char delimiter = '|';

            if (!File.Exists(dataFileName))
            {
                return new List<Book>();
            }

            string[] lines = File.ReadAllLines(dataFileName);
            List<Book> books = new List<Book>();

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                string[] parts = line.Split(delimiter);

                if (parts.Length != 8) continue;

                try
                {
                    Book book = new Book
                    {
                        Nazva = parts[0],
                        Avtor = parts[1],
                        God = int.Parse(parts[2]),
                        Janr = parts[3],
                        Mova = parts[4],
                        Age = parts[5],
                        Strn = int.Parse(parts[6]),
                        ISBN = parts[7]
                    };
                    books.Add(book);
                }
                catch
                {
                    continue;
                }
            }

            return books;
        }
        public static void SaveBooksToTxt(List<Book> books, string dataFileName)
        {
            char delimiter = '/';

            List<string> lines = books.Select(b =>
                $"{b.Nazva}{delimiter}" +
                $"{b.Avtor}{delimiter}" +
                $"{b.God}{delimiter}" +
                $"{b.Janr}{delimiter}" +
                $"{b.Mova}{delimiter}" +
                $"{b.Age}{delimiter}" +
                $"{b.Strn}{delimiter}" +
                $"{b.ISBN}"
            ).ToList();
            File.WriteAllLines(dataFileName, lines);
        }
    }
}