use Tournaments;
go

create table Teams (
id int identity (1,1) not null primary key,
TeamName varchar(100) not null
);
go

create table People (
id int identity (1,1) not null primary key,
FirstName varchar(100) not null,
LastName varchar(100) not null,
EmailAddress varchar(100) not null,
CellPhoneNumber varchar(100) not null
);
go

create table TeamMembers (
id int identity (1,1) not null primary key,
TeamId int not null,
PersonId int not null,
foreign key (TeamId) references Teams(id),
foreign key (PersonId) references People(id)
);
go

create table Matchups (
id int identity (1,1) not null primary key,
WinnerId int not null,
MatchupRound int not null,
foreign key (WinnerId) references Teams(id)
);
go

create table MatchupEntries (
id int identity (1,1) not null primary key,
MatchupId int not null,
ParentMatchupId int not null,
TeamCompeteingId int not null,
Score int not null,
foreign key (MatchupId) references Matchups (id),
foreign key (ParentMatchupId) references Matchups (id),
foreign key (TeamCompeteingId) references Teams (id)
);
go

create table Tournaments (
id int identity (1,1) not null primary key,
TournamentName varchar(100) not null,
EntryFee money not null
);
go

create table TournamentEntries (
id int identity (1,1) not null primary key,
TournamentId int not null,
TeamId int not null,
foreign key (TournamentId) references Tournaments (id),
foreign key (TeamId) references Teams (id)
);
go

create table Prizes (
id int identity (1,1) not null primary key,
PlaceNumber int not null,
PlaceName varchar(100) not null,
PrizeAmount money not null default 0,
PrizePercentage float not null default 0
);
go

create table TournamentPrizes (
id int identity (1,1) not null primary key,
TournamentId int not null,
PrizeId int not null,
foreign key (TournamentId) references Tournaments (id),
foreign key (PrizeId) references Prizes (id)
);
go