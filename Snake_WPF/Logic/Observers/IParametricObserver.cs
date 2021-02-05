namespace Snake_WPF.Logic.Observers
{
    public interface IParametricObserver<in T>
    {
        void Update(T updated);
    }
}
