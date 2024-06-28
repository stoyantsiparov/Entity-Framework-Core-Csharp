﻿using P02_FootballBetting.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P02_FootballBetting.Data.Models;

public class Game
{
    public Game()
    {
        PlayersStatistics = new HashSet<PlayerStatistic>();
        Bets = new HashSet<Bet>();
    }
    [Key]
    public int GameId { get; set; }
    public int HomeTeamId { get; set; }
    public virtual Team HomeTeam { get; set; }
    public int AwayTeamId { get; set; }
    public virtual Team AwayTeam { get; set; }
    public byte HomeTeamGoals { get; set; }
    public byte AwayTeamGoals { get; set; }
    public decimal HomeTeamBetRate { get; set; }
    public decimal AwayTeamBetRate { get; set; }
    public decimal DrawBetRate { get; set; }
    public DateTime DateTime { get; set; }

    [MaxLength(ValidationConstants.GameResultLength)]
    public int Result { get; set; }
    public virtual ICollection<PlayerStatistic> PlayersStatistics { get; set; }
    public virtual ICollection<Bet> Bets { get; set; }
}