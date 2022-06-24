
// Lucian's Luscious Lasagna

class Lasagna

{
    public int ExpectedMinutesInOven() => 40;

    public int RemainingMinutesInOven(int OvenTime) => ExpectedMinutesInOven() - OvenTime;
    
    public int PreparationTimeInMinutes(int PrepTime) => PrepTime * 2;
    
    public int ElapsedTimeInMinutes(int PrepTime,int OvenTime) => PreparationTimeInMinutes(PrepTime) + OvenTime;
    
    
}
