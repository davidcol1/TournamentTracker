use Tournaments;
go

--select 'TournamentPrizes' TournamentPrizes, * from TournamentPrizes;

--select 'Prizes' Prizes, * from Prizes;

--select 'TournamentEntries' TournamentEntries, * from TournamentEntries;

--select 'Tournaments' Tournaments, * from Tournaments;

--select 'MatchupEntries' MatchupEntries, * from MatchupEntries;

--select 'Matchups' Matchups, * from Matchups;

--select 'TeamMembers' TeamMembers, * from TeamMembers;

--select 'People' People, * from People;

--select 'Teams' Teams, * from Teams;

/**************************DANGER BELOW**************************/

--USE master
--GO
---- Create Snapshot Database
--CREATE DATABASE TournamentsSnapshot ON
--(Name ='Tournaments',
--FileName='C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\TournamentsSnapshot.snap')
--AS SNAPSHOT OF Tournaments;
--GO

--USE master
--GO
--RESTORE DATABASE Tournaments
--FROM DATABASE_SNAPSHOT = 'TournamentsSnapshot'

--USE master
--GO
---- Clean up
--DROP DATABASE TournamentsSnapshot;
--GO

/**************************DANGER BELOW**************************/

----delete from TournamentPrizes;
----go

----delete from Prizes;
----go

----delete from TournamentEntries;
----go

----delete from Tournaments;
----go

----delete from MatchupEntries;
----go

----delete from Matchups;
----go

----delete from TeamMembers;
----go

----delete from People;
----go

----delete from Teams;
----go

/**************************DANGER BELOW**************************/

----drop table if exists TournamentPrizes;
----go

----drop table if exists Prizes;
----go

----drop table if exists TournamentEntries;
----go

----drop table if exists Tournaments;
----go

----drop table if exists MatchupEntries;
----go

----drop table if exists Matchups;
----go

----drop table if exists TeamMembers;
----go

----drop table if exists People;
----go

----drop table if exists Teams;
----go