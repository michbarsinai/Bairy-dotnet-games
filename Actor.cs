using System;

public class Actor {

    private int movieCount;
    private String gender;

    public int MovieCount{ 
        get {
            return movieCount;
        }
    }
    public string Name { get; set; }
    public string Gender { 
        get {
            return gender;
        }
        set {
            if ( value == "M" || value == "F" ) {
                gender = value;
            } else {
                throw new Exception("Not a valid gender value: " + value );
            }
        }
    }
    
    public Actor( string aName, string aGender, int aMovieCount ) {
        Name = aName;
        gender = aGender;
        movieCount = aMovieCount;
    }

    public void AddMovie() {
        movieCount = MovieCount+1;
    }

}

