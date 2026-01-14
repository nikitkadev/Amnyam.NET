namespace MlkAdmin._1_Domain.Interfaces;

public interface IGuildMemberMetricRepository
{
    Task IncrementMessageSentCountAsync(ulong guildMemberDiscordId, int increment = 1);
    Task IncrementReactionAddedCountAsync(ulong guildMemberDiscordId, int increment = 1);
    Task IncrementCommandSentCountAsync(ulong guildMemberDiscordId, int increment = 1);
    Task IncrementEmoteSentCountAsync(ulong guildMemberDiscordId, int increment = 1);
    Task IncrementGifSentCountAsync(ulong guildMemberDiscordId, int increment = 1);

    Task UpdateLastMessageDateAsync(ulong guildMemberDiscordId);
}
