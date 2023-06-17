create table COURSES
(
	ID_COURCE int primary key identity(1, 1),
	NAME nvarchar(50),
	DESCRIPTION nvarchar(max),
	IMAGE_SOURCE nvarchar(max),
	PRICE float
)
create table ALGORITHMS
(
  ID_ALGORITHM int primary key identity(1, 1),
  NAME nvarchar(50),
  DESCRIPTION nvarchar(max),
  LEVEL int, 
  IMAGE_SOURCE nvarchar(max),
  PATH_TO_PRESENTATION nvarchar(max)
)
create table QUESTIONS
(
	ID_QUESTION int primary key identity(1, 1),
	ID_USER int foreign key references USERS(ID_USER),
	QUESTION nvarchar(max),
)
create table TESTS
(
	ID_TEST int primary key identity(1, 1),
	NAME nvarchar(max),
	LEVEL int,
	SOURCE nvarchar(max),
	IMAGE_PROFILE nvarchar(max)
)
create table USER_ACTIVITY
(
	ID_USER_ACTIVITY int primary key identity(1, 1),
	ID_USER int foreign key references USERS(ID_USER),
	ID_ALGORITHM int foreign key references ALGORITHMS(ID_ALGORITHM)
)
create table USER_COURSES
(
	ID_USER_COURSE int primary key identity(1, 1),
	ID_USER int foreign key references USERS(ID_USER),
	ID_COURSE int foreign key references COURSES(ID_COURSE)
)
create table USER_TESTS
(
	ID_USER_TESTS int primary key identity(1, 1),
	ID_USER int foreign key references COURSES(ID_COURSE),
	ID_TEST int foreign key references TESTS(ID_TEST)
)
create table USERS
(
	ID_USER int primary key identity(1, 1),
	LOGIN nvarchar(30),
	EMAIL nvarchar(30),
	PASSWORD nvarchar(30),
	LEVEL int,
	IMAGE_SOURCE nvarchar(max),
	ROLE nvarchar(20)
)