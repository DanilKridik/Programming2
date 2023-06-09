﻿using System;

namespace Programming.Model
{
    /// <summary>
    /// Предоставляет методы для создания прямоугольников.
    /// </summary>
    public class RectangleFactory
    {
        /// <summary>
        /// Отступ внутри элемента размещения прямоугольников.
        /// </summary>
        private const int Margin = 15;

        /// <summary>
        /// Генератор cлучайные значения.
        /// </summary>
        private static Random _random = new Random();
        

        /// <summary>
        /// Создаёт прямоугольник со случайными значениями высоты, ширины и координат.
        /// </summary>
        /// <param name="widthCanvas">Ширина элемента размещения.</param>
        /// <param name="heightCanvas">Высота элемента размещения.</param>
        /// <returns>Возвращает объект Rectangle.</returns>
        public static Rectangle Randomize(int widthCanvas, int heightCanvas)
        {
            var colors = Enum.GetValues(typeof(Colors));
            Rectangle rectangle = new Rectangle();
            rectangle.Width = _random.Next(30, 100);
            rectangle.Height = _random.Next(30, 100);
            rectangle.Center = new Point2D(_random.Next(Margin, widthCanvas - rectangle.Width - Margin), _random.Next(Margin, heightCanvas - rectangle.Height - Margin));
            rectangle.Color = colors.GetValue(_random.Next(0, colors.Length)).ToString();
            return rectangle;
        }
        
        /// <summary>
        /// Создаёт прямоугольник со случайными значениями высоты, ширины и координат.
        /// </summary>
        /// <returns>Возвращает объект Rectangle.</returns>
        public static Rectangle Randomize()
        {
            var colors = Enum.GetValues(typeof(Colors));
            Rectangle rectangle = new Rectangle();
            rectangle.Center = new Point2D(_random.Next(1, 500), _random.Next(1, 500));
            rectangle.Width = _random.Next(30, 100);
            rectangle.Height = _random.Next(30, 100);
            rectangle.Color = colors.GetValue(_random.Next(0, colors.Length)).ToString();
            return rectangle;
        }

    }
}