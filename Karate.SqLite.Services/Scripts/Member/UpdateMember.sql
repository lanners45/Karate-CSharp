update Member
set 
    AddressId = %AddressId%,
    ClassId = %ClassId%,
    Forenames = '%Forenames%',
    Surname = '%Surname%',
    StartDate = '%StartDate%',
    StatusId = %StatusId%,
    Note = '%Note%',
    DateOfBirth = '%DateOfBirth%',
    TelephoneNumber = '%TelephoneNumber%',
    MobileNumber = '%MobileNumber%',
    EmailAddress = '%EmailAddress%'
where MemberId = %MemberId%