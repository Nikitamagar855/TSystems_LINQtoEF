using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSystems_LINQtoEF
{
    public partial class Form1 : Form
    {
        EmployeeEntities dbContext = new EmployeeEntities();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try {
                Employee emp = new Employee();
                emp.Id = Convert.ToInt32(textId.Text);
                emp.Name = textName.Text;
                emp.Designation = textDesignation.Text;
                emp.Salary = Convert.ToDecimal(textSalary.Text);

                dbContext.Employees.Add(emp);
                int res = dbContext.SaveChanges();
                if (res == 1)
                {
                    MessageBox.Show("Saved");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = dbContext.Employees.Find(Convert.ToInt32(textId.Text));
                if (emp != null)
                {
                    textName.Text = emp.Name;
                    textDesignation.Text = emp.Designation;
                    textSalary.Text = emp.Salary.ToString();
                    int res = dbContext.SaveChanges();
                    if (res == 1)
                    {
                        MessageBox.Show("Saved");
                    }
                }

                else
                {
                    MessageBox.Show("Record not Found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = dbContext.Employees.Find(Convert.ToInt32(textId.Text));
                if (emp != null)
                {
                    emp.Name = textName.Text;
                    emp.Designation = textDesignation.Text;
                    emp.Salary = Convert.ToDecimal(textSalary.Text);
                    int res = dbContext.SaveChanges();
                    if (res == 1)
                    {
                        MessageBox.Show("Updated");
                    }
                }
                else
                {
                    MessageBox.Show("Record not Found");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
    }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = dbContext.Employees.Find(Convert.ToInt32(textId.Text));
                if (emp != null)
                {
                    dbContext.Employees.Remove(emp);
                    int res = dbContext.SaveChanges();
                    if (res == 1)
                    {
                        MessageBox.Show("Deleted");
                    }
                }

                else
                {
                    MessageBox.Show("Record not Found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
