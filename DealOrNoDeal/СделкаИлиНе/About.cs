using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace СделкаИлиНе
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void About_Load(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Благодаря на всички тестери!!! Отбелязани са с максималната сума.");
            sb.AppendLine("Разработка и дизайн:");
            sb.AppendLine("Студент: Иван Митовски");
            sb.AppendLine("Специалност: СТД");
            sb.AppendLine("Факултетен номер: 2001681067");

            rtbStudentInfo.Text = sb.ToString();
        }

        private void About_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Наистина ли искате да се върнете към менюто ?", "Изход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}
