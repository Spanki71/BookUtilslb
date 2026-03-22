using System;

namespace BookUtils
{
    public class BookHelper
    {
        public static bool IsValidYear(int year)
        {
            return year >= 1450 && year <= DateTime.Now.Year;
        }

        public static string FormatTitle(string title)
        {
            if (string.IsNullOrEmpty(title))
                return title;
            return char.ToUpper(title[0]) + title.Substring(1).ToLower();
        }

        public static string GenerateBookId(string title, int year)
        {
            string shortTitle = title.Length > 3 ? title.Substring(0, 3) : title;
            return $"{shortTitle.ToUpper()}-{year}";
        }

        public static bool IsValidAuthor(string author)
        {
            return !string.IsNullOrWhiteSpace(author) && author.Length <= 100;
        }

        /// <summary>
        /// Возвращает жанр книги по умолчанию, если жанр не указан
        /// </summary>
        public static string GetDefaultGenre(string genre)
        {
            return string.IsNullOrWhiteSpace(genre) ? "Не указан" : genre;
        }
    }
}