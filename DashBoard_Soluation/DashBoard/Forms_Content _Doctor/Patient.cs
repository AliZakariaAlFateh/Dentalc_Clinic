using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashBoard.Forms_Content_Doctor
{
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }

        private void Appointment_Load(object sender, EventArgs e)
        {
            List<AppointmentClass> Appointment_List = new List<AppointmentClass>
            {
                new AppointmentClass {Receptionist_SSN=123455,PatientID=1222,Price=400,Status="New",Date="11/23/2023",Time="9:69 pm"},
                new AppointmentClass {Receptionist_SSN=123455,PatientID=1222,Price=400,Status="New",Date="11/23/2023",Time="9:69 pm"},
                new AppointmentClass {Receptionist_SSN=123455,PatientID=1222,Price=400,Status="New",Date="11/23/2023",Time="9:69 pm"},
                new AppointmentClass {Receptionist_SSN=123455,PatientID=1222,Price=400,Status="New",Date="11/23/2023",Time="9:69 pm"}
            };

            dataGridView1.DataSource = Appointment_List;
        }
    }
}
