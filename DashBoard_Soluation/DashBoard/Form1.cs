using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashBoard
{
    public partial class Form1 : Form
    {
        int FormAppointment = 0;
        int FormPatient = 0;
        int FormDiagnosis = 0;
        private Form activeForm;
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel1_Content.Controls.Add(childForm);
            this.panel1_Content.Tag = childForm;
            //childForm.BringToFront();
            childForm.Show();
            label1_title.Text = childForm.Text;
        }

        //Appointment
        private void Appointment_Click(object sender, EventArgs e)
        {
            FormPatient = 0;
            FormDiagnosis = 0;
            if (FormAppointment == 0) {
                FormAppointment = 1;
                OpenChildForm(new Forms_Content_Receptionist.Appointment(), sender);
            }
        }

        //Patient
        private void BtnPatient_Click(object sender, EventArgs e)
        {
            FormAppointment = 0;
            FormDiagnosis = 0;
            if (FormPatient == 0)
            {
                FormPatient = 1;
                //OpenChildForm(new Forms_Content_Receptionist.Patient(), sender);
            }
        }

        //Diagnosis
        private void Diagnosis_Click(object sender, EventArgs e)
        {
            FormPatient = 0;
            FormAppointment = 0;
            if (FormDiagnosis == 0)
            {
                FormDiagnosis = 1;
                OpenChildForm(new Forms_Content_Doctor.Diagnosis(), sender);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
