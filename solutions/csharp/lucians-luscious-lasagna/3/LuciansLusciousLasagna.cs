class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven() => 40;
    
    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int minutesToSubtract) => (this.ExpectedMinutesInOven() - minutesToSubtract);
    
    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int layers) => (layers * 2);

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layersAdded, int minutesInOven) => ((layersAdded * 2) + minutesInOven);
}
