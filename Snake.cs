using System;

public class Snake : IComparable
{
    //Store snake name.
    public string Name { get; set; }

    //Store snake position on the grid.
    public int X { get; set; }
    public int Y { get; set; }

    //Constructor to create snake with snake with name and position
    public Snake(string name, int x, int y)
    {
        Name = name;
        X = x;
        Y = y;
    }

    //Compare snake names for sorting.
    public int CompareTo(object? obj)
    {
        Snake other = (Snake)obj;
        return Name.CompareTo(other.Name);
    }

    //Move one step toward the bird.
    public void MoveToward(Bird bird)
    {
        int dx = bird.X - X;
        int dy = bird.Y - Y;

        if (dx > 0)
            X++;
        else if (dx < 0)
            X--;

        if (dy > 0)
            Y++;
        else if (dy < 0)
            Y--;

        Console.WriteLine(Name + " moved to (" + X + ", " + Y + ")");
    }

    //Snake eats the first bird in the list.
    public void EatBird(MyArrayList<Bird> birds)
    {
        if (birds.GetCount() > 0)
        {
            birds.DeleteFirst();
            Console.WriteLine(Name + " ate a bird.");
        }
    }
    //Return snake name and position as a string.
    public override string ToString()
    {
        return Name + "(" + X + "," + Y + ")";
    }
}