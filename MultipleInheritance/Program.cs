using System;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

// bahaha
public class A
{
    public void methodA()
    {
        Console.WriteLine("hello world");
    }
}

public interface IA
{
    void imethodA();
    Task<string> EnsureDefinitionTypeAsync(string name);
}


public class B : A, IA
{
    public Task<string> EnsureDefinitionTypeAsync(string name)
    {
        throw new NotImplementedException();
    }

    public void imethodA()
    {
        throw new NotImplementedException();
    }
}