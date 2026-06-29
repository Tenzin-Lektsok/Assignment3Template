using System;

public class Snake : Animal
{
     // SmellList stores all animals within 10 unit radius of this snake
     // it updates every time the snake moves
     public DoublyLinkedList<Animal> SmellList { get; set; }

     // constructor calls base Animal constructor to set Name, ID, X, Y, Z
    //we add id and z as per assignment3 
    public Snake(string name, string id, int x, int y, int z) : base(name, id, x, y, z)
    {
        // SmellList is Snake specific so we initialize it here
         SmellList = new DoublyLinkedList<Animal>();
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
