using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Windows.Forms;

using Tourism.Entities;

namespace Tourism.Forms
{
    public partial class GetInfoForm : Form
    {
        private readonly TextBox[] infoText;
        private List<IEntity> vouchersInfo;
        private int _index = 0;

        public GetInfoForm(DataTable table)
        {
            InitializeComponent();
            infoText = new TextBox[]
            {
                purchaseDate, fullName, phone,
                beginRoute, finalRoute, dateOfShipment,
                hotel, hotelPrice
            };

            LoadVouchersInfo(table);
            CheckIndex();
            LoadVoucherInfo();
            this.Focus();
        }

        private void MoveBack_Click(object sender, EventArgs e)
        {
            _index--;
            CheckIndex();
            MoveBack();
        }

        private void MoveNext_CLick(object sender, EventArgs e)
        {
            _index++;
            CheckIndex();
            MoveNext();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MoveNext()
        {
            LoadVoucherInfo();
        }

        private void MoveBack()
        {
            LoadVoucherInfo();
        }

        private void LoadVouchersInfo(DataTable tableWithClients)
        {
            vouchersInfo = new List<IEntity>();

            for (var i = 0; i < tableWithClients.Rows.Count; i++)
            {
                VoucherInfo voucher = new VoucherInfo();
                voucher.SetValues(tableWithClients.Rows[i].ItemArray);
                vouchersInfo.Add(voucher);
            }
        }

        private void LoadVoucherInfo()
        {
            VoucherInfo voucher = (VoucherInfo)vouchersInfo[_index];
            for (var i = 0; i < infoText.Length; i++)
            {
                PropertyInfo[] properties = voucher.GetType().GetProperties();
                if (properties[i].PropertyType.Name == "DateTime")
                    infoText[i].Text = $"{properties[i].GetValue(voucher):dd.MM.yyyy}";
                else
                    infoText[i].Text = properties[i].GetValue(voucher).ToString();
            }
        }

        private void CheckIndex()
        {
            if (vouchersInfo.Count == 1)
            {
                moveBackBut.Enabled = false;
                moveNextBut.Enabled = false;
            }
            else
            {
                if (_index == 0)
                {
                    moveBackBut.Enabled = false;
                    moveNextBut.Enabled = true;
                }
                else if (_index == (vouchersInfo.Count - 1))
                {
                    moveNextBut.Enabled = false;
                    moveBackBut.Enabled = true;
                }
                else
                {
                    moveBackBut.Enabled = true;
                    moveNextBut.Enabled = true;
                }
            }
        }
    }
}
