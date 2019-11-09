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
  inner join MatchupEntries me
  on me.MatchupId = m.id
  inner join Teams t
  on t.id = me.TeamCompeteingId
  inner join TournamentEntries te
  on te.TeamId = t.Id
  and te.TournamentId = @TournamentId

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

  select te.*
  from Teams t
  inner join TeamMembers te
  on te.TeamId = t.Id
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