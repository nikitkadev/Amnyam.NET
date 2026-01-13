namespace MlkAdmin.Shared.Dtos;

public record GuildMemberAnalyzeData
{
    public int MessageCount { get; init; }
    public int ReactionCount { get; init; }
    public int PicturesSentCount { get; init; }
    public int GifsSentCount { get; init; }
    public int CommandsSentCount { get; init; }
    public int EmotesSentCount { get; init; }
    public long VoiceChannelsTimeSpent { get; init; }

    public int DaysSinceJoined { get; init; }
    public float Toxicity {  get; init; }

    public DateTime JoinedAt { get; init; }
    public DateTime FirstMessageDate { get; init; }
    public DateTime LastMessageDate { get; init; }

}
