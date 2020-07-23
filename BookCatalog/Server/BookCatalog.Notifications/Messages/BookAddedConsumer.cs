using BookCatalog.Common.Messages;
using BookCatalog.Notifications.Hubs;
using MassTransit;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

using static BookCatalog.Notifications.NotificationsConstants;

namespace BookCatalog.Notifications.Messages
{
    public class BookAddedConsumer : IConsumer<BookAddedMessage>
    {
        private readonly IHubContext<NotificationsHub> hub;

        public BookAddedConsumer(IHubContext<NotificationsHub> hub)
            => this.hub = hub;

        public Task Consume(ConsumeContext<BookAddedMessage> context) =>
            this.hub.Clients
                .Groups(AuthenticatedUsersGroup)
                .SendAsync(ReceiveNotificationEndpoint, context.Message);
    }
}
