using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie2
{
    public partial class Form1 : Form
    {
        Game game;

        public Form1()
        {
            InitializeComponent();
            game = new Game(4);
        }

        private void button15_Click(object sender, EventArgs e) //Событие, происходящее во время нажатия кнопки
        {
            int position = Convert.ToInt16(((Button)sender).Tag);
            game.Shift(position);
            refresh();
            if (game.Check_Numbers())
            {
                MessageBox.Show("Вы победили!");
                start_game();
            } 
        }

        private Button button (int position) //Присваиваем значения кнопкам
        {
            switch(position)
            {
                case 0: return button0;
                case 1: return button1;
                case 2: return button2;
                case 3: return button3;
                case 4: return button4;
                case 5: return button5;
                case 6: return button6;
                case 7: return button7;
                case 8: return button8;
                case 9: return button9;
                case 10: return button10;
                case 11: return button11;
                case 12: return button12;
                case 13: return button13;
                case 14: return button14;
                case 15: return button15;
                default : return null;
            }
        }

        private void Form1_Load(object sender, EventArgs e) //Событие при запуске
        {
            start_game();
        }
        private void menu_start_Click(object sender, EventArgs e)
        {
            start_game();
        }

        private void start_game () //Параметры для функции Shift_Random
        { 
            game.Start();
            for (int i = 0; i < 100; i++)
                game.Shift_Random();
            refresh();
        }

        private void refresh () //Настроили невидимую кнопку
        {
            for (int position = 0; position < 16; position++)
            {
                int nr = game.Get_Number(position);
                button(position).Text = nr.ToString();
                button(position).Visible = (nr > 0);
            }
        }

       
    }
}
