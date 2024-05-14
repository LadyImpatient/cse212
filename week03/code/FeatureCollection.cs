using System.ComponentModel;

public class FeatureCollection {
    // Todo Earthquake Problem - ADD YOUR CODE HERE
    public List<Feature> Features { get; set; }
} 

public class Feature {
    public RefreshProperties Properties { get; set; }
}

public class Properties {
    public string Place { get; set; }
    public float Mag { get; set; }
}