namespace GiJoStock
{
    public interface IForm<TSource>
    {
        void SetEntity(TSource source);
    }
}