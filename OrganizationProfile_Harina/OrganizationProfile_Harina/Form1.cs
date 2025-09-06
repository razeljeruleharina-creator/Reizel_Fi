using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrganizationProfile_Harina
{

    public partial class frmRegistration : Form
    {
        private string _FullName;
        private int _Age;
        private long _ContactNo;
        private long _StudentNo;
        public long StudentNumber(string studNum)
        {

            _StudentNo = long.Parse(studNum);

            return _StudentNo;
        }

        public long ContactNo(string Contact)
        {
            if (Regex.IsMatch(Contact, @"^[0-9]{10,11}$"))
            {
                _ContactNo = long.Parse(Contact);
            }

            return _ContactNo;
        }

        public string FullName(string LastName, string FirstName, string MiddleInitial)
        {
            if (Regex.IsMatch(LastName, @"^[a-zA-Z]+$") || Regex.IsMatch(FirstName, @"^[a-zA-Z]+$") || Regex.IsMatch(MiddleInitial, @"^[a-zA-Z]+$"))
            {
                _FullName = LastName + ", " + FirstName + ", " + MiddleInitial;
            }

            return _FullName;
        }

        public int Age(string age)
        {
            if (Regex.IsMatch(age, @"^[0-9]{1,3}$"))
            {
                _Age = Int32.Parse(age);
            }

            return _Age;
        }

        public frmRegistration()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ListOfProgram = new string[]{
           "BS Information Technology",
           "BS Computer Science",
           "BS Information Systems",
           "BS in Accountancy",
           "BS in Hospitality Management",
           "BS in Tourism Management"
            };
            for (int i = 0; i < 6; i++)
            {
                cbPrograms.Items.Add(ListOfProgram[i].ToString());
            }
            cbGender.Items.Add("Male");
            cbGender.Items.Add("Female");


            cbGender.SelectedIndex = 0;
        }



        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void datePickerBirtday_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            {

            }
            StudentInformationClass.SetFullName = txtLastName.Text + ", " + txtFirstName.Text + " " + txtMiddleInitial.Text;
            StudentInformationClass.SetStudentNo = Convert.ToInt32(txtStudentNo.Text);
            StudentInformationClass.SetProgram = cbPrograms.SelectedItem.ToString();
            StudentInformationClass.SetGender = cbGender.SelectedItem.ToString();
            StudentInformationClass.SetContactNo = (int)ContactNo(txtContactNo.Text);
            StudentInformationClass.SetAge = Convert.ToInt32(txtAge.Text);
            StudentInformationClass.SetBirthday = datePickerBirtday.Value.ToString("yyyy-MM-dd");
            frmConfirmation frm = new frmConfirmation();
            frm.ShowDialog();
        }
    }
}


    
