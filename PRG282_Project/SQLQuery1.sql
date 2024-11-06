create DataBase  PRG282_Project

use PRG282_Project

create Table Students
(
Student_ID int Primary Key not null,
Student_Name varchar(40),
Student_Surname varchar(40),
Course varchar(40)

)

Insert Into Students
Values

(601311,'Kyle','Haynes-Smart','PRG282'),
(577862,'Jan','Saayman','PRG282'),
(600546,'Kai','Hinterholzer','PRG282'),
(600102,'Amber','Smith','WPR281'),
(693184,'John','Stead','LPR281');

