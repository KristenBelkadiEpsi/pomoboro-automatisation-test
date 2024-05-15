namespace pomodoro.Models
{
    public class Session
    {
        public DateTime StartTime { get; set; }
        public TimeSpan Duration { get; set; }
        public string Type { get; set; } // "Work" or "Pause"
    }
}