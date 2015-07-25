﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cm93.DatabaseBootstrap.TestDatabase
{
	static class Table
	{
		internal static readonly IList<string> Scripts = new[]
			{
				"CREATE TABLE \"Competitions\" (\"CompetitionId\" INTEGER PRIMARY KEY NOT NULL UNIQUE, \"CompetitionType\" VARCHAR NOT NULL, \"CompetitionName\" VARCHAR NOT NULL UNIQUE)",
				"CREATE TABLE \"Divisions\" (\"CompetitionId\" INTEGER NOT NULL, \"TeamId\" INTEGER NOT NULL, \"StateId\" INTEGER NOT NULL, \"Wins\" INTEGER NOT NULL DEFAULT 0, \"Draws\" INTEGER NOT NULL DEFAULT 0, \"Losses\" INTEGER NOT NULL DEFAULT 0, \"GoalsFor\" INTEGER NOT NULL DEFAULT 0, \"GoalsAgainst\" INTEGER NOT NULL DEFAULT 0, \"GoalDifference\" INTEGER NOT NULL DEFAULT 0, \"Points\" INTEGER NOT NULL DEFAULT 0, PRIMARY KEY (\"CompetitionId\", \"TeamId\", \"StateId\"))",
				"CREATE TABLE \"Fixtures\" (\"CompetitionId\" INTEGER NOT NULL, \"StateId\" INTEGER NOT NULL, \"HomeTeamId\" INTEGER NOT NULL, \"AwayTeamId\" INTEGER NOT NULL, \"Week\" INTEGER NOT NULL, \"HomeGoals\" INTEGER NOT NULL DEFAULT 0, \"AwayGoals\" INTEGER NOT NULL DEFAULT 0, PRIMARY KEY (\"CompetitionId\", \"StateId\", \"HomeTeamId\", \"AwayTeamId\", \"Week\"))",
				"CREATE TABLE \"Players\" (\"PlayerStatId\" INTEGER NOT NULL, \"StateId\" INTEGER NOT NULL, \"ReleaseValue\" INTEGER NOT NULL, \"NumericValue\" INTEGER NOT NULL, \"Number\" INTEGER NOT NULL DEFAULT (null), \"TeamId\" INTEGER, \"LocationX\" DOUBLE NOT NULL, \"LocationY\" DOUBLE NOT NULL, PRIMARY KEY (\"PlayerStatId\", \"StateId\"))",
				"CREATE TABLE \"PlayerStats\" (\"PlayerStatId\" INTEGER PRIMARY KEY NOT NULL, \"FirstName\" VARCHAR NOT NULL, \"LastName\" VARCHAR NOT NULL, \"Age\" INTEGER NOT NULL, \"Position\" INTEGER NOT NULL)",
				"CREATE TABLE \"Ratings\" (\"PlayerStatId\" INTEGER PRIMARY KEY NOT NULL UNIQUE, \"Rating\" DOUBLE NOT NULL)",
				"CREATE TABLE \"States\" (\"StateId\" INTEGER PRIMARY KEY NOT NULL UNIQUE, \"StateGuid\" VARCHAR NOT NULL, \"Name\" VARCHAR NOT NULL, \"Created\" DATETIME NOT NULL, \"LastSaved\" DATETIME NOT NULL, \"Hash\" VARCHAR)",
				"CREATE TABLE \"Teams\" (\"TeamId\" INTEGER PRIMARY KEY NOT NULL UNIQUE, \"TeamName\" VARCHAR NOT NULL UNIQUE, \"PrimaryColour\" INTEGER NOT NULL, \"SecondaryColour\" INTEGER NOT NULL)",
				"CREATE TABLE \"TeamBalances\" (\"TeamId\" INTEGER NOT NULL, \"StateId\" INTEGER NOT NULL, \"Balance\" INTEGER NOT NULL, PRIMARY KEY (\"TeamId\", \"StateId\"))"
			};
	}
}