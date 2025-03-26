create database CMS;
use CMS;
create table AdminLogin(username varchar(50),password varchar(50));
insert into AdminLogin values('admin','admin');
select * from AdminLogin;

create table StudInformation
(studid int NOT NULL primary key,studnm varchar(50) null,
dob datetime null,gender varchar(50) null,
phone varchar(50) null,email varchar(50) null);
select * from StudInformation;

create table SubjectInfo
(subid int NOT NULL,subname varchar(50));
select * from SubjectInfo;

create table FacultyInfo
(facultyid int NOT NULL,facultynm varchar(50),
gender varchar(50),mobile varchar(50));
select * from FacultyInfo;

create table SectionInfo
(sectionid int NOT NULL,sectionnm varchar(50),
section varchar(50));
select * from SectionInfo;

create table EnrollmentInfo
(eid int NOT NULL,enm varchar(50),
esection varchar(50),edate datetime null);
select * from EnrollmentInfo;

create table AttendanceInfo
(aid int NOT NULL,anm varchar(50),status varchar(50));
select * from AttendanceInfo;

create table examnple
(name varchar(50),mo varchar(15),gender varchar(50));
select * from examnple;