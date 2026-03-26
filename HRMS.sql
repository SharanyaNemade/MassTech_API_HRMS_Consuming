use HRMS;


SET IDENTITY_INSERT EmployeeReports ON;

INSERT INTO EmployeeReports (UserId, Name, Department, PhoneNumber, EmailId) VALUES  
(1, 'Krish Kheloji', 'IT', '9876543210', 'krish@gmail.com'),
(2, 'Suraj K', 'HR', '8765432109', 'suraj@gmail.com'),
(3, 'Nitesh N', 'Finance', '7654321098', 'nitesh@gmail.com');+

-- SET IDENTITY_INSERT EmployeeReports OFF;


SELECT * FROM EmployeeReports;




SET IDENTITY_INSERT AttendanceReports OFF;


INSERT INTO AttendanceReports 
(EmployeeName, Date, CheckIn, CheckOut, LunchIn, LunchOut, Status, WorkingHours, OvertimeHours, BreakHours, Late, ProductionHours)
VALUES  
('Krish Kheloji', '2025-03-01', '09:00 AM', '06:00 PM', '01:00 PM', '01:30 PM', 'Present', 8, 1, 0.5, 0, 7.5),  
('Suraj K', '2025-03-01', '09:30 AM', '06:30 PM', '01:00 PM', '01:30 PM', 'Present', 8, 0.5, 0.5, 1, 7);


delete from AttendanceReports
where AttendanceId = 12;


SELECT * FROM AttendanceReports;



ALTER TABLE AttendanceReports
ALTER COLUMN CheckIn NVARCHAR(20) NULL;

ALTER TABLE AttendanceReports
ALTER COLUMN CheckOut NVARCHAR(20) NULL;

ALTER TABLE AttendanceReports
ALTER COLUMN LunchIn NVARCHAR(20) NULL;

ALTER TABLE AttendanceReports
ALTER COLUMN LunchOut NVARCHAR(20) NULL;





SET IDENTITY_INSERT LeaveReports OFF;



INSERT INTO LeaveReports 
(UserName, LeaveType, StartDate, EndDate, Days, Reason, ApprovedBy, Status, StatusHistory)
VALUES
('Krish Kheloji', 'Paid Leave', '2025-03-13', '2025-03-15', 3, 'Personal', 'Manager', 'Approved', 'Approved on 13-03-2025'),
('Suraj K', 'Sick Leave', '2025-03-10', '2025-03-11', 2, 'Fever', 'Manager', 'Pending', 'Pending'),
('Nitesh N', 'Casual Leave', '2025-03-05', '2025-03-05', 1, 'Work', 'Manager', 'Rejected', 'Rejected on 05-03-2025');





SELECT * FROM LeaveReports;






INSERT INTO ProjectReports 
(ProjectName, Leader, Members, Deadline, Priority, Status)
VALUES  
('Hospital', 'Krish', 'A,B,C', '2025-02-20', 'High', 'Active'),  
('Restaurant', 'Krish', 'D,E', '2025-02-27', 'Medium', 'Active'),  
('Estate', 'Krish', 'F,G', '2025-03-13', 'High', 'Inactive');




SELECT * FROM ProjectReports;





INSERT INTO PayslipReports 
(Name, PaidAmount, PaidMonth, PaidYear)
VALUES  
('Krish Kheloji', 50000, 'March', 2025),  
('Suraj K', 45000, 'March', 2025),  
('Nitesh N', 40000, 'March', 2025);




SELECT * FROM PayslipReports;




INSERT INTO TaskReports 
(TaskName, ProjectName, DueDate, Priority, Status)
VALUES  
('Hospital Task 1', 'Hospital', '2025-02-28', 'Medium', 'In Progress'),  
('Restaurant Task 1', 'Restaurant', '2025-02-25', 'High', 'Completed'),  
('Hospital Task 2', 'Hospital', '2025-02-20', 'High', 'Overdue');




SELECT * FROM TaskReports;




INSERT INTO TaskReports 
(TaskName, ProjectName, DueDate, Priority, Status)
VALUES
('Hospital Task 1', 'Hospital', '2025-02-28', 'Medium', 'In Progress'),
('Restaurant Task 1', 'Restaurant', '2025-02-25', 'High', 'Completed'),
('Hospital Task 2', 'Hospital', '2025-02-20', 'High', 'Overdue');





INSERT INTO DailyReports 
(Name, Date, Department, Status)
VALUES
('Krish Kheloji', '2025-03-01', 'IT', 'Present'),
('Suraj K', '2025-03-01', 'HR', 'Present'),
('Nitesh N', '2025-03-01', 'Finance', 'Absent');




SELECT * FROM DailyReports;