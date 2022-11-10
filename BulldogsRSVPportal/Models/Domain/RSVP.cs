using System.Data;

namespace BulldogsRSVPportal.Models.Domain
{
    public class RSVP
    {
        public Guid Id { get; set; }
        public string Callsign { get; set; }
        public DateTime Date { get; set; }    
        public bool Confirm { get; set; }
    }
}
