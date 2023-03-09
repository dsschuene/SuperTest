namespace MusicalInstrunments
{
    public class Instrunment {
        public bool woodwind {get; set;}
        public bool percussion {get; set;}
        public bool strings {get; set;}
        public bool brass {get; set;}

        public Instrunment() {
            this.woodwind = false;
            this.percussion = false;
            this.strings = false;
            this.brass = false;
        }
    }

    public class Guitar : Instrunment {
        public int numberOfStrings {get; set;} 
        public Guitar(){
            this.woodwind = false;
            this.percussion = false;
            this.strings = true;
            this.brass = false;
            this.numberOfStrings = 0;
        }
    }
}