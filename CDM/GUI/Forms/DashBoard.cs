using GUI.UserControls;
using System;
using System.Windows.Forms;

namespace GUI.Forms
{
    public partial class DashBoard : Form
    {
        #region Variables

        private const int LeftPixel = 20;

        public RoomManagerUC RoomManagerUC { get; set; }
        public CustomerUC CustomerUC { get; set; }
        public EmployeeUC EmployeeUC { get; set; }
        public ServiceUC ServiceUC { get; set; }
        public BillUC BillUC { get; set; }
        public UserControl CurrentUserControl { get; set; }

        #endregion

        public DashBoard()
        {
            InitializeComponent();
            Initialize();
        }

        #region Events

        private void BtnRoom_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btnRoom.Left + LeftPixel;

            ShowUserControl(RoomManagerUC);
        }

        private void BtnCustomer_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btnCustomer.Left + LeftPixel;

            ShowUserControl(CustomerUC);
        }

        private void BtnEmployee_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btnEmployee.Left + LeftPixel;

            ShowUserControl(EmployeeUC);
        }

        private void BtnService_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btnService.Left + LeftPixel;

            ShowUserControl(ServiceUC);
        }

        private void BtnBill_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btnBill.Left + LeftPixel;

            ShowUserControl(BillUC);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToLongTimeString();
        }

        #endregion

        #region Functions

        private void ShowUserControl(UserControl ucToShow)
        {
            if (CurrentUserControl != ucToShow)
            {
                CurrentUserControl = ucToShow;
                CurrentUserControl.BringToFront();
            }
        }

        private void Initialize()
        {
            DataClass.InitializeData();

            RoomManagerUC = new RoomManagerUC();
            CustomerUC = new CustomerUC();
            EmployeeUC = new EmployeeUC();
            ServiceUC = new ServiceUC();
            BillUC = new BillUC();

            MainPanel.Controls.Add(RoomManagerUC);
            MainPanel.Controls.Add(CustomerUC);
            MainPanel.Controls.Add(EmployeeUC);
            MainPanel.Controls.Add(ServiceUC);
            MainPanel.Controls.Add(BillUC);

            CurrentUserControl = RoomManagerUC;
            CurrentUserControl.Visible = true;
        }

        #endregion


    }
}
