using Lab11_Variant7;  // Простір імен для класів нашої програми
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;  // Простір імен для Windows Forms компонентів

namespace Лаб11__пробна_
{
    // Головний клас програми, що містить точку входу
    internal static class Program
    {
        /// <summary>
        /// Головна точка входу для додатка.
        /// </summary>
        [STAThread]  // Атрибут, що вказує на однопотокову модель apartment для COM-компонентів
        static void Main()
        {
            // Включаємо візуальні стилі для елементів інтерфейсу
            Application.EnableVisualStyles();

            // Встановлюємо значення за замовчуванням для рендерингу тексту
            Application.SetCompatibleTextRenderingDefault(false);

            // Запускаємо головну форму програми (MainForm)
            Application.Run(new MainForm());

            // Після закриття головної форми програма завершує роботу
        }
    }
}