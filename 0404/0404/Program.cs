using _0404;

Circle c = new Circle(new Point(3, 4), 6);
Rectangle r = new Rectangle(new Point(5, 2), 3, 7);


Console.WriteLine(c);
Console.WriteLine(r);

Shape s = new Circle(new Point(1, 3), 5);
s.Draw();

s = new Rectangle(new Point(3, 0), 3, 6);
s.Draw();
