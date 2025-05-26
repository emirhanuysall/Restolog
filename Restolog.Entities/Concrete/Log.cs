using Restolog.Entities.Abstract;

namespace Restolog.Entities.Concrete
{
    public class Log : IEntity
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Message { get; set; }
        public string LogType { get; set; }
    }
}