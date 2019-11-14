use Tournaments;
go

if object_id('spMatchupEntries_GetByMatchup', 'P') is not null
  drop proc spMatchupEntries_GetByMatchup
go

create procedure spMatchupEntries_GetByMatchup
  @MatchupId int
as
begin
  set nocount on

  select *
  from MatchupEntries me
  where me.MatchupId = @MatchupId

end
go

if object_id('spMatchups_GetByTournament', 'P') is not null
  drop proc spMatchups_GetByTournament
go

create procedure spMatchups_GetByTournament
  @TournamentId int
as
begin
  set nocount on

  select m.*
  from Matchups m
  where m.TournamentId = @TournamentId

end
go

if object_id('spPeople_GetAll', 'P') is not null
  drop proc spPeople_GetAll
go

create procedure spPeople_GetAll
as
begin
  set nocount on

  select *
  from People

end
go


if object_id('spPrizes_GetByTournament', 'P') is not null
  drop proc spPrizes_GetByTournament
go

create procedure spPrizes_GetByTournament
  @TournamentId int
as
begin
  set nocount on

  select p.*
  from Prizes p
  inner join TournamentPrizes tp
  on tp.TournamentId = @TournamentId

end
go


if object_id('spTeams_GetByTournament', 'P') is not null
  drop proc spTeams_GetByTournament
go
create procedure spTeams_GetByTournament
  @TournamentId int
as
begin
  set nocount on

  select t.*
  from Teams t
  inner join TournamentEntries te
  on te.TeamId = t.Id
  and te.TournamentId = @TournamentId

end
go

if object_id('spTeamMembers_GetByTeam', 'P') is not null
  drop proc spTeamMembers_GetByTeam
go
create procedure spTeamMembers_GetByTeam
  @TeamId int
as
begin
  set nocount on

  select p.*
  from Teams t
  inner join TeamMembers te
  on te.TeamId = t.Id
  inner join People p
  on p.id = te.id
  where t.id = @TeamId

end
go

if object_id('spTournaments_GetAll', 'P') is not null
  drop proc spTournaments_GetAll
go

create procedure spTournaments_GetAll
as
begin
  set nocount on

  select *
  from Tournaments
  where IsActive = 1

end
go

if object_id('spPrizes_Insert', 'P') is not null
  drop proc spPrizes_Insert
go

create procedure spPrizes_Insert
  @PlaceNumber int,
  @PlaceName varchar(100),
  @PrizeAmount money,
  @PrizePercentage float,
  @id int = 0 output
as
begin
  set nocount on

  insert into Prizes (PlaceNumber, PlaceName, PrizeAmount, PrizePercentage)
  values (@PlaceNumber, @PlaceName, @PrizeAmount, @PrizePercentage)

  select @id = SCOPE_IDENTITY();
end
go

if object_id('spPeople_Insert', 'P') is not null
  drop proc spPeople_Insert
go

create procedure spPeople_Insert
  @FirstName varchar(100),
  @LastName varchar(100),
  @EmailAddress varchar(100),
  @CellPhoneNumber varchar(100),
  @id int = 0 output
as
begin
  set nocount on

  insert into People (FirstName, LastName, EmailAddress, CellPhoneNumber)
  values (@FirstName, @LastName, @EmailAddress, @CellPhoneNumber)

  select @id = SCOPE_IDENTITY();
end
go

if object_id('spTeams_Insert', 'P') is not null
  drop proc spTeams_Insert
go

create procedure spTeams_Insert
  @TeamName varchar(100),
  @id int = 0 output
as
begin
  set nocount on

  insert into Teams (TeamName)
  values (@TeamName)

  select @id = SCOPE_IDENTITY();
end
go

if object_id('spTeamMembers_Insert', 'P') is not null
  drop proc spTeamMembers_Insert
go

create procedure spTeamMembers_Insert
  @TeamId int,
  @PersonId int,
  @id int = 0 output
as
begin
  set nocount on

  insert into TeamMembers (TeamId, PersonId)
  values (@TeamId, @PersonId)

  select @id = SCOPE_IDENTITY();
end
go

if object_id('spTeams_GetAll', 'P') is not null
  drop proc spTeams_GetAll
go

create procedure spTeams_GetAll
as
begin
  set nocount on

  select *
  from Teams

end
go

if object_id('spTournaments_Insert', 'P') is not null
  drop proc spTournaments_Insert
go

create procedure spTournaments_Insert
  @TournamentName varchar(100),
  @EntryFee money,
  @id int = 0 output
as
begin
  set nocount on

  insert into Tournaments (TournamentName, EntryFee, IsActive)
  values (@TournamentName, @EntryFee, 1)

  select @id = SCOPE_IDENTITY();
end
go

if object_id('spTournamentEntries_Insert', 'P') is not null
  drop proc spTournamentEntries_Insert
go

create procedure spTournamentEntries_Insert
  @TournamentId int,
  @TeamId int,
  @id int = 0 output
as
begin
  set nocount on

  insert into TournamentEntries (TournamentId, TeamId)
  values (@TournamentId, @TeamId)

  select @id = SCOPE_IDENTITY();
end
go

if object_id('spTournamentPrizes_Insert', 'P') is not null
  drop proc spTournamentPrizes_Insert
go

create procedure spTournamentPrizes_Insert
  @TournamentId int,
  @PrizeId int,
  @id int = 0 output
as
begin
  set nocount on

  insert into TournamentPrizes (TournamentId, PrizeId)
  values (@TournamentId, @PrizeId)

  select @id = SCOPE_IDENTITY();
end
go

if object_id('spMatchups_Insert', 'P') is not null
  drop proc spMatchups_Insert
go

create procedure spMatchups_Insert
  @TournamentId int,
  @MatchupRound int,
  @id int = 0 output
as
begin
  set nocount on

  insert into Matchups (TournamentId, MatchupRound)
  values (@TournamentId, @MatchupRound)

  select @id = SCOPE_IDENTITY();
end
go

if object_id('spMatchupEntries_Insert', 'P') is not null
  drop proc spMatchupEntries_Insert
go

create procedure spMatchupEntries_Insert
  @MatchupId int,
  @ParentMatchupId int,
  @TeamCompetingId int,
  @id int = 0 output
as
begin
  set nocount on

  insert into MatchupEntries (MatchupId, ParentMatchupId, TeamCompetingId)
  values (@MatchupId, @ParentMatchupId, @TeamCompetingId)

  select @id = SCOPE_IDENTITY();
end
go

if object_id('spMatchups_Update', 'P') is not null
  drop proc spMatchups_Update
go

create procedure spMatchups_Update
  @id int,
  @WinnerId int
as
begin
  set nocount on

  update Matchups
  set WinnerId = @WinnerId
  where id = @id

end
go

if object_id('spMatchupEntries_Update', 'P') is not null
  drop proc spMatchupEntries_Update
go

create procedure spMatchupEntries_Update
  @id int,
  @TeamCompetingId int = null,
  @Score float = null
as
begin
  set nocount on

  update MatchupEntries
  set TeamCompetingId = @TeamCompetingId
  , score = @Score
  where id = @id

end
go