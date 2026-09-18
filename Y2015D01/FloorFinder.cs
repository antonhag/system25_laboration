namespace Y2015D01;

public class FloorFinder
{
    public int FindCorrectFloor(string givenDirection)
    {
        // int floor = 0;
        // var directions = givenDirection.ToCharArray();
        //
        // for (int i = 0; i < directions.Length; i++)
        // {
        //     if (directions[i] == '(')
        //     {
        //         floor++;
        //     }
        //     else
        //     {
        //         floor--;
        //     }
        // }
        //
        // return floor;

        int floor = 0;
        var directions = givenDirection.ToCharArray();

        for (int i = 0; i < directions.Length; i++)
        {
            // Testade först med floor++ och floor--, fungerade dock inte, misstänker att floor-- inte kan gå mindre än 0
            floor = directions[i] == '(' ? floor + 1 : floor - 1;
        }
        return floor;
    }
}