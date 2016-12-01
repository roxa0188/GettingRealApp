DELETE PlayerList;
DROP TABLE PlayerList;

CREATE TABLE PlayerList 
(
PlayerID int NOT NULL IDENTITY(1,1),
PlayerFirstName NVARCHAR (25) NOT NULL,
PlayerLastName NVARCHAR (25) NOT NULL,
PlayerEmail NVarChar(50) NOT NULL,
PlayerPhone NVarChar(25) NULL

CONSTRAINT PlayerList_PK PRIMARY KEY(PlayerID),
CONSTRAINT PLEmail_UNQ UNIQUE (PlayerEmail)
);