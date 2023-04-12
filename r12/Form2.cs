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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace r12
{
    public partial class Form2 : Form
    {
        private readonly AppDbContext _context;
        public Form2(AppDbContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var user = new User
            {
                Name = textBox1.Text,
                email = textBox2.Text,
                password = textBox3.Text
            };


            _context.Users.Add(user);
            _context.SaveChanges();
            MessageBox.Show("Вы успешно зарегистрировались!", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form1 from = new Form1(new AppDbContext());
            this.Hide();
            from.Show();
        }
    }
}
 
