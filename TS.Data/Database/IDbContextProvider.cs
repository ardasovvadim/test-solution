namespace TS.Data.Database
{
    public interface IDbContextProvider
    {
        DbContext Context { get; }
    }
}