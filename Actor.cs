using System;

public class Actor {

    private int movieCount;

    public int MovieCount{ 
        get {
            return movieCount;
        }
    }
    public string Name { get; set; }
    public string Gender { get; set; }
    
    public Actor( string aName, string aGender, int aMovieCount ) {
        this.Name = aName;
        this.Gender = aGender;
        this.movieCount = aMovieCount;
    }

    public void AddMovie() {
        movieCount = MovieCount+1;
    }

}

