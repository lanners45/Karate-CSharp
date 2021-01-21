using Karate.Common.Model;
using Karate.SqLite.Services.enumeration;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace Karate.SqLite.Services
{
	public class MemberData 
	{
		public static List<ActiveMemberSummary> GetActiveSummary()
		{
			List<ActiveMemberSummary> memberList = new List<ActiveMemberSummary>();
			using (SQLiteCommand command = new SQLiteCommand())
			{
				command.Connection = SqLiteConnectionInstance.Instance.GetConnection;
				command.CommandType = CommandType.Text;
				command.CommandText = ScriptManager.ReadScript(ScriptItems.GetActiveMembers);
				using (SQLiteDataReader reader = command.ExecuteReader())
				{
					memberList.AddRange(ResourceBuilder.ParseReader<ActiveMemberSummary>(reader));
				}

				command.Connection.Close();
			}

			return memberList;
		}

		public static List<Member> GetAllMembers()
		{
			List<Member> memberList = new List<Member>();
			using (SQLiteCommand command = new SQLiteCommand())
			{
				command.Connection = SqLiteConnectionInstance.Instance.GetConnection;
				command.CommandType = CommandType.Text;
				command.CommandText = ScriptManager.ReadScript(ScriptItems.GetAllMembers);
				using (SQLiteDataReader reader = command.ExecuteReader())
				{
					memberList.AddRange(ResourceBuilder.ParseReader<Member>(reader));
				}

				command.Connection.Close();
			}
			return memberList;
		}

		public static List<Member> GetActiveMembers()
		{
			var membersList = new List<Member>();
			using (SQLiteCommand command = new SQLiteCommand())
			{
				command.Connection = SqLiteConnectionInstance.Instance.GetConnection;
				command.CommandType = CommandType.Text;
				command.CommandText = ScriptManager.ReadScript(ScriptItems.GetActiveMembers);
				using (SQLiteDataReader reader = command.ExecuteReader())
				{
					membersList.AddRange(ResourceBuilder.ParseReader<Member>(reader));
				}
			}

			membersList = PopulateMembers(membersList);

			return membersList;
		}

		public static List<Member> GetInactiveMembers()
		{
			List<Member> memberList = new List<Member>();
			using (SQLiteCommand command = new SQLiteCommand())
			{
				command.Connection = SqLiteConnectionInstance.Instance.GetConnection;
				command.CommandType = CommandType.Text;
				command.CommandText = ScriptManager.ReadScript(ScriptItems.GetInactiveMembers);
				using (SQLiteDataReader reader = command.ExecuteReader())
				{
					memberList.AddRange(ResourceBuilder.ParseReader<Member>(reader));
				}
			}
			return memberList;
		}

		public static Member GetMemberById(ActiveMemberSummary activeMemberSummary)
		{
			Member member = new Member();
			using (SQLiteCommand command = new SQLiteCommand())
			{
				command.Connection = SqLiteConnectionInstance.Instance.GetConnection;
				command.CommandType = CommandType.Text;
				SqlBuilder sqlBuilder = new SqlBuilder(ScriptManager.ReadScript(ScriptItems.GetMemberById));
				sqlBuilder.ParseSql(activeMemberSummary);
				command.CommandText = sqlBuilder.SQLText;
				using (SQLiteDataReader reader = command.ExecuteReader())
				{
					member = ResourceBuilder.ParseReader<Member>(reader).Single();
				}
			}

			return member;
		}


		public static void UpdateMember(Member member)
		{
			if (member.Address.AddressId <= 0)
			{
				member.AddressId = AddressData.InsertAddress(member.Address);
			}
			else
            {
				AddressData.UpdateAddress(member.Address);
            }

			using (SQLiteCommand command = new SQLiteCommand())
			{
				command.Connection = SqLiteConnectionInstance.Instance.GetConnection;
				command.CommandType = CommandType.Text;
				SqlBuilder sqlBuilder = new SqlBuilder(ScriptManager.ReadScript(ScriptItems.UpdateMember));
				sqlBuilder.ParseSql(member);
				command.CommandText = sqlBuilder.SQLText;
				command.ExecuteNonQuery();
			}
		}

		public static Licence GetLicenceById(Member member)
		{
			List<Licence> itemList = new List<Licence>();
			using (SQLiteCommand command = new SQLiteCommand())
			{
				command.Connection = SqLiteConnectionInstance.Instance.GetConnection;
				command.CommandType = CommandType.Text;
				SqlBuilder sqlBuilder = new SqlBuilder(ScriptManager.ReadScript(ScriptItems.GetLicenceByMemberId));
				sqlBuilder.ParseSql(member);
				command.CommandText = sqlBuilder.SQLText;
				using (SQLiteDataReader reader = command.ExecuteReader())
				{
					if (!reader.IsClosed)
					{
						itemList.AddRange(ResourceBuilder.ParseReader<Licence>(reader));
					}
				}
			}

			return itemList.OrderByDescending(item => item.ExpiryDate).FirstOrDefault();
		}

		public static int InsertMember(Member member)
		{
			if (member.Address.AddressId <= 0)
			{
				member.AddressId = AddressData.InsertAddress(member.Address);
			}

			using (SQLiteCommand command = new SQLiteCommand())
			{
				command.Connection = SqLiteConnectionInstance.Instance.GetConnection;
				command.CommandType = CommandType.Text;
				SqlBuilder sqlBuilder = new SqlBuilder(ScriptManager.ReadScript(ScriptItems.InsertMember));
				sqlBuilder.ParseSql(member);
				command.CommandText = sqlBuilder.SQLText;
				int Status = command.ExecuteNonQuery();
				command.CommandText = "select last_insert_rowid()";
				var insertedMemberId = command.ExecuteScalar();
				return int.Parse(insertedMemberId.ToString());
			}
		}
		
		public static void InactiveMember(Member member)
		{
			using (SQLiteCommand command = new SQLiteCommand())
			{
				command.Connection = SqLiteConnectionInstance.Instance.GetConnection;
				command.CommandType = CommandType.Text;
				SqlBuilder sqlBuilder = new SqlBuilder(ScriptManager.ReadScript(ScriptItems.InactiveMember));
				sqlBuilder.ParseSql(member);
				command.CommandText = sqlBuilder.SQLText;
				command.ExecuteNonQuery();
			}
		}

		public static void ReactiveMember(Member member)
		{
			using (SQLiteCommand command = new SQLiteCommand())
			{
				command.Connection = SqLiteConnectionInstance.Instance.GetConnection;
				command.CommandType = CommandType.Text;
				SqlBuilder sqlBuilder = new SqlBuilder(ScriptManager.ReadScript(ScriptItems.ReactiveMember));
				sqlBuilder.ParseSql(member);
				command.CommandText = sqlBuilder.SQLText;
				command.ExecuteNonQuery();
			}
		}

		public static void InsertMemberBadge(MemberBadge badgeItem)
		{
			using (SQLiteCommand command = new SQLiteCommand())
			{
				command.Connection = SqLiteConnectionInstance.Instance.GetConnection;
				command.CommandType = CommandType.Text;
				SqlBuilder sqlBuilder = new SqlBuilder(ScriptManager.ReadScript(ScriptItems.InsertMemberBadge));
				sqlBuilder.ParseSql(badgeItem);
				command.CommandText = sqlBuilder.SQLText;
				command.ExecuteNonQuery();
			}
		}

		private static List<Member> PopulateMembers(List<Member> memberList)
        {
			List<ClassItem> classList = ClassData.GetClassItems();

			foreach (Member member in memberList)
			{
				member.Licence = LicenseData.GetLicenseByMember(member).OrderByDescending(item => item.ExpiryDate).FirstOrDefault();
				member.ClassItem = classList.FirstOrDefault(item => item.ClassId == member.ClassId);
			}

			return memberList;
		}
	}
}

