using System.Collections.Generic;
using EventEase.Models;
using EventEaseBookingSystem.Models; 

namespace EventEaseBookingSystem.ViewModels
{
    public class HomeViewModel
    {
        public List<Event> Events { get; set; } = new List<Event>();
    }
}
