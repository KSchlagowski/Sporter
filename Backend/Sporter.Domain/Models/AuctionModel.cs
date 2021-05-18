namespace Sporter.Domain.Models
{
    public class AuctionModel
    {
        public int UserId { get; set; }
        public int ItemId { get; set; }

        public virtual UserModel User { get; set; }
        public virtual ItemModel Item { get; set; }
    }
}