namespace Delegate
{
    public class WorkPereformedEventArgs : System.EventArgs
    {
        public int Hours { get; set; }
        public WorkType WorkType { get; set; }
    }
}
