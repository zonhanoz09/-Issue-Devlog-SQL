//Check if the Value Exists
if (Options.OneAndTwo.HasFlag(Options.One))
{
    Console.WriteLine("One");
}
if ((Options.OneAndTwo & Options.Three) == Options.One)
{
    Console.WriteLine("One");
}

//Add a Value 
Options Addflags = Options.OneAndTwo;
Addflags |= Options.Three;
if (Addflags.HasFlag(Options.Three))
{
    Console.WriteLine("Three");
}

//Remove a Value
Options Removeflags = Options.OneAndTwo;
Removeflags &= ~Options.Two;
if (Removeflags.HasFlag(Options.Two))
{
    Console.WriteLine("Two");
}

Console.WriteLine("Hello, World!");



[Flags]
public enum Options : byte
{
    None = 0,
    One = 1 << 0,   // 1
    Two = 1 << 1,   // 2
    Three = 1 << 2,   // 4
    Four = 1 << 3,   // 8

    // combinations
    OneAndTwo = One | Two,
    OneTwoAndThree = One | Two | Three,
}