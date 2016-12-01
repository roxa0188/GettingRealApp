DELETE PlayerLogin;
DROP TABLE PlayerLogin;

CREATE TABLE PlayerLogin (
PlayerID int NOT NULL IDENTITY(1,1),
PlayerUserName NVARCHAR(25) NOT NULL,
PlayerPassword NVARCHAR(25) NOT NULL,

CONSTRAINT PlayerLogin_PK PRIMARY KEY(PlayerID)
);