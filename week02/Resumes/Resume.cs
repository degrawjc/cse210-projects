using System.Security.Cryptography.X509Certificates;

public class Resume
{
public string _name = "";
public List<Job> _joblist = new List<Job>();
public void DisplayResume()
{
Console.WriteLine($"Name: {_name}");
Console.WriteLine("Jobs:");

foreach (Job job in _joblist)
{
job.DisplayJobDetails();
}
}

}