create database g464_Iln_Ala
go

use g464_Iln_Ala
go

alter table Staff
add constraint PK_staff primary key (StaffID)
go

alter table Position
add constraint PK_position primary key (PositionID)
go

alter table TimeSheet
add constraint PK_timesheet primary key (TimesheetID)
go

alter table Staff
add constraint FK_position Foreign key (PositionID)
references Position (PositionID)
go

alter table TimeSheet
add constraint FK_staff Foreign key (StaffID)
references Staff (StaffID)
go
