using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using wedding_planner.Models;

namespace wedding_planner.Models
{
    public class Wedding : BaseEntity
    {
        [Key]
        public int WeddingId { get; set; }
        public string WedderOne { get; set; }
        public string WedderTwo { get; set; }
        public DateTime DateOfEvent { get; set; }
        public string Address { get; set; }

        public int UserId {get; set;}


        public List<RSVP> RSVPS {get; set;}

        public Wedding()
        {
            RSVPS = new List<RSVP>();
        }
        
    }
}