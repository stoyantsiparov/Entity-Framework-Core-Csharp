﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using P02_FootballBetting.Common;

namespace P02_FootballBetting.Data.Models;

public class Player
{
    public Player()
    {
        PlayersStatistics = new HashSet<PlayerStatistic>();
    }

    [Key]
    public int PlayerId { get; set; }

    [MaxLength(ValidationConstants.PlayerNameLength)]
    public string Name { get; set; }
    public byte SquadNumber { get; set; }
    public byte Assists { get; set; }

    [ForeignKey(nameof(TownId))]
    public int TownId { get; set; }
    public virtual Town Town { get; set; }

    [ForeignKey(nameof(PositionId))]
    public int PositionId { get; set; }
    public virtual Position Position { get; set; }
    public bool IsInjured { get; set; }

    [ForeignKey(nameof(TeamId))]
    public int TeamId { get; set; }
    public virtual Team Team { get; set; }

    public virtual ICollection<PlayerStatistic> PlayersStatistics { get; set; }
}