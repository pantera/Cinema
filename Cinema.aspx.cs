using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Cinema.Entities.Data;

namespace Cinema
{
    public partial class _Cinema : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<ReservationView> reservationList;
            UserView currentUser;
            String currentMenu = null;

            List<int> slotList = new List<int>();

            public Cinema()
            {
                this.currentMenu="Main";

                reservationList = new List<ReservationView>();
                currentUser = null;
                InitializeComponent();
        
            }

           private void BackToMainMenuButton_Click(object sender, EventArgs e) {
            Button1.Text = "Read Trace File";
            Button2.Text = "Client Menu";
            Button3.Text = "Server Menu";

            Button1.Visible = true;
            Button2.Visible = true;
            Button3.Visible = true;

            Button1.Enabled = true;
            Button2.Enabled = true;
            Button3.Enabled = true;

            MenuLabel.Text = "Main Menu";
            this.currentMenu = "Main";
            BackToMainMenuButton.Enabled = false;
            Label1.Text = "";
            Label1.Visible = false;
            CreateReservationGroupBox.Visible = false;
            ConnectDisconnectButton.Visible = false;
            currentMasterName = null;
            launchedClients.Clear();
            launchedServers.Clear();
            users.Clear();
            servers.Clear();
        }
        }

        
    }
}
