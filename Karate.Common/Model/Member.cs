using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Karate.Common.Model;

namespace Karate.Common.Model
{
	public class Member
	{
		public int AddressId { get; set; }
		public int MemberId { get; set; }
		public int ClassId { get; set; }
		public string Forenames { get; set; }
		public string Surname { get; set; }
		public DateTime StartDate { get; set; }
		public Int16 StatusId { get; set; }
		public DateTime InactiveDate { get; set; }
		public string Note { get; set; }
		public DateTime DateOfBirth { get; set; }
		public Address Address { get; set; }
		public ClassItem ClassItem { get; set; }
		public Licence Licence { get; set; }
		public string TelephoneNumber { get; set; }
		public string MobileNumber { get; set; }
		public string EmailAddress { get; set; }
		public string GetFullName
		{
			get { return Forenames + " " + Surname; }
		}

		public Member()
		{
			Address = new Address();
			ClassItem = new ClassItem();
			Licence = new Licence();
		}
	}
}
