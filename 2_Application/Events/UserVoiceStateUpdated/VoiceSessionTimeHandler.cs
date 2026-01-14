using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MlkAdmin._1_Domain.Entities;
using MlkAdmin._1_Domain.Interfaces;
using MlkAdmin._2_Application.Interfaces.Managers;
using MlkAdmin._2_Application.Interfaces.Services;

namespace MlkAdmin._2_Application.Events.UserVoiceStateUpdated;

public class VoiceSessionTimeHandler(
    IGuildVoiceSessionsManager voiceSessionsManager) : INotificationHandler<UserVoiceStateUpdated>
{
    public async Task Handle(UserVoiceStateUpdated notification, CancellationToken cancellationToken)
    {
        await voiceSessionsManager.HandleVoiceStateUpdateAsync(
            notification.NewState.VoiceChannel, 
            notification.OldState.VoiceChannel, 
            notification.SocketUser.Id);
    }
}
