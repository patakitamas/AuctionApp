﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuctionApp.Models
{
    public class Bid
    {
        public int Id { get; set; }
        public double Price{ get; set; }
        public string? IdentityUserId{ get; set; }
        [ForeignKey("IdentityUserId")]
        public IdentityUser? User { get; set; }
        public int? ListingId{ get; set; }
        [ForeignKey("ListingId")]
        public Listing? Listing { get; set; }
    }
}
