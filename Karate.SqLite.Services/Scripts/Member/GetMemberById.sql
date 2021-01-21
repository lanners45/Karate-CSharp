select 
	m.MemberId,
	m.Forenames,
	m.Surname,
	m.ClassId,
	m.DateOfBirth,
	m.StatusId,
	m.InactiveDate,
	m.AddressId,
	m.Note,
	m.StartDate,
	m.TelephoneNumber,
	m.MobileNumber,
	m.EmailAddress
from Member m
where m.MemberId = %MemberId%