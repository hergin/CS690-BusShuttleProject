namespace BusShuttle.Tests;

using BusShuttle;

public class DataManagerTests
{
    DataManager dataManager;

    public DataManagerTests() {
        File.WriteAllText("stops.txt","One"+Environment.NewLine+"Two"+Environment.NewLine+"Three"+Environment.NewLine+"Four"+Environment.NewLine+"Five");
        File.WriteAllText("drivers.txt","Driver1"+Environment.NewLine+"Driver2");

        dataManager = new DataManager();
    }

    [Fact]
    public void Test_AddStop()
    {
        Assert.Equal(5,dataManager.Stops.Count);
        dataManager.AddStop(new Stop("new stop"));
        Assert.Equal(6,dataManager.Stops.Count);
    }

    [Fact]
    public void Test_AddDriver()
    {
        Assert.Equal(2,dataManager.Drivers.Count);
        dataManager.AddDriver(new Driver("new driver"));
        Assert.Equal(3,dataManager.Drivers.Count);
    }

}