namespace CodeKata.Katas.Interfaces
{
    public interface IFilter
    {
        void Add(string word);
        bool Test(string word);
    }
}