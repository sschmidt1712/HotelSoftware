using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MainForm : Form
    {
        public MainForm()
            //test
        {
            InitializeComponent();
        }

        int page = 0; //Use this to tell which action we want to perform on the drop buttons 
                      //0 = Reservations ; 1 = Room Management ; 2 = Billing ; 3 = Clients ; 4 = Employee Section

        private void roomManagementBtn_Click(object sender, EventArgs e)
        {
            page = 1;

            //Change the font style
            this.roomManagementBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billingBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeSectionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            //Change drop buttons text
            dropBtn1.Visible = true;
            dropBtn2.Visible = true;
            dropBtn3.Visible = true;
            dropBtn4.Visible = true;
            dropBtn5.Visible = false;
            dropBtn1.Text = "Check Room Status";
            dropBtn2.Text = "Clean Rooms";
            dropBtn3.Text = "Price Rooms";
            dropBtn4.Text = "Change Room Info";

        }

        private void billingBtn_Click(object sender, EventArgs e)
        {
            page = 2;

            //Change the font style
            this.billingBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomManagementBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeSectionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            //Change drop buttons text
            dropBtn1.Visible = true;
            dropBtn2.Visible = true;
            dropBtn3.Visible = true;
            dropBtn4.Visible = true;
            dropBtn5.Visible = true;
            dropBtn1.Text = "Check out Guest";
            dropBtn2.Text = "Guests Due Out";
            dropBtn3.Text = "Daily Income";
            dropBtn4.Text = "Check in Guest";
            dropBtn5.Text = "Guests Due In";
        }

        private void clientsBtn_Click(object sender, EventArgs e)
        {
            page = 3;

            //Change the font style
            this.clientsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomManagementBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billingBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeSectionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            //Change drop buttons text
            dropBtn1.Visible = true;
            dropBtn2.Visible = true;
            dropBtn3.Visible = true;
            dropBtn4.Visible = false;
            dropBtn5.Visible = false;
            dropBtn1.Text = "New Client";
            dropBtn2.Text = "Find Client";
            dropBtn3.Text = "Edit Client Information";
        }

        private void employeeSectionBtn_Click(object sender, EventArgs e)
        {
            page = 4;

            //Change the font style
            this.employeeSectionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.roomManagementBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billingBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            //Change drop buttons text
            dropBtn1.Visible = true;
            dropBtn2.Visible = true;
            dropBtn3.Visible = true;
            dropBtn4.Visible = true;
            dropBtn5.Visible = true;
            dropBtn1.Text = "Clock In";
            dropBtn2.Text = "Clock Out";
            dropBtn3.Text = "Start Meal";
            dropBtn4.Text = "End Meal";
            dropBtn5.Text = "Edit Employee Information";
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close(); //Close application
        }

        private void reservationsBtn_Click(object sender, EventArgs e)
        {
            page = 0;

            //Change the font style
            this.employeeSectionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomManagementBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billingBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            //Change drop buttons text
            dropBtn1.Visible = true;
            dropBtn2.Visible = true;
            dropBtn3.Visible = true;
            dropBtn4.Visible = false;
            dropBtn5.Visible = false;
            dropBtn1.Text = "New Reservation";
            dropBtn2.Text = "Edit Reservation";
            dropBtn3.Text = "Cancel Reservation";

        }

    }
}
