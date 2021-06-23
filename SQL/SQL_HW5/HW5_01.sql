USE ManageProject
CREATE TABLE HeadOffice (
	OfficeName VARCHAR(50) Unique,
	City VARCHAR(50),
	Country VARCHAR(50),
	[Address] VARCHAR(50),
	PhoneNumber VARCHAR(50),
	DirectorName VARCHAR(50),
	ProjectId int,
	FOREIGN KEY (ProjectId) REFERENCES Projects(ProjectCode)
) 


CREATE TABLE Projects(
	ProjectCode int Primary Key,
	Title VARCHAR(50),
	StartDate DATETIME,
	EndDate DATETIME,
	AssignedBudget int,
	ManagerName VARCHAR(50),
	OperationId int,
	--FOREIGN KEY (OperationId) REFERENCES Operations(OperationId)
)

/*ALTER TABLE Projects
ADD CONSTRAINT FK_OperationId
FOREIGN KEY (OperationId) REFERENCES Operations(OperationId)*/

CREATE TABLE Operations(
	OperationId int Primary Key,
	OperationProcess VARCHAR(50),
	CityName VARCHAR(50),
	ActionId int,
	FOREIGN KEY (ActionId) REFERENCES Actions(ActionId)
)

CREATE TABLE Actions(
	ActionId int Primary Key,
	CityName VARCHAR(50),
	Country VARCHAR(50),
	NumOfInhabitants int
)



