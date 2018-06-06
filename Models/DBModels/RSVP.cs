using System;
using System.ComponentModel.DataAnnotations;
using wedding_planner.Models;

namespace wedding_planner.Models
{
    public class RSVP : BaseEntity
    {
        [Key]
        public int RSVPSId { get; set; } 
        public int UserId {get; set;} //Foreign Key

        public int GuestWeddingId {get; set;} //Foreign Key

        public User User {get; set;} //User Objects created along with the foreign key
        public Wedding GuestWedding {get; set;} //Wedding Objects created along with the foreign key

        
    }
}