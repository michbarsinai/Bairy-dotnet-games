using System;

public class Actor {

    private int movieCount;
    private string gender;

    public int MovieCount{ get; }
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
        Gender = aGender; 
        movieCount = aMovieCount;
    }
    // public Actor( string Name, string gender, int movieCount ) {
    //     this.Name = Name;
    //     this.gender = gender;
    //     this.movieCount = movieCount;
    // }

    public void AddMovie() {
        movieCount = MovieCount+1;
    }

    public void joinAsStar( Movie m ) {
        m.MainStar = this;
    }

    public void joinAsSupporting( Movie m ) {
        m.SupportingRole = this;
    }
}

