namespace MlkAdmin.Shared.Dtos;

public record GuildMemberAnalyzeData
{
    public ulong GuildMemberDiscordId { get; set; }

    public DateTime JoinedAt { get; init; }
    public DateTime FirstMessageDate { get; init; }
    public DateTime LastMessageDate { get; init; }

    public int MessageCount { get; init; }
    public int ReactionCount { get; init; }
    public int PicturesSentCount { get; init; }
    public int GifsSentCount { get; init; }
    public int CommandsSentCount { get; init; }
    public long VoiceChannelsTimeSpent { get; init; }
    public int DaysSinceJoined { get; init; }

    public float AvgToxicity { get; init; }
    public string MostToxicMessage { get; init; } = string.Empty;
    public string SpeechStyle { get; init; } = string.Empty;
    public string Tonality { get; init; } = string.Empty;
    public float AvgCharsInMessage { get; init; }

}
