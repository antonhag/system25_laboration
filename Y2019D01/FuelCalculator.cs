namespace Y2019D01;

public class FuelCalculator
{
    public int CalculateFuel(int mass)
    {
        return mass / 3 - 2;
    }
    
    public int CalculateTotalFuel(int[] masses)
    {
        int totalFuel = 0;
        
        foreach (var mass in masses)
        {
            totalFuel += CalculateFuel(mass);
        }
        return totalFuel;
    }

    public int CalculateAdvancedFuel(int mass)
    {
        if (mass <= 0)
        {
            return 0;
        }
        else
        {
            Console.WriteLine(mass);
            var fuel = Math.Max(CalculateFuel(mass), 0);
            return CalculateFuel(mass) + CalculateAdvancedFuel(fuel);
        }
    }

}