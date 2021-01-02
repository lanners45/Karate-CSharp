select 'TotalMembers' as Status, count(*)  as Total
from Member m
UNION all
select s.Name, count(*) from Member m
join Status  s on s.StatusId = m.StatusId
group by s.StatusId
UNION all
select 'ExpiredLicence', count(*) from Member m 
join Licence l on m.MemberId = l.MemberId 
join Status s on s.StatusId = m.StatusId 
where s.Name = 'Active' and l.ExpiryDate < date('now')