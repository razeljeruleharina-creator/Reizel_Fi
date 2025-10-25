using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextFile
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                string studentNo = txtStudentNo.Text.Trim();
                string lastName = txtLastName.Text.Trim();
                string firstName = txtFirstName.Text.Trim();
                string middleInitial = txtMI.Text.Trim();
                string program = cbProgram.Text.Trim();
                string gender = cbGender.Text.Trim();
                string age = txtAge.Text.Trim();
                string birthday = dtpBirthday.Value.ToString("yyyy-MM-dd");
                string contact = txtContactNo.Text.Trim();


                string content =
                    "Student No.:" + studentNo + "\r\n" +
                    "Full Name:" + lastName + ", " + firstName + ", " + middleInitial + ".\r\n" +
                    "Program: " + program + "\r\n" +
                    "Gender: " + gender + "\r\n" +
                    "Age: " + age + "\r\n" +
                    "Birthday: " + birthday + "\r\n" +
                    "Contact No.:" + contact;


                string fileName = studentNo + ".txt";


                File.WriteAllText(fileName, content, Encoding.UTF8);

                MessageBox.Show("Registration saved successfully!\nFile created: " + fileName,
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving file:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      }
    }
