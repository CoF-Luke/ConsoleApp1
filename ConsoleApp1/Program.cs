
Console.WriteLine("Predefined types and their extreme values:");

    Console.WriteLine("\n\tOrdinary numbers:\n");

        Console.WriteLine($"\t\tbyte    : {byte.MinValue} ... {byte.MaxValue}");
        Console.WriteLine($"\t\tsbyte   : {sbyte.MinValue} ... {sbyte.MaxValue}");
        Console.WriteLine($"\t\tshort   : {short.MinValue} ... {short.MaxValue}");
        Console.WriteLine($"\t\tushort  : {ushort.MinValue} ... {ushort.MaxValue}");
        Console.WriteLine($"\t\tint     : {int.MinValue} ... {int.MaxValue}");
        Console.WriteLine($"\t\tuint    : {uint.MinValue} ... {uint.MaxValue}");
        Console.WriteLine($"\t\tlong    : {long.MinValue} ... {long.MaxValue}");
        Console.WriteLine($"\t\tulong   : {ulong.MinValue} ... {ulong.MaxValue}");

    Console.WriteLine("\n\tFloating-point numbers:\n");

        Console.WriteLine($"\t\tfloat   : {float.MinValue} ... {float.MaxValue}");
        Console.WriteLine($"\t\tdouble  : {double.MinValue} ... {double.MaxValue}");
        Console.WriteLine($"\t\tdecimal : {decimal.MinValue} ... {decimal.MaxValue}");

    Console.WriteLine("\n\tOthers:\n");

        Console.WriteLine($"\t\tchar    : {(int)char.MinValue} ... {(int)char.MaxValue}");
        Console.WriteLine($"\t\tbool    : {bool.FalseString} / {bool.TrueString}");
