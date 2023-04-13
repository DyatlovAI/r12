using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
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
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            int id = Convert.ToInt32(row.Cells["idDataGridViewTextBoxColumn"].Value);
            var bookToRemove = _context.Tovari.FirstOrDefault(b => b.Id == id);
            _context.Tovari.Remove(bookToRemove);
            _context.SaveChanges();
            update();
        }
        private void update()
        {
            List<Tovari> booksWithUserId = _context.Tovari.Where(b => b.UserId == _user.Id).ToList();
            dataGridView1.DataSource = booksWithUserId;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            
            this.tovariTableAdapter.Fill(this.libraryDbDataSet.Tovari);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDbDataSet.Tovari". При необходимости она может быть перемещена или удалена.
            this.tovariTableAdapter.Fill(this.libraryDbDataSet.Tovari);

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.tovariTableAdapter.FillBy(this.libraryDbDataSet.Tovari, ((int)(System.Convert.ChangeType(iDToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
    }
