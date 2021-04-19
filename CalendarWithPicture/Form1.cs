using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarWithPicture
{
    public partial class MyCalendar : Form
    {
        public MyCalendar()
        {
            InitializeComponent();
            ShowPicture();
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            ShowPicture();
        }
        void ShowPicture()
        {
            try 
            {
                pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
                pictureBox.Image = Image.FromFile("12 Month\\" + monthCalendar.SelectionStart.Month + ".jpg");
                pictureBox.BackgroundImageLayout = ImageLayout.Center;
            }
            catch
            {
                MessageBox.Show("Изображения не найдены!", "Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            }
    }
}
