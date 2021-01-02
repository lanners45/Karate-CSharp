select 
    MemberId,
    GradeId,
    DateAchieved,
    GradingId,
    StyleId,
    Grade,
    BeltDescription
from Grading g
join Grade grd on grd.GradeId = g.GradeId
where g.MemberId = %MemberId%