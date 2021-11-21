using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Финальная_версия_дз_по_дм
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string[] stringArray = {
                "родитель(Георг 1, Георг 2)",
                "родитель (Георг 3, Георг 4)",
                "родитель (Георг 3, Вильгельм 4)",
                "родитель (Георг 3, Эдвард)",
                "родитель(Эдвард, Виктория)",
                "родитель(Виктория, Эдвард 7)",
                "родитель (Эдвард 7, Георг 5)",
                "родитель(Георг 5, Эдвард 8)",
                "родитель (Георг 5, Георг 6)",
                "родитель(Георг 6, Елизавета 2)",
                "родитель(Виктория, Элис)",
                "родитель(Элис, Виктория Альберта)",
                "родитель (Виктория Альберта, Элис-Моунтбаттен)",
                "родитель (Элис-Моунтбаттен, Филипп)",

                "жена(София, Георг 1)",
                "жена(Вильгельмина, Георг 2)",
                "жена(Шарлотта, Георг 3)",
                "жена(Каролина, Георг 4)",
                "жена(Аделаида, Вильгельм 4)",
                "жена(Виктория, Альберт)",
                "жена(Александра, Эдвард 7)",
                "жена(Виктория Мари, Георг 5)",
                "жена(Елизавета, Георг 6)",
                "жена(Елизавета 2, Филлип)",

                "женщина(София)",
                "женщина(Вильгельмина)",
                "женщина(Шарлотта)",
                "женщина(Каролина)",
                "женщина(Аделаида)",
                "женщина(Виктория)",
                "женщина(Александра)",
                "женщина(Виктория Мари)",
                "женщина(Елизавета)",
                "женщина(Елизавета 2)",
                "женщина(Элис-Моунтбаттен)",
                "женщина(Виктория Альберта)",
                "женщина(Элис)",
                "женщина(Элис)",
                "женщина(Элис)",
                "женщина(Элис)",

                "мужчина(Георг 1)",
                "мужчина(Георг 2)",
                "мужчина(Георг 3)",
                "мужчина(Георг 4)",
                "мужчина(Вильгельм 4)",
                "мужчина(Эдвард)",
                "мужчина(Эдвард 7)",
                "мужчина(Георг 5)",
                "мужчина(Эдвард 8)",
                "мужчина(Георг 6)",
                "мужчина(Филипп)"
            };

            string message = textBox1.Text;
            var foo = stringArray.Any(str => textBox1.Text.Contains(str,StringComparison.CurrentCultureIgnoreCase));
            if (message == "" || message == null)
            {
                label1.Text = "Вы не ввели элемент!";
            }
            else if (foo)
            {
                label1.Text = "Элемент найден";
            }
            else if(foo==false)
            {
                label1.Text = "Элемент не найден";
            }
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
