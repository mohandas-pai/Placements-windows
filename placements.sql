use placements
create table LOGIN (
	username varchar(20) primary key, 
	password varchar(20) not null,
	utype int not null) -- utype can be 0,1 : 0 means student, 1 means admin

create table DEPARTMENT(
	dcode int primary key,
	dname varchar(30) not null 
	)

create table STAFF (
	name varchar(30),
	dept int,
	username varchar(20),
	foreign key (dept) references DEPARTMENT(dcode) on delete set null on update cascade,
	foreign key (username) references LOGIN(username) on delete set null on update cascade
	)

create table STUDENT (
	usn char(10) primary key,
	name varchar(30) not null,
	username varchar(20),
	age int not null,
	gender char(6),
	dob date,
	address varchar(30),
	dept int default 1,
	foreign key (dept) references DEPARTMENT(dcode) on delete set default on update cascade,
	foreign key (username) references LOGIN(username) on delete set null on update cascade
	)

drop table APPLIES_FOR 
drop table ELIGIBLE_FOR 
drop table GRADE
drop table COMPANY
drop table STAFF
drop table STUDENT
drop table DEPARTMENT 
drop table LOGIN

create table GRADE (
	usn char(10) primary key,
	sslc numeric(4,1) check(sslc > = 0 and sslc <=100),
	puc numeric(4,1) check(puc > = 0 and puc <=100),
	cgpa numeric(4,2) check (cgpa >= 0 and cgpa <= 10),
	backlogs int,
	foreign key (usn) references STUDENT(usn) on update cascade on delete cascade
	)


create table COMPANY(
	cid int primary key,
	cname varchar(30) unique,
	ctype char(10),
	reg_date date,
	int_date date,
	package real,
	req_sslc numeric(4,1) check(req_sslc > = 0 and req_sslc <=100),
	req_puc numeric(4,1) check(req_puc > = 0 and req_puc <=100),
	req_cgpa numeric(4,2) check (req_cgpa >= 0 and req_cgpa <= 10)
	)

create table ELIGIBLE_FOR (
	dcode int,
	cid int,
	primary key(dcode, cid),
	foreign key (dcode) references DEPARTMENT(dcode) on update cascade on delete cascade,
	foreign key (cid) references COMPANY(cid) on update cascade on delete cascade
	)

create table APPLIES_FOR (
	usn char(10),
	cid int,
	regdate date,
	is_placed bit -- 0 means not placed, 1 means placed
	)
	
insert into LOGIN values('kmank', '12345', 0)
insert into LOGIN values('kmank2', '12345', 0)
insert into LOGIN values('kmank3', '12345', 0)
insert into LOGIN values('staff1', '12345', 1)
insert into LOGIN values('staff2', '12345', 1)
insert into LOGIN values('staff3', '12345', 1)

insert into DEPARTMENT values(1, 'Computer Science')
insert into DEPARTMENT values(2, 'Information Science')
insert into DEPARTMENT values(3, 'Mechanical')
insert into DEPARTMENT values(4, 'Electronics')
insert into DEPARTMENT values(5, 'Civil')

insert into STAFF values ('Ramesh', 1, 'staff1')
insert into STAFF values ('Rakesh', 2, 'staff2')
insert into STAFF values ('Harambe', 3, 'staff3')

insert into STUDENT values('4nm14cs089','kashif','kmank',19,'male','1997-01-24','2nd block ktp',1 )
insert into STUDENT values('4nm14cs090','tyson','kmank2',19,'male','1997-01-24','2nd block ktp',1 )
insert into STUDENT values('4nm14cs091','yamdee','kmank3',19,'male','1997-01-24','2nd block ktp',1 )

insert into GRADE values('4nm14cs089', 86.4, 78.8, 8.88, 0)
insert into GRADE values('4nm14cs090', 86.4, 78.8, 8.88, 0)
insert into GRADE values('4nm14cs091', 86.4, 78.8, 8.88, 0)

insert into COMPANY values(1, 'Infosys', 'service', '2016-11-16', '2016-11-18', 3.4, 70, 65, 6.25)
insert into COMPANY values(2, 'Robosoft', 'core', '2016-11-19', '2016-11-20', 10.5, 70, 85, 7.25)
insert into COMPANY values(3, 'TCS', 'service', '2016-11-21', '2016-11-21', 9.6, 79, 75, 8.25)

insert into ELIGIBLE_FOR values (1, 1)
insert into ELIGIBLE_FOR values (1, 2)
insert into ELIGIBLE_FOR values (1, 3)
insert into ELIGIBLE_FOR values (2, 1)
insert into ELIGIBLE_FOR values (2, 2)
insert into ELIGIBLE_FOR values (2, 3)
insert into ELIGIBLE_FOR values (3, 1)
insert into ELIGIBLE_FOR values (4, 2)
insert into ELIGIBLE_FOR values (5, 3)

insert into APPLIES_FOR values('4nm14cs089',1,'2016-11-05', 0)
insert into APPLIES_FOR values('4nm14cs089',2,'2016-11-05', 0)

select * from STUDENT
select * from LOGIN
select * from STAFF
select * from DEPARTMENT 
select * from GRADE 
select * from COMPANY 
select * from ELIGIBLE_FOR 
select * from APPLIES_FOR 
delete from student

select * from COMPANY C, APPLIES_FOR AF, STUDENT S where S.username = 'kmank' and S.usn = AF.usn and C.cid = AF.cid

-- To check if a student has already applied for 3 companies or if he has been placed or if he has applied for the current company

select * from STUDENT S where S.username = 'kmank' and S.username in (
select S.username from APPLIES_FOR AF,STUDENT S where AF.usn = S.usn and AF.cid = 1
union
select S.username from APPLIES_FOR AF, STUDENT S where S.usn = AF.usn and AF.is_placed = 1
union
select S.username from COMPANY C, APPLIES_FOR AF, STUDENT S where S.usn = AF.usn and C.cid = AF.cid 
group by S.username having COUNT(*) >= 2 )


insert into APPLIES_FOR values('4nm14cs089',1,'2016-11-05', 0)
insert into APPLIES_FOR 
select usn, 3, GETDATE(),0 from STUDENT where username = 'kmank'

delete from APPLIES_FOR 