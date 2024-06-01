using AuctionApp.Models;

namespace AuctionApp.Data.Services
{
    public interface ICommentsService
    {
        Task Add(Comment comment);
    }
}
