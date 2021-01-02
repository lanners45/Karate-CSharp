insert into Member
(
	Forenames,
	Surname,
	Classid,
	DateofBirth,
	StatusId,
	AddressId,
	Note,
	StartDate
)
values
(
	'%Forenames%',
	'%Surname%',
	%Classid%,
	'%DateofBirth%',
	%StatusId%,
	%AddressId%,
	'%Note%',
	'%StartDate%'
)

return  last_insert_rowid();
