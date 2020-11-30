CREATE TABLE Account
(
	UserID	int not null IDENTITY(1,1),
	UserName varchar(50),
	Password varchar(50),	
	Status bit default 1,
	CreatedDate Datetime default getdate(),	
	constraint pk_userID primary key (UserID)
)
create table FeedBack
(
	FeedBackID int not null IDENTITY(1,1),
	Content nvarchar(250),
	CreatedDate Datetime default getdate(),
	constraint pk_FeedBackID primary key (FeedBackID)
)
create table Subjects 
(
	SubjectsID int not null IDENTITY(1,1),
	SubjectsName nvarchar(250),
	Status bit default 1,
	CreatedDate Datetime default getdate(),
	constraint pk_SubjectsID primary key (SubjectsID)
)
create table Lesson
(
	LessonID int not null IDENTITY(1,1),
	LessonName nvarchar(250),
	Status bit default 1,
	CreatedDate Datetime default getdate(),
	SubjectsID int not null,
	constraint pk_LessonID primary key (LessonID),
	constraint fk_subjectID foreign key (SubjectsID) references Subjects(SubjectsID) 
	on delete cascade
	on update cascade

)

create table Exam_Questions
(
	Exam_Questions  int not null IDENTITY(1,1),
	Exam_QuestionsName nvarchar(250),
	Exam_Time Datetime,
	Status bit default 1,
	CreatedDate Datetime default getdate(),
	Number_of_Question int 
	constraint pk_Exam_Questions primary key (Exam_Questions)
)
create table Set_of_Questions
(
	QuestionsID int not null IDENTITY(1,1),
	Exam_Questions  int not null,
	Status bit default 1,
	CreatedDate Datetime default getdate(),
	constraint pk_EQ primary key (Exam_Questions,QuestionsID)

)
create table Curriculum
(
	CurriculumID int not null IDENTITY(1,1),
	CurriculumName nvarchar(250),
	Status bit default 1,
	CreatedDate Datetime default getdate(),
	SubjectsID int not null,
	constraint pk_CurriculumID primary key (CurriculumID),
	constraint fk_subjectID3 foreign key (SubjectsID) references Subjects(SubjectsID)
	on delete cascade
	on update cascade
)
create table Questions
(
	QuestionsID int not null IDENTITY(1,1),
	QuestionsName nvarchar(1000),
	Questions_A nvarchar(250),
	Questions_B nvarchar(250),
	Questions_C nvarchar(250),
	Questions_D nvarchar(250),
	Explain nvarchar(500),
	Correct_Answer int,
	SubjectsID int not null,
	CurriculumID int not null,
	LessonID int not null,
	Status bit default 1,
	CreatedDate Datetime default getdate(),	
	constraint pk_QuestionsID primary key (QuestionsID),
	constraint fk_subjectID2 foreign key (SubjectsID) references Subjects(SubjectsID),
	constraint fk_subjectID4 foreign key (LessonID) references Lesson(LessonID),
	constraint fk_Curriculum3 foreign key (CurriculumID) references Curriculum(CurriculumID)
	on delete cascade
	on update cascade
)
create table Point 
(
	PointID int not null IDENTITY(1,1),
	UserID	int not null,
	Total_Correct_Answer int,
	CreatedDate Datetime default getdate(),
	Exam_Questions  int not null,
	LessonID int not null,
	constraint pk_Point primary key (PointID,UserID,Exam_Questions),
	constraint fk_LessonID3 foreign key (LessonID) references Lesson(LessonID)
	on delete cascade
	on update cascade

)


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[xulydangnhap] 
	@Username varchar(50),
	@Password varchar(50)
AS
BEGIN
	declare @count int
	declare @res	bit
	select @count = count(*) from Account where UserName = @Username	and Password = @Password
	if @count > 0	
	set
		@res = 1
	else
	set @res = 0

	select @res
END
