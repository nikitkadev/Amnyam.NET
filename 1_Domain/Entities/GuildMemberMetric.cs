namespace MlkAdmin._1_Domain.Entities;

public class GuildMemberMetric
{
    public ulong MemberDiscordId { get; set; }
    
    public int MessageSentCount { get; set; } = 0;
    public int ReactionAddedCount { get; set; } = 0;
    public int CommandSentCount { get; set; } = 0;
    public int EmotesSentCount { get; set; } = 0;
    public int GifsSentCount { get; set; } = 0;
    
    public DateTimeOffset? FirstMessage { get; set; }
    public DateTimeOffset? LastMessage { get; set; }
}
