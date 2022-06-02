﻿using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace BookList.Model
{
    public static class Serializer
    {
        /// <summary>
        /// Проводит сериализацию данных.
        /// </summary>
        public static void Serialize(string path, List<Book> books)
        {
            using (StreamWriter writer = new StreamWriter(path + @"\Serialize.json"))
            {
                writer.Write(JsonConvert.SerializeObject(books));
            }
        }

        /// <summary>
        /// Проводит десериализацию данных.
        /// </summary>
        /// <returns>Возвращает коллекцию песен.</returns>
        public static List<Book> Deserialize(string path)
        {
            var books = new List<Book>();

            try
            {
                using (StreamReader reader = new StreamReader(path + @"\Serialize.json"))
                {
                    books = JsonConvert.DeserializeObject<List<Book>>(reader.ReadToEnd());
                }

                if (books == null) books = new List<Book>();
            }
            catch
            {
                return books;
            }

            return books;
        }
    }
}