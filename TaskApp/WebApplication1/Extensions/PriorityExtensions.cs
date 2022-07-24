using TaskIt.Models;

namespace TaskIt.Extensions
{
    public static class PriorityExtensions
    {
        static Dictionary<Priority, string> _priorityCssClass = new()
        {
            [Priority.High] = "badge bg-danger",
            [Priority.Medium] = "badge bg-Warning text-dark",
            [Priority.Low] = "badge bg-success"
        };
        public static string ToCssClass(this Priority priority)
        {
            return _priorityCssClass[priority];
        }
    }
}
