<Query Kind="Statements" />

var rect = new Rectangle (12, 13);
Console.WriteLine (rect.ToString());

class Rectangle
{
	public readonly float Width, Height;
	public void Deconstruct (out float width, out float height) => (width, height) = (Width, Height);
	public Rectangle (float width, float height) => (Width, Height) = (width, height);
	public override string ToString() => $"A rectangle with a width of {Width} and a height of {Height}.";
}

