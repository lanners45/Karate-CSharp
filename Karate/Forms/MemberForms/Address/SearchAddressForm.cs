using Karate.SqLite.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karate.Forms.MemberForms.Address
{
    public partial class SearchAddressForm : Form
    {
        
        public SearchAddressForm()
        {
            InitializeComponent();

            var addressList = AddressData.GetAddresses();

            AddressComboBox.DataSource = addressList;
            AddressComboBox.DisplayMember = "Name";
        }
    }
}
