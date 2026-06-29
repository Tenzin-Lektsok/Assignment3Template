public class Bird : Animal
{
    // declare Speed as a property of type double to track how far the bird moved in each round
    // double is used because speed can have decimal values like 14.28
    public double Speed { get; set; }

    // constructor calls base Animal constructor to set Name, ID, X, Y, Z
    // we add id and z as per assignment 3
    public Bird(string name, string id, int x, int y, int z) : base(name, id, x, y, z)
    {

    }

     // return bird name, ID and position as a string
     // updated from A2 to include ID and Z coordinate
     public override string ToString()
     {
    return Name + "(ID:" + ID + " X:" + X + " Y:" + Y + " Z:" + Z + ")";
    }
    // Reference Assignment3 specification of Animals sections
    // "birds can move at most +/-10 in X, Y and +/-2 in Z"
    // "max speed of sqrt(10^2 + 10^2 + 4^2) = 14.28"
    // "when a bird exceeds speed of 5 all cats within 15 units can hear it"
    // "when a bird exceeds speed of 10 all snakes within 10 units can hear it"
    // https://www.geeksforgeeks.org/c-sharp/c-sharp-random-next-method/
    // Next(minValue, maxValue) method returns >= minValue and  < maxValue
    // maxValue is the exclusive upper boundary of the random number generated.
    // minValue is the inclusive lower bound of the random number returned
    // so random.Next(-10, 11) gives -10 to 10 because 11 is exclusive
    // and random.Next(-2, 3) gives -2 to 2 because 3 is exclusive
    // this matches assignment rule of +/-10 in X and Y and +/-2 in Z

    // https://stackoverflow.com/questions/23937825/calculating-the-distance-between-2-points-in-2d-and-3d
     // Speed property needed to track how fast bird moved each round using formula FindDistance
     //we compare old position and new position of same bird instead of two animals
     public void Move(Random random)
     {
        // save old position before moving so we can calculate speed
        int oldX = X;
        int oldY = Y;
        int oldZ = Z;
        
         // Update the X, Y and Z positions by adding a random movement.
        // X and Y change by -10 to 10, and Z changes by -2 to 2, as specified in the assignment. 
        X =  X + random.Next(-10, 11);
        Y =  Y + random.Next(-10, 11);
        Z = Z + random.Next(-2, 3);

         // assignment says max speed = squareroot(10^2 + 10^2 + 4^2) = 14.28
         // we calculate speed same way and dx, dy, dz are the difference between new position and old position
         int dx = X - oldX;
         int dy = Y - oldY;
         int dz = Z - oldZ;
         Speed = Math.Sqrt(dx * dx + dy * dy + dz * dz);

     }

}
