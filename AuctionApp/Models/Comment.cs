using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuctionApp.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        [Required]
        public string? IdentityUserId { get; set; }
        [ForeignKey("IdentityUserId")]
        public IdentityUser? User { get; set; }
        public int? ListingId{ get; set; }
        public Listing? Listing { get; set; }
    }
}
