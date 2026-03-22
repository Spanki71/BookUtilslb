using System;

namespace BookUtils
{
    /// <summary>
    /// Утилиты для работы с книгами (подмодуль)
    /// </summary>
    public class BookHelper
    {
        /// <summary>
        /// Проверяет, является ли год издания корректным
        /// </summary>
        public static bool IsValidYear(int year)
        {
            return year >= 1450 && year <= DateTime.Now.Year;
        }

        /// <summary>
        /// Форматирует название книги (первая буква заглавная, остальные строчные)
        /// </summary>
        public static string FormatTitle(string title)
        {
            if (string.IsNullOrEmpty(title))
                return title;
            
            return char.ToUpper(title[0]) + title.Substring(1).ToLower();
        }

        /// <summary>
        /// Генерирует идентификатор книги на основе названия и года
        /// </summary>
        public static string GenerateBookId(string title, int year)
        {
            string shortTitle = title.Length > 3 ? title.Substring(0, 3) : title;
            return $"{shortTitle.ToUpper()}-{year}";
        }

        /// <summary>
        /// Проверяет, является ли автор корректным (не пустой и не слишком длинный)
        /// </summary>
        public static bool IsValidAuthor(string author)
        {
            return !string.IsNullOrWhiteSpace(author) && author.Length <= 100;
        }
    }
}