public class Job
{
   public string company;
   public string jobTitle;
   public int startYear;
   public int endYear;
   public void DisplayJobDetails()
   {
    Console.WriteLine($"{jobTitle} at {company} from {startYear}-{endYear}");
   }
}