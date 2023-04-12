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
    public partial class Form4 : Form
    {
        private readonly AppDbContext _context;
        private readonly User _user;
        public Form4(AppDbContext context, User user)
        {
            InitializeComponent();
            _context = context;
            _user = user;
            _user.Tovaris = _context.Tovari.Where(b => b.UserId == _user.Id).ToList();


            Text = $"Библиотека пользователя {_user.Name}";

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = _user.Tovaris;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form5 = new Form5(_context, _user);
            if (form5.ShowDialog() == DialogResult.OK)
            {
                _user.Tovaris.Add(form5.Tovari);
                _context.SaveChanges();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = _user.Tovaris;
            }
        }

        

        

        private void button2_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridView1.SelectedRows[0];
            var tovari = (Tovari)selectedRow.DataBoundItem;
            _user.Tovaris.Remove(tovari);
            _context.SaveChanges();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _user.Tovaris;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    }
