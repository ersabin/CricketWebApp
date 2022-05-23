CREATE TABLE Matches(
	MatchID INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	StadiumID INT NOT NULL,
	Team_A varchar(30),
	Team_B varchar(30),
	Result varchar(5),
	DateTime SMALLDATETIME,
	Was_Match_Played varchar(5)
);