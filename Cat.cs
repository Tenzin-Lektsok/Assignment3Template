public class Cat : Animal
{
    
    // constructor calls base Animal constructor to set Name, ID, X, Y, Z
    //we add id and z as per assignment3 
    public Cat(string name, string id, int x, int y, int z) : base(name, id, x, y, z)
    {
        //initialize empty smell list
        SmellList = new DoublyLinkedList<Animal>();    

    }

    // Compare cat names for sorting.
    public int CompareTo(object? obj)
    {
        Cat other = (Cat)obj;
        return Name.CompareTo(other.Name);
    }
    // Move one step toward the bird.
    public void MoveToward(Bird bird)
    {
        int dx = bird.X - X;
        int dy = bird.Y - Y;

        if (dx > 0) X++;
        else if (dx < 0) X--;

        if (dy > 0) Y++;
        else if (dy < 0) Y--;

        Console.WriteLine(Name + " moved to (" + X + ", " + Y + ")");
    }

    // Cat eats the first bird in the list.
    public void EatBird(MyArrayList<Bird> birds)
    {
        if (birds.GetCount() > 0)
        {
            birds.DeleteFirst();
            Console.WriteLine(Name + " ate a bird.");
        }
    }
    // Return cat name and position as a string.
    public override string ToString()
    {
        return Name + "(" + X + "," + Y + ")";
    }
}
