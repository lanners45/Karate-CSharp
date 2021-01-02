select 
  mb.MemberId,
  b.BadgeId,
  b.BadgeType,
  b.BadgeDescription
from MemberBadge mb 
join Badge b on mb.BadgeId = b.BadgeId 
where mb.MemberId = %memberId%