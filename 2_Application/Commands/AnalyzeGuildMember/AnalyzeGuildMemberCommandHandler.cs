using MediatR;
using MlkAdmin._2_Application.Interfaces.Managers;
using MlkAdmin.Shared.Dtos;
using MlkAdmin.Shared.Results;

namespace MlkAdmin._2_Application.Commands.AnalyzeGuildMember;

public class AnalyzeGuildMemberCommandHandler(
    IGuildMembersManager membersManager) : IRequestHandler<AnalyzeGuildMemberCommand, BaseResult<GuildMemberAnalyzeData>>
{
    public async Task<BaseResult<GuildMemberAnalyzeData>> Handle(AnalyzeGuildMemberCommand request, CancellationToken cancellationToken)
    {
        return await membersManager.AnalyzeGuildMemberAsync(request.GuildMemberDiscordId);
    }
}
