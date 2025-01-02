namespace Events.EventHandlers
{
    internal class ExistingBookRemovalEventArgs : EventArgs
    {
        public virtual int BookId { get; set; }
    }
}
