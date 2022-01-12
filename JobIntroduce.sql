USE master  
GO


--创建数据库
If exists (Select * From sysdatabases Where name='Student1')
Drop Database JobIntroduce
GO

CREATE DATABASE JobIntroduce
ON Primary
(
   NAME =JobIntroduce_data,              
   FILENAME ='F:\c#\大作业\JobIntroduce.mdf',      
   SIZE =10,                    
   FILEGROWTH=10%                   
)    
LOG ON
(
   NAME =JobIntroduce_log,              
   FILENAME='F:\c#\大作业\JobIntroduce.ldf',  
   SIZE=1,			
   MAXSIZE=5,			
   FILEGROWTH=1 			
) 
GO


--插入表
Use JobIntroduce
GO

create table Administrator
(
   AdminID nvarchar(11) , 
   passwords nvarchar(16) not null ,
   constraint  Pk_Administrator  primary  key  (AdminID)
)

Create table Employer
(
   EmployerID nvarchar(11)not null , 
   passwords nvarchar(16) not null ,
   EmpName nvarchar(15) not null,
   Area nvarchar(10) not null,
   States int default(0) ,
   
   EmpDescribes nvarchar(200) ,
   JobDescribes nvarchar(100) ,
   Lincense char(20) not null,
   Blacklist int default(0) ,
   Email nvarchar(20) ,
   tel nvarchar(11) not null,
   constraint  Pk_Employer  primary  key  (EmployerID),
   constraint  Ck_States  check  (States in (0,1,-1)),
   constraint  Ck_Blacklist  check  (States in (0,1,-1)),
   constraint  Ck_tel  check  (tel like '1[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
)
create table Employees
(
   EmployeeID nvarchar(11) not null, 
   passwords nvarchar(16) not null ,
   EmpName nvarchar(15) not null,
   Sex char(2) not null,
   Age int not null,
   Workyear int default(0) ,
   Area nvarchar(10) ,
   States int default(0) ,
   EmpDescribes nvarchar(100) ,
   Blacklist int default(0) ,
   Identify nchar(18) not null,
   Email nvarchar(20) ,
   tel nvarchar(11) not null,
   constraint  Pk_Employees  primary  key  (EmployeeID),
   constraint  Ck_Sex  check  (Sex in ('男','女')),
   constraint  Ck_Age  check  (Age between 18 and 70),
   constraint  Ck_Employees_Workyear  check  (Workyear between 0 and 50),
   constraint  Ck_Employees_States  check  (States in (0,1,-1)),
   constraint  Ck_Employees_Blacklist  check  (States in (0,1,-1)),
   constraint  Ck_Employees_tel  check  (tel like '1[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
)

Create table Resumes
(
   ResumesID  nvarchar(11) not null, 
   EmployerID  nvarchar(11) not null, 
   EmployeeID  nvarchar(11) not null, 
   EmpDescribes nvarchar(100) not null,
   privateimform nvarchar(100) not null,
   constraint  Pk_Resumes  primary  key  (ResumesID),
   constraint  FK_Resumes_Employer foreign  key   (EmployerID)  references Employer(EmployerID),
   constraint  FK_Resumes_Employees  foreign  key   (EmployeeID)  references Employees(EmployeeID),
)

Create table Recruitment
(
   RecruitmentID  nvarchar(11) not null, 
   EmployerID  nvarchar(11) not null, 
   Salary money not null,
   JobDescribes nvarchar(100) not null,
   States int default(0) not null,
   
   constraint  Pk_Recruitment  primary  key  (RecruitmentID),
   constraint  FK_Recruitment_Employer foreign  key   (EmployerID)  references Employer(EmployerID),
   constraint  Ck_Recruitment_States  check  (States in (0,1,-1)),
)

Create table Balance
(
   AccountID  nvarchar(11) not null, 
   Balance money default(0) not null,
   constraint  Pk_Balance  primary  key  (AccountID),
   constraint  Ck_Balance_Balance  check  (Balance>=0),
)

Create table EmployerBlacklist
(
   EmployerID  nvarchar(11) not null, 
   EmployeeID  nvarchar(11) not null, 
   constraint  Pk_EmployerBlacklist primary  key  (EmployerID,EmployeeID),
   constraint  FK_EmployerBlacklist_Employer foreign  key   (EmployerID)  references Employer(EmployerID),
   constraint  FK_EmployerBlacklist_Employee foreign  key   (EmployeeID)  references Employees(EmployeeID)
)

Create table EmployeeBlacklist
(
   EmployeeID  nvarchar(11) not null, 
   EmployerID  nvarchar(11) not null, 
   constraint  Pk_EmployeeBlacklist  primary  key  (EmployeeID,EmployerID),
   constraint  FK_EmployeeBlacklist_Employer foreign  key   (EmployerID)  references Employer(EmployerID),
   constraint  FK_EmployeeBlacklist_Employee foreign  key   (EmployeeID)  references Employees(EmployeeID),
)

Create table Score
(
   ScoreID  nvarchar(11) not null, 
   Kind char(2) not null, 
   ObjectID  nvarchar(11) not null,
   Score int not null,
   constraint  Pk_Score primary  key  (ScoreID),
   constraint  Ck_Score_Kind check  (Kind in (0,1,-1)),
   constraint  Ck_Score_Score check  (Kind between 0 and 10),
)
Create table Invite
(
   InviteID nvarchar(6) not null, 
   EmployerID nvarchar(11) not null, 
   EmployeeID nvarchar(11) not null, 
   Salary money not null,
   JobDescribes nvarchar(100) not null,
   States int not null 
   constraint  Pk_Invite primary  key  (InviteID),
   constraint  FK_Invite_Employer foreign  key   (EmployerID)  references Employer(EmployerID),
   constraint  FK_Invite_Employee foreign  key   (EmployeeID)  references Employees(EmployeeID),
   constraint  Ck_Invite_States check  (States in (0,1,-1,2)),
)

--添加余额表的触发器
Create trigger tr_Balanceinsert1
On Employer
For insert
As
   declare @id char(11)
   select @id=(select EmployerID from inserted)
   insert into Balance values(@id,0)
GO

Create trigger tr_Balanceinsert2
On Employees
For insert
As
   declare @id char(11)
   select @id=(select EmployeeID from inserted)
   insert into Balance values(@id,0)
GO

--删除余额表的触发器
Create trigger tr_Balancedel1
On Employer
For delete
As
   declare @id char(11)
   select @id=(select EmployerID from deleted)
   delete Balance
   where AccountID=@id
GO

Create trigger tr_Balancedel2
On Employees
For delete
As
   declare @id char(11)
   select @id=(select EmployeeID from deleted)
   delete Balance
   where AccountID=@id
GO


--删除招聘信息的触发器
Create trigger tr_Recruitment
On Employer
For delete
As
   declare @id char(11)
   select @id=(select EmployerID from deleted)
   delete Recruitment
   where EmployerID=@id
GO


--删除简历的触发器
Create trigger tr_Resumes
On Employees
For delete
As
   declare @id char(11)
   select @id=(select EmployeeID from deleted)
   delete Resumes
   where EmployeeID=@id
GO

--删除评分表的触发器
Create trigger tr_Score1
On Employees
For delete
As
   declare @id char(11)
   select @id=(select EmployeeID from deleted)
   delete Score
   where ScoreID=@id
GO

Create trigger tr_Score2
On Employer
For delete
As
   declare @id char(11)
   select @id=(select EmployerID from deleted)
   delete Score
   where ScoreID=@id
GO


--删除评分表的触发器
Create trigger tr_EmployeeBlacklist
On Employees
For delete
As
   declare @id char(11)
   select @id=(select EmployeeID from deleted)
   delete EmployeeBlacklist
   where EmployeeID=@id
GO

Create trigger tr_EmployerBlacklist
On Employer
For delete
As
   declare @id char(11)
   select @id=(select EmployerID from deleted)
   delete EmployerBlacklist
   where EmployerID=@id
GO
--删除邀请表的触发器
Create trigger tr_InviteEmper
On Employer
For delete
As
   declare @id char(11)
   select @id=(select EmployerID from deleted)
   delete Invite
   where EmployerID=@id
GO

Create trigger tr_InviteEmpee
On Employees
For delete
As
   declare @id char(11)
   select @id=(select EmployeeID from deleted)
   delete Invite
   where EmployeeID=@id
GO

alter table employer
add	Longitude float 

alter table employer
add  Latitude float 

