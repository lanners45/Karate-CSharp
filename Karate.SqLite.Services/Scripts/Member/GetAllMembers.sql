Select 
    m.MemberId,
    m.Forenames,
    m.Surname,
    m.ClassId,
    m.DateOfBirth,
    m.StatusId,
    m.InactiveDate,
    m.AddressId,
    m.Note,
    m.StartDate
from Member m 
join Status s on s.StatusId = m.StatusId