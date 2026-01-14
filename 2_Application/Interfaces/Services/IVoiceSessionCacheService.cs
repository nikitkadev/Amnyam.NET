namespace MlkAdmin._2_Application.Interfaces.Services;

public interface IVoiceSessionCacheService
{
    void SetVoiceSessionStart(ulong guildMemberDiscordId);
    DateTimeOffset? GetVoiceSessionStartByMemberDiscordId(ulong guildMemberDiscordId);
    void RemoveVoiceSessionFromDictionary(ulong guildMemberDiscordId);
    bool AlreadySet(ulong guildMemberDiscordId);
}
