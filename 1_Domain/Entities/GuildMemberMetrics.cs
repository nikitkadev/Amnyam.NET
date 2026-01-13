namespace MlkAdmin._1_Domain.Entities;

public class GuildMemberMetrics
{
    public ulong MemberDiscordId { get; set; }
    public int MessageSentCount { get; set; } = 0;
    public int ReactionAddedCount { get; set; } = 0;
    public int CommandSentCount { get; set; } = 0;
    public int EmotesSentCount { get; set; } = 0;
    public long VoiceChannelsTimeSpent { get; set; } = 0;
    public int GifsSentCount { get; set; } = 0;
    
    public DateTimeOffset FirstMessage { get; set; } = DateTimeOffset.UtcNow;
    public DateTimeOffset LastMessage { get; set;} = DateTimeOffset.UtcNow;
}
