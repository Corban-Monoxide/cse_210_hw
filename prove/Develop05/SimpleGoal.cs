public class SimpleGoal:Goal
{
    private bool completed;
    public SimpleGoal():base()
    {
        completed = false;
    }
    public SimpleGoal(string filename)
    {
        completed = false;
    }

    // public override string Export() 
    // {
    //     base.Export();
    // }
}