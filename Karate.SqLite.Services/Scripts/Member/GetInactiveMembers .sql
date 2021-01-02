Select 
    m.MemberId,
    m.Forenames,
    m.Surname,
    m.ClassId,
    m.DateOfBirth,
    m.StartDate,
    l.ExpiryDate
from Member m 
left join Licence l on l.MemberId = m.MemberId 
join Status s on s.StatusId = m.StatusId
where s.Name = 'Inactive'