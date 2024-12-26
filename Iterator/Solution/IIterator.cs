namespace Iterator.Solution;

public interface IIterator<T>
{
    void Next();
    bool HasNext();
    T Current();
}