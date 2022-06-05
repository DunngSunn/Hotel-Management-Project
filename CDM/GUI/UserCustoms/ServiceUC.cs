using BUS.Bussiness;
using DAO;
using DAO.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GUI.UserControls
{
    public partial class ServiceUC : UserControl
    {
        public ServiceUC()
        {
            InitializeComponent();
            InitializeServiceDatagridView(DataClass.Services);
            InitializeServiceTypeDatagridView(DataClass.ServiceTypes);
        }

        #region Events

        private void ServiceGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == 4)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = 25;
                var h = 25;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.edit, new Rectangle(x, y, w, h));
                e.Handled = true;
            }

            if (e.ColumnIndex == 5)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = 25;
                var h = 25;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.delete_button, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void ServiceGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == 4)
            {
                if (ServiceGridView.Rows[e.RowIndex].ReadOnly == true)
                {
                    ServiceGridView.Rows[e.RowIndex].ReadOnly = false;
                }
                else
                {
                    ServiceGridView.Rows[e.RowIndex].ReadOnly = true;

                    var service = DataClass.Services.Find(s => s.ServiceID == (int)ServiceGridView.Rows[e.RowIndex].Cells["ServiceID"].Value);

                    var sName = (string)ServiceGridView.Rows[e.RowIndex].Cells["ServiceName"].Value;
                    var sPrice = Extension.TryParseLong(ServiceGridView.Rows[e.RowIndex].Cells["ServicePrice"].Value.ToString());
                    var sType = (string)ServiceGridView.Rows[e.RowIndex].Cells["ServiceType"].Value;
                    var sTypeID = GetIDOfServiceType(sType);
                    if (sTypeID != -1)
                    {
                        var result = ServiceBUS.EditService(service.ServiceID, sTypeID, sName, sPrice);
                        if (result)
                        {
                            MessageBox.Show("Sửa thành công.", "Cảnh báo", MessageBoxButtons.OK);

                            service.ServiceName = sName;
                            service.ServicePrice = sPrice;
                            service.ServiceTypeID = sTypeID;
                            service.ServiceTypeName = sType;
                        }
                        else
                        {
                            MessageBox.Show("Sửa không thành công.", "Cảnh báo", MessageBoxButtons.OK);
                            ServiceGridView.Rows[e.RowIndex].Cells["ServiceName"].Value = service.ServiceName;
                            ServiceGridView.Rows[e.RowIndex].Cells["ServicePrice"].Value = service.ServicePrice;
                            ServiceGridView.Rows[e.RowIndex].Cells["ServiceType"].Value = service.ServiceTypeName;
                        }
                    }
                }
            }

            if (e.ColumnIndex == 5)
            {
                var result = MessageBox.Show("Bạn có muốn xoá dịch vụ này này không?", "Xoá dịch vụ", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var service = DataClass.Services.Find(s => s.ServiceID == (int)ServiceGridView.Rows[e.RowIndex].Cells["ServiceID"].Value);
                    var result1 = ServiceBUS.DeleteService(service.ServiceID);
                    if (result1)
                    {
                        MessageBox.Show("Xoá thành công.", "Cảnh báo", MessageBoxButtons.OK);

                        DataClass.Services.Remove(service);
                        ServiceGridView.Rows.RemoveAt(e.RowIndex);
                    }
                    else
                    {
                        MessageBox.Show("Xoá không thành công.", "Cảnh báo", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void ServiceTypeGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == 2)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = 25;
                var h = 25;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.edit, new Rectangle(x, y, w, h));
                e.Handled = true;
            }

            if (e.ColumnIndex == 3)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = 25;
                var h = 25;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.delete_button, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void ServiceTypeGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == 2)
            {
                if (ServiceTypeGridView.Rows[e.RowIndex].ReadOnly == true)
                {
                    ServiceTypeGridView.Rows[e.RowIndex].ReadOnly = false;
                }
                else
                {
                    ServiceTypeGridView.Rows[e.RowIndex].ReadOnly = true;

                    var serviceType = DataClass.ServiceTypes.Find(s => s.ServiceTypeID == (int)ServiceTypeGridView.Rows[e.RowIndex].Cells["ServiceTypeID"].Value);

                    var sName = (string)ServiceTypeGridView.Rows[e.RowIndex].Cells["ServiceTypeName"].Value;

                    var result = ServiceTypeBUS.EditServiceType(serviceType.ServiceTypeID, sName);
                    if (result)
                    {
                        MessageBox.Show("Sửa thành công.", "Cảnh báo", MessageBoxButtons.OK);

                        serviceType.ServiceTypeName = sName;
                        foreach (var service in DataClass.Services)
                        {
                            if (service.ServiceTypeID == serviceType.ServiceTypeID)
                            {
                                service.ServiceTypeName = sName;
                            }
                        }

                        InitializeServiceDatagridView(DataClass.Services);
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công.", "Cảnh báo", MessageBoxButtons.OK);
                        ServiceTypeGridView.Rows[e.RowIndex].Cells["ServiceTypeName"].Value = serviceType.ServiceTypeName;
                    }
                }
            }

            if (e.ColumnIndex == 3)
            {
                var result = MessageBox.Show("Bạn có muốn xoá loại dịch vụ này không?", "Xoá loại dịch vụ", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var serviceType = DataClass.ServiceTypes.Find(s => s.ServiceTypeID == (int)ServiceTypeGridView.Rows[e.RowIndex].Cells["ServiceTypeID"].Value);
                    var result1 = ServiceTypeBUS.DeleteServiceType(serviceType.ServiceTypeID);
                    if (result1)
                    {
                        MessageBox.Show("Xoá thành công.", "Cảnh báo", MessageBoxButtons.OK);

                        var listRemove = new List<Service>();
                        foreach (var service in DataClass.Services)
                        {
                            if (service.ServiceTypeID == serviceType.ServiceTypeID)
                            {
                                listRemove.Add(service);
                            }
                        }
                        foreach (var item in listRemove)
                        {
                            DataClass.Services.Remove(item);
                        }

                        DataClass.ServiceTypes.Remove(serviceType);
                        ServiceTypeGridView.Rows.RemoveAt(e.RowIndex);

                        InitializeServiceDatagridView(DataClass.Services);
                    }
                    else
                    {
                        MessageBox.Show("Xoá không thành công.", "Cảnh báo", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void SearchText_TextChanged(object sender, EventArgs e)
        {
            var result = DataClass.Services.Where(s => s.ServiceName.Trim().ToLower().Contains(SearchText.Text.Trim().ToLower())).ToList();
            InitializeServiceDatagridView(result);
        }

        private void AddServiceType_Click(object sender, EventArgs e)
        {
            if (AddServiceType.Text.Equals("Thêm"))
            {
                ServiceTypeText.Enabled = true;
                ServiceTypeText.Text = string.Empty;
                AddServiceType.Text = "Hoàn tất";
            }
            else
            {
                ServiceTypeText.Enabled = false;

                var serviceTypeName = ServiceTypeText.Text;
                if (serviceTypeName.Equals(string.Empty))
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin.", "Cảnh báo", MessageBoxButtons.OK);
                }
                else
                {
                    var serviceType = ServiceTypeBUS.AddServiceType(serviceTypeName);
                    if (serviceType != null)
                    {
                        DataClass.ServiceTypes.Add(serviceType);
                        var result = MessageBox.Show("Thêm thành công.", "Cảnh báo", MessageBoxButtons.OK);
                        if (result == DialogResult.OK)
                        {
                            InitializeServiceDatagridView(DataClass.Services);
                            SetRowInServiceTypeDatagridView(serviceType);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công.", "Cảnh báo", MessageBoxButtons.OK);
                    }
                }

                AddServiceType.Text = "Thêm";
            }
        }

        private void AddService_Click(object sender, EventArgs e)
        {
            if (AddService.Text.Equals("Thêm"))
            {
                ServiceNameText.Enabled = true;
                PriceText.Enabled = true;
                ServiceTypeCb.Enabled = true;
                ServiceNameText.Text = string.Empty;
                PriceText.Text = string.Empty;
                ServiceTypeCb.Items.Clear();
                foreach (var item in DataClass.ServiceTypes)
                {
                    ServiceTypeCb.Items.Add(item.ServiceTypeName);
                }
                ServiceTypeCb.SelectedIndex = 0;
                AddService.Text = "Hoàn tất";
            }
            else
            {
                ServiceNameText.Enabled = false;
                PriceText.Enabled = false;
                ServiceTypeCb.Enabled = false;

                var serviceNameText = ServiceNameText.Text;
                var priceText = Extension.TryParseLong(PriceText.Text);
                var serviceTypeName = ServiceTypeCb.SelectedItem.ToString();
                var serviceTypeID = GetIDOfServiceType(serviceTypeName);

                if (serviceNameText.Equals(string.Empty) || priceText.Equals(string.Empty))
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin.", "Cảnh báo", MessageBoxButtons.OK);
                }
                else
                {
                    var service = ServiceBUS.AddService(serviceTypeID, serviceNameText, priceText, serviceTypeName);
                    if (service != null)
                    {
                        DataClass.Services.Add(service);
                        var result = MessageBox.Show("Thêm thành công.", "Cảnh báo", MessageBoxButtons.OK);
                        if (result == DialogResult.OK)
                        {
                            SetRowInServiceDatagridView(service);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công.", "Cảnh báo", MessageBoxButtons.OK);
                    }
                }

                AddService.Text = "Thêm";
            }
        }

        #endregion

        #region Other functions

        private void InitializeServiceDatagridView(List<Service> listService)
        {
            ServiceGridView.Rows.Clear();
            foreach (var service in listService)
            {
                SetRowInServiceDatagridView(service);
            }
        }

        private void InitializeServiceTypeDatagridView(List<ServiceType> listServiceType)
        {
            ServiceTypeGridView.Rows.Clear();
            foreach (var serviceType in listServiceType)
            {
                SetRowInServiceTypeDatagridView(serviceType);
            }
        }

        private void SetRowInServiceDatagridView(Service service)
        {
            var rowID = ServiceGridView.Rows.Add();
            var row = ServiceGridView.Rows[rowID];
            row.Cells["ServiceID"].Value = service.ServiceID;
            row.Cells["ServiceName"].Value = service.ServiceName;
            row.Cells["ServicePrice"].Value = service.ServicePrice;
            ComboBox cb = new ComboBox();
            foreach (var type in DataClass.ServiceTypes)
            {
                cb.Items.Add(type.ServiceTypeName);
            }
            ((DataGridViewComboBoxColumn)ServiceGridView.Columns["ServiceType"]).DataSource = cb.Items;
            row.Cells["ServiceType"].Value = service.ServiceTypeName;
        }

        private void SetRowInServiceTypeDatagridView(ServiceType serviceType)
        {
            var rowID = ServiceTypeGridView.Rows.Add();
            var row = ServiceTypeGridView.Rows[rowID];
            row.Cells["ServiceTypeID"].Value = serviceType.ServiceTypeID;
            row.Cells["ServiceTypeName"].Value = serviceType.ServiceTypeName;
        }

        private int GetIDOfServiceType(string nameServiceType)
        {
            var result = -1;
            var serviceType = DataClass.ServiceTypes.Find(s => s.ServiceTypeName.Equals(nameServiceType));
            return serviceType != null ? serviceType.ServiceTypeID : result;
        }

        #endregion
    }
}
