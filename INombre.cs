namespace OOPDeber1
{
    public interface INombre
    {
        bool Equals(object? obj);
        int GetHashCode();
        string? ToString();
    }
}