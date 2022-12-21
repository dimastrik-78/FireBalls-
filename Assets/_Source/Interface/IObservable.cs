namespace Interface
{
    public interface IObservable
    {
        void Register(IObserver observer);

        void Remove(IObserver observer);

        void Notify();
    }
}
