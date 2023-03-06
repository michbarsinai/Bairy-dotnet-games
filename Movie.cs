public class Movie {

    public Actor? MainStar { get; set; }
    public Actor? SupportingRole { get; set; }

    public string Name{ get; set; }

    public Movie( string aName ) {
        Name = aName;
    }
}