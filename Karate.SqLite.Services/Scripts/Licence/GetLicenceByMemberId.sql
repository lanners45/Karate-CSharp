select 
    LicenceId,
    MemberId,
    ExpiryDate
from Licence
where MemberId = %MemberId%