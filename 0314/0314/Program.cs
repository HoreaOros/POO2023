// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

DateTime dateTime = DateTime.Now;
Console.WriteLine(dateTime);

DateTime dateTimeUTC = DateTime.UtcNow;
Console.WriteLine(dateTimeUTC);

Console.WriteLine(dateTime.ToUniversalTime());
Console.WriteLine(dateTime.ToShortDateString());
Console.WriteLine(dateTime.ToShortTimeString());

DateTime dateTime2 = dateTime.AddHours(3.5);
Console.WriteLine(dateTime2);

Console.WriteLine(dateTime.CompareTo(dateTime2));

Console.WriteLine(dateTime == dateTime2);
Console.WriteLine(dateTime < dateTime2);

Console.WriteLine(dateTime - dateTime2);



MyDateTime md = new MyDateTime(14, 3, 2023, 8, 59, 42);
Console.WriteLine(md);

MyDateTime md2 = new MyDateTime(23, 6, 2023);
MyDateTime md3 = new MyDateTime(an: 2025, luna: 12, zi: 13);
Console.WriteLine(md3);

if (md2 == md3)
{
    Console.WriteLine($"{md2} / {md3} sunt egale");
}
else
{
    Console.WriteLine($"{md2} / {md3} nu sunt egale");
}

Console.WriteLine(md2 - md3); // 


