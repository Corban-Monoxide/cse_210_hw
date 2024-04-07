// public class Files
// {
//     public Files()
//     {

//     }
//     public static void Save(string filename, List<Goal> allGoals)
//     {
//         var data = new List<string>();
//         foreach (var goal in allGoals)
//         {
//             var typeString = "";
//             if (goal is SimpleGoal)
//             {
//                 typeString = "S:";
//             }
//             else if (goal is ChecklistGoal)
//             {
//                 typeString = "C:";
//             }
//             else if (goal is EternalGoal)
//             {
//                 typeString = "E:";
//             }

//             data.Add(typeString + goal.Export());
//         }
//         System.IO.File.WriteAllLines(filename, data);
//     }
//     // public static List<Goal> Load(string filename)
//     // {
//     //     var lines = ReadFile(filename);
//     //     var goals = new List<Goal>();

//     //     foreach (var line in lines)
//     //     {
//     //         var typeString = lines[0..2];
//     //         if (typeString == "S:")
//     //         {
//     //             goals.Add(new SimpleGoal(line[2..]));
//     //         }
//     //         else if (typeString == "E:")
//     //         {
//     //             goals.Add(new EternalGoal(line[2..]));
//     //         }
//     //         else if (typeString == "C:")
//     //         {
//     //             goals.Add(new ChecklistGoal(line[2..]));
//     //         }
//     //     }
//     // return goals;
//     // }
// // }
public class Files
{
    public static void Save(string filename, List<Goal> allGoals)
    {
        var data = new List<string>();
        foreach (var goal in allGoals)
        {
            var typeString = "";
            if (goal is SimpleGoal)
            {
                typeString = "S:";
            }
            else if (goal is ChecklistGoal)
            {
                typeString = "C:";
            }
            else if (goal is EternalGoal)
            {
                typeString = "E:";
            }

            data.Add(typeString + goal.Export());
        }
        System.IO.File.WriteAllLines(filename, data);
    }

    public static List<Goal> Load(string filename)
    {
        var lines = System.IO.File.ReadAllLines(filename);
        var goals = new List<Goal>();

        foreach (var line in lines)
        {
            var typeString = line.Substring(0, 2);
            var goalData = line.Substring(2);

            if (typeString == "S:")
            {
                goals.Add(new SimpleGoal(goalData));
            }
            else if (typeString == "E:")
            {
                goals.Add(new EternalGoal(goalData));
            }
            else if (typeString == "C:")
            {
                goals.Add(new ChecklistGoal(goalData));
            }
        }

        return goals;
    }
}
