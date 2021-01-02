select 
	GradeId, 
	StyleId, 
	Grade, 
	BeltDescription 
from Grade
where StyleId = %StyleId%