update Member
set 
    AddressId = %AddressId%,
    ClassId = %ClassId%,
    Forenames = '%Forenames%',
    Surname = '%Surname%',
    StartDate = '%StartDate%',
    StatusId = %StatusId%,
    Note = '%Note%',
    DateOfBirth = '%DateOfBirth%'
where MemberId = %MemberId%