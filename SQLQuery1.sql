﻿SELECT * from [10 Offer] o
--join [20 selection] s on o.OID=s.OID
join [50 XForm] f on o.OID=f.OID
join [70 Upload] u on u.[UID]=f.[UID]
where o.OID=2

SELECT * from [10 Offer] o
join [20 selection] s on o.OID=s.OID
--join [40 XForm] f on o.OID=f.OID
--join [50 Upload] u on u.[UID]=f.[UID]
--where o.OID=2

	