using Restolog.Entities.Abstract;

namespace Restolog.Entities.Concrete
{
    public class Log : IEntity
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public User? User { get; set; }
        public string Action { get; set; } = string.Empty;
        public string EntityType { get; set; } = string.Empty;
        public int EntityId { get; set; }
        public DateTime Timestamp { get; set; }
    }
}