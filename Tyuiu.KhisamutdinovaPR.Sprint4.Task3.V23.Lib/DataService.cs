using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KhisamutdinovaPR.Sprint4.Task3.V23.Lib
{
    // Интерфейс ожидается в DLL: ISprint4Task3V23
    // Сигнатура метода по типовым заданиям спринта 4 — Calculate(int[,] matrix)
    public class DataService : ISprint4Task3V23
    {
        /// <summary>
        /// Возвращает количество чётных элементов в переданной двумерной матрице.
        /// </summary>
        public int Calculate(int[,] matrix)
        {
            if (matrix == null) throw new ArgumentNullException(nameof(matrix));

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int countEven = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if ((matrix[i, j] & 1) == 0) // быстрее, чем % 2 == 0
                        countEven++;
                }
            }

            return countEven;
        }
    }
}