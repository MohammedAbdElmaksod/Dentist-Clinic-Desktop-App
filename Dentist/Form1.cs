using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Dentist
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
            else
                WindowState = FormWindowState.Maximized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtSearch.Visible == false && btnSearch.Visible == false)
            {
                txtSearch.Visible = true;
                btnSearch.Visible = true;
                txtSearch.Focus();
            }
            else
            {
                txtSearch.Visible = false;
                btnSearch.Visible = false;
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            btnPatients.BackColor = Color.Transparent;
            btnHome.BackColor = Color.Salmon;
            dataView.Visible = false;
            btnClearData.Visible = false;
            txtPName.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RestMoney r = new RestMoney();

            if (DateTime.Now.Day == 1)
                r.ShowDialog();
            btnHome.BackColor = Color.Salmon;
            txtPName.Focus();
        }




        DentistEntities2 dentist = new DentistEntities2();


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                TbPatient patient1 = new TbPatient();
                var patient = dentist.TbPatients.Find(txtPhone.Text);
                if (patient != null)
                    MessageBox.Show("this patient is already exist...!");
                else
                {
                    if (validation())
                    {
                        patient1.PatientName = txtPName.Text;
                        patient1.PatientAge = int.Parse(txtPAge.Text);
                        patient1.PaidUp = int.Parse(txtPaidUp.Text);
                        patient1.TheRest = int.Parse(txtRest.Text);
                        patient1.Done = txtDone.Text;
                        patient1.PatientPhone = txtPhone.Text;
                        patient1.ExaminationTime = dtEX.Value;
                        patient1.ReExaminationTime = dtReEX.Value;
                        dentist.TbPatients.Add(patient1);
                        dentist.SaveChanges();
                        MessageBox.Show("Saved");
                        txtPName.Clear();
                        txtPAge.Clear();
                        txtPaidUp.Clear();
                        txtPhone.Clear();
                        txtRest.Clear();
                        txtDone.Clear();
                        dtEX.Value = DateTime.Now;
                        dtReEX.Value = DateTime.Now;
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private bool validation()
        {

            if (txtPName.Text == "")
            {
                MessageBox.Show("please enter Patient Name");
                return false;
            }
            if (txtPAge.Text == "")
            {
                MessageBox.Show("please enter Patient age");
                return false;
            }
            if (txtPaidUp.Text == "")
            {
                MessageBox.Show("please enter how much Patient paid");
                return false;
            }
            if (txtRest.Text == "")
            {
                MessageBox.Show("please enter The Rest");
                return false;
            }
            if (txtPhone.Text == "")
            {
                MessageBox.Show("please enter The Phone Number");
                return false;
            }
            for (int i = 0; i < txtPName.Text.Length; i++)
            {
                if (char.IsDigit(txtPName.Text, i))
                {
                    MessageBox.Show("Patient Name must be only letters...!");
                    return false;
                }
            }
            for (int i = 0; i < txtPAge.Text.Length; i++)
            {
                if (char.IsLetter(txtPAge.Text, i))
                {
                    MessageBox.Show("Patient Age must be only Numbers...!");
                    return false;
                }
            }
            for (int i = 0; i < txtPaidUp.Text.Length; i++)
            {
                if (char.IsLetter(txtPaidUp.Text, i))
                {
                    MessageBox.Show("money must be only Numbers...!");
                    return false;
                }
            }
            for (int i = 0; i < txtRest.Text.Length; i++)
            {
                if (char.IsLetter(txtRest.Text, i))
                {
                    MessageBox.Show("Patient money must be only Numbers...!");
                    return false;
                }
            }
            return true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                TbPatient patient = new TbPatient();
                patient = dentist.TbPatients.FirstOrDefault(a => a.PatientName == txtSearch.Text);
                if (patient != null)
                {
                    txtPName.Text = patient.PatientName;
                    txtPAge.Text = patient.PatientAge.ToString();
                    txtPaidUp.Text = patient.PaidUp.ToString();
                    txtRest.Text = patient.TheRest.ToString();
                    txtPhone.Text = patient.PatientPhone;
                    txtDone.Text = patient.Done;
                    dtEX.Value = patient.ExaminationTime.Value;
                    dtReEX.Value = patient.ReExaminationTime.Value;
                    return;
                }
                else
                    MessageBox.Show("not found");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPName.Clear();
            txtPAge.Clear();
            txtPaidUp.Clear();
            txtPhone.Clear();
            txtRest.Clear();
            txtDone.Clear();
            txtSearch.Clear();
            dtEX.Value = DateTime.Now;
            dtReEX.Value = DateTime.Now;
            return;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                TbPatient patient = new TbPatient();
                patient = dentist.TbPatients.Find(txtPhone.Text);
                if (patient != null)
                {
                    patient.PatientName = txtPName.Text;
                    patient.PatientAge = int.Parse(txtPAge.Text);
                    patient.PaidUp = int.Parse(txtPaidUp.Text);
                    patient.TheRest = int.Parse(txtRest.Text);
                    patient.Done = txtDone.Text;
                    patient.PatientPhone = txtPhone.Text;
                    patient.ExaminationTime = dtEX.Value;
                    patient.ReExaminationTime = dtReEX.Value;
                    dentist.TbPatients.AddOrUpdate(patient);
                    dentist.SaveChanges();
                    MessageBox.Show("Modified");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnPatients_Click_1(object sender, EventArgs e)
        {
            try
            {
                btnHome.BackColor = Color.Transparent;
                btnPatients.BackColor = Color.Salmon;
                var lstPatients = dentist.TbPatients.ToList();
                dataView.DataSource = lstPatients;
                dataView.Visible = true;
                btnClearData.Visible = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }


        }

        private void btnClearData_Click(object sender, EventArgs e)
        {
            dentist.TbPatients.RemoveRange(dentist.TbPatients.ToList());
            dentist.SaveChanges();
            dataView.DataSource = dentist.TbPatients.ToList();
        }
    }
}
