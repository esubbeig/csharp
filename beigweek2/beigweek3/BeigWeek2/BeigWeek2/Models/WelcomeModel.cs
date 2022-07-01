namespace BeigWeek2.Models
{
    //created by Beig
    public class WelcomeModel
    {
        //creating two properties one for Name and one for Number.
        public string Name { get; set; }
        public int Number { get; set; }

        //creating two methods one for calculating square of a number and
        //one method for calculating square root
        public int GetSquare()
        {
            return (int)Math.Pow(Number, 2);
        }//end GetSquare()

        public double GetRoot()
        {
            return Math.Sqrt(Number);
        }//end GetRoot()

    }//end class Welcome Model
}//end Namespace
