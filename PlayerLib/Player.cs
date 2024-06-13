using System.Net.Http.Headers;

namespace PlayerLib
{
    public class Player
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Number { get; set; }
        public string Position { get; set; }

        public override string ToString()
        {
            return $"{Id} {FirstName} {LastName} ({Number}) - {Position}";
        }

        public void ValidateFirstNameLength()
        {
            if (FirstName.Length < 3)
            {
                throw new ArgumentOutOfRangeException("First name must be at least 3 characters long.");
            }
        }

        public void ValidateLastNameLength()
        {
            if (LastName.Length < 3)
            {
                throw new ArgumentOutOfRangeException("Last name must be at least 3 characters long.");
            }
        }

        public void ValidateNumber()
        {
            if (Number < 1 || Number > 99)
            {
                throw new ArgumentOutOfRangeException("Number must be between 1 and 99.");
            }
        }

        public void ValidatePosition()
        {
            if (Position != "Forward" && Position != "Midfielder" && Position != "Defender" && Position != "Goalkeeper")
            {
                throw new ArgumentException("Position must be Forward, Midfielder, Defender, or Goalkeeper.");
            }
        }

    }


}
