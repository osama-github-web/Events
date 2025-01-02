namespace Events.EventHandlers
{
    internal class NewBookArrivalEventArgs : EventArgs
    {
        public string Title { get; set; }
        public string Author { get; set; }
    }
}
