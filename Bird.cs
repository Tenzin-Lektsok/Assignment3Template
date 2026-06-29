public class Bird : IComparable
{
    // Store bird name.
    public string Name { get; set; }

    // Store bird position on the grid.
    public int X { get; set; }
    public int Y { get; set; }

    // Constructor to create a bird with name and position.
    public Bird(string name, int x, int y)
    {
        Name = name;
        X = x;
        Y = y;
    }
    // Compare bird names for sorting.
    public int CompareTo(object? obj)
    {
        Bird other = (Bird)obj;
        return Name.CompareTo(other.Name);
    }

    // Return bird name and position as a string.
    public override string ToString()
    {
        return Name + "(" + X + "," + Y + ")";
    }
}