using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace r12
{
    public partial class Form1 : Form
    {
        private AppDbContext context;
        public Form1(AppDbContext context)
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form2 from = new Form2(new AppDbContext());
            this.Hide();
            from.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user;
            using (var context = new AppDbContext())
            {
                var email = textBox1.Text;
                var password = textBox2.Text;

                user = context.Users.FirstOrDefault(u => u.email == email && u.password == password);
            }


            if (user != null)
            {
                MessageBox.Show("Вы успешно авторизовались!", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form4 mainForm = new Form4(new AppDbContext(), user);
                Hide();
                mainForm.ShowDialog();

                DialogResult dialogResult = MessageBox.Show("Закрыть программу?", "Думай", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                    Close();
                else if (dialogResult == DialogResult.No)
                    Show();
            }
            else
            {
                MessageBox.Show("Неправильный email или пароль", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
  
