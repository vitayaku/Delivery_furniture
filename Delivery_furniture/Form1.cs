using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delivery_furniture
{
    public partial class Form1 : Form
    {
        int floor, price;
        string elevator;
        public Form1()
        {
            InitializeComponent();
            numericUpDown1.Value = 1;
            numericUpDown1.Minimum = 1;
            comboBox1.SelectedItem = "Отсутствует";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                floor = Convert.ToInt32(numericUpDown1.Value);
                elevator = Convert.ToString(comboBox1.SelectedItem);
                switch(elevator)
                {
                    case "Отсутствует":
                        price = 1000 + 100 * floor;
                        break;
                    case "Грузовой":
                        price = 1000;
                        break;
                    case "Пассажирский":
                        price = 1300;
                        break;
                }
                label3.Text = "Стоимость доставки: " + price + " рублей";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }
    }
}
