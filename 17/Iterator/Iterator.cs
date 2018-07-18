namespace Iterator
{
    abstract class Iterator<T>
    {
        public abstract object First();
        
        public abstract object Next();
        
        public abstract bool IsDone();
        
        public abstract object CurrentItem();
    }
}