public class Resume
{
    public string name;
    public List<Job> jobList = new List<Job>();
    public void DisplayResumeList()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Jobs: ");

        foreach(Job job in jobList)
        {
            job.DisplayJobDetails();
        }

    }
}