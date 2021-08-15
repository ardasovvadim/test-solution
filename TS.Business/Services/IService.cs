namespace TS.Business.Services
{
    public interface IService<Dto, Entity> : IReadOnlyService<Dto, Entity> 
        where Dto : class
        where Entity : class
    {
        Dto Update(Dto obj);
        Dto Insert(Dto obj);
        bool Delete(Dto obj);
    }
}