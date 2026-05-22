public class FeatureCollection
{
    // This property matches the "features" array in the USGS JSON data.
    public Feature[] Features { get; set; } = [];
}

public class Feature
{
    // This property matches the "properties" object inside each feature.
    public EarthquakeProperties Properties { get; set; } = new();
}

public class EarthquakeProperties
{
    // This property matches the earthquake location.
    public string Place { get; set; } = "";

    // This property matches the earthquake magnitude.
    public double Mag { get; set; }
}