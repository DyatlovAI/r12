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
    public partial class Form5 : Form
    {
        private readonly AppDbContext _context;
        private readonly User _user;

        public Tovari Tovari { get; private set; }
        public Form5(AppDbContext context, User user)
        {
            InitializeComponent();
            _context = context;
            _user = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tovari = new Tovari
            {
                Date = textBox1.Text,
                Klient = textBox2.Text,
                Tovar = textBox3.Text,
                kolichestvo = textBox3.Text,
                UserId = _user.Id
            };

            _context.Tovari.Add(tovari);
            _context.SaveChanges();

            Tovari = tovari;
            DialogResult = DialogResult.OK;
        }
    }
}
  
