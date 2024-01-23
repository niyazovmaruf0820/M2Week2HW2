namespace task3;

public class Student
{
    public string Name {get; set;}
    public int GradeLevel{get; set;}
    public int[] TestScores{get; set;}
    public double GetAverage()
    {
        int s = 0;
        for (int i = 0; i < TestScores.Length; i++)
        {
            s += TestScores[i];
        }
        return s / TestScores.Length;
    }
    public string GetInfo()
    {
        if (GetAverage() >= 80) return $"Congratulations {Name} on achieving above average scores {GetAverage()} in grade {GradeLevel}! Keep up the good work!";
        else return $"{Name}, if you're having difficulties with your studies, don't hesitate to seek help. Your current average score is {GetAverage()} in grade {GradeLevel}.";
    }
}
