using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Karate.Common.Model;
using Karate.Forms.MemberForms.Address;
using Karate.SqLite.Services;

namespace Karate.Forms
{
	public partial class MemberForm : Form
	{
		private Member _member;
		protected Boolean IsNewMember = true;

		public MemberForm()
		{
			InitializeComponent();

			var addressList = AddressData.GetAddresses();
			AddressComboBox.DataSource = addressList;
			AddressComboBox.DisplayMember = "Name";
		}

		public void PopulateForm(ActiveMemberSummary activeMemberSummary) 
		{
			_member = Karate.SqLite.Services.MemberData.GetMemberById(activeMemberSummary);
				_member.Address = SqLite.Services.AddressData.GetAddressById(new Address() { AddressId = _member.AddressId });
				_member.ClassItem = SqLite.Services.ClassData.GetClassItems().Single(item => item.ClassId == _member.ClassId);
				_member.Licence = SqLite.Services.MemberData.GetLicenceById(_member);

				ClassComboBox.Text = _member.ClassItem.Name;
				FirstNameTextBox.Text = _member.Forenames;
				LastNameTextBox.Text = _member.Surname;
				AddressTextBox.Text = _member.Address.Name;
				StartDatePicker.Value = _member.StartDate;
				BirthDatePicker.Value = _member.DateOfBirth;

				if (_member.Licence != null && _member.Licence.ExpiryDate.HasValue)
				{
					ExpiryDatePicker.Value = _member.Licence.ExpiryDate.Value;
				}

				LandlineTextBox.Text = _member.TelephoneNumber;
				MobileNumberTextBox.Text = _member.MobileNumber;
				EmailAdressTextBox.Text = _member.EmailAddress;
				NotesTextBox.Text = _member.Note;

			IsNewMember = false;
			ExpiryDatePicker.Enabled = false;
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		public Member GetData()
		{
			Member member = new Member();
			if (_member != null)
			{
				member.MemberId = _member.MemberId;
			}
			if (AddressTextBox.TextLength>0)
            {
				member.Address = new Address();
				member.Address.Name = AddressTextBox.Text;
            }
			else
            {
				member.Address = ((Address)AddressComboBox.SelectedItem);
				member.AddressId = member.Address.AddressId;
			}

			member.Forenames = FirstNameTextBox.Text;
			member.Surname = LastNameTextBox.Text;
			member.TelephoneNumber = LandlineTextBox.Text;
			member.MobileNumber = MobileNumberTextBox.Text;
			member.EmailAddress = EmailAdressTextBox.Text;
			member.StartDate = StartDatePicker.Value;
			member.DateOfBirth = BirthDatePicker.Value;

			member.Note = NotesTextBox.Text;
/*			if (ExpiryDatePicker.Enabled)
			{
				_member.ExpiryDate = ExpiryDatePicker.Value;
			}*/

			member.StatusId = 1;  // to update
			member.ClassId = (int)ClassComboBox.SelectedValue;

			return member;

		}

		private void MemberForm_Load(object sender, EventArgs e)
		{
			List<ClassItem> classes = ClassData.GetClassItems();

			ClassComboBox.DataSource = classes;
			ClassComboBox.DisplayMember = "Name";
			ClassComboBox.ValueMember = "ClassId";
		}

        private void BirthDatePicker_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (BirthDatePicker.Value >= DateTime.Now)
                SaveButton.Enabled = false;
            else
                SaveButton.Enabled = true;
        }

        private void AddressSearchButton_Click(object sender, EventArgs e)
        {
			using (SearchAddressForm searchAddressForm = new SearchAddressForm())
			{
				searchAddressForm.ShowDialog();
			}
        }

        private void AddressComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

        }
    }
}
