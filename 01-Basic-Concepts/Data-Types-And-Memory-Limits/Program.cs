// See https://aka.ms/new-console-template for more information





// --- Signed 8-bit integer (SByte) limits and memory size ---

Console.WriteLine(nameof(SByte));
Console.WriteLine($"Alt Limit       : {SByte.MinValue,20}");
Console.WriteLine($"Üst Limit       : {SByte.MaxValue,20}");
Console.WriteLine($"Boyut       : {sizeof(SByte),20}");
Console.WriteLine();
Console.ReadKey();

// --- Unsigned 8-bit integer (Byte) limits and memory size ---
Console.WriteLine(nameof(Byte));
Console.WriteLine($"Alt limit       : {Byte.MinValue,20}");
Console.WriteLine($"Üst limit       : {Byte.MaxValue,20}");
Console.WriteLine($"Boyut       : {sizeof(Byte),20}");
Console.WriteLine();
Console.ReadKey();

// --- Signed 16-bit integer (Int16 / short) ---
Console.WriteLine(nameof(Int16));
Console.WriteLine($"Alt limit       : {Int16.MinValue}");
Console.WriteLine($"Üst Limit       : {Int16.MaxValue}");
Console.WriteLine($"Boyut       : {sizeof(Int16)}");
Console.WriteLine();
Console.ReadKey();

// --- Unsigned 16-bit integer (UInt16 / ushort) ---
Console.WriteLine(nameof(UInt16));
Console.WriteLine($"Alt limit       : {UInt16.MinValue}");
Console.WriteLine($"Üst Limit       : {UInt16.MaxValue}");
Console.WriteLine($"Boyut       : {sizeof(UInt16)}");
Console.WriteLine();
Console.ReadKey();

// --- Signed 32-bit integer (Int32 / int) ---
Console.WriteLine(nameof(Int32));
Console.WriteLine($"Alt limit       : {Int32.MinValue}");
Console.WriteLine($"Üst Limit       : {Int32.MaxValue}");
Console.WriteLine($"Boyut       : {sizeof(Int32)}");
Console.WriteLine();
Console.ReadKey();

// --- Double-precision floating-point (Double) ---
Console.WriteLine(nameof(Double));
Console.WriteLine($"Alt limit       : {Double.MinValue}");
Console.WriteLine($"Üst Limit       : {Double.MaxValue}");
Console.WriteLine($"Boyut       : {sizeof(Double)}");
Console.WriteLine();
Console.ReadKey();


// NOTE: 'Signed' types store both negative and positive values (using 1 bit for the sign). 
// 'Unsigned' types cannot store negative numbers, shifting the entire range to the positive side.


