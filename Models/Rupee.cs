namespace PathTrainingOoTRandomizer.Models
{
    public class Rupee
    {
        public short level = 1;
        public short number = 0;
        public short maxNumber = 99;

        public void AddRupee()
        {
            this.number += 1;

            if (this.number > maxNumber)
            {
                this.number = maxNumber;
            }
        }

        public void AddRupees(short amount)
        {
            this.number += amount;

            if(this.number > maxNumber)
            {
                this.number = maxNumber;
            }
        }
    }
}
