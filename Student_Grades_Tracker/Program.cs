namespace Student_Grades_Tracker
{
    internal class Program
    {
       static void GetLevel(double averageGrade,string studentName)
        {
            if (averageGrade >= 0 && averageGrade <= 20)
            {
                Console.WriteLine($"{studentName} average grade is {averageGrade} and he is freshman");
            }
            else if (averageGrade > 20 && averageGrade <= 40)
            {
                Console.WriteLine($"{studentName} average grade is {averageGrade} and he is sophomore");
            }
            else if (averageGrade > 40 && averageGrade <= 80)
            {
                Console.WriteLine($"{studentName} average grade is {averageGrade} and he is junior");
            }
            else if (averageGrade > 80 && averageGrade <= 100)
            {
                Console.WriteLine($"{studentName} average grade is {averageGrade} and he is senior");
            }
        }
        static void Main(string[] args)
        {
            List<double> ahmedGrades = new List<double>();
            List<double> aliGrades = new List<double>();
            List<double> kareemGrades = new List<double>();
            ahmedGrades.AddRange(new double[] { 76, 90, 70, 81 });
            aliGrades.AddRange(new double[] { 90, 83, 65, 92 });
            kareemGrades.AddRange(new double[] { 88, 81, 90, 78 });
            double averageGrade = 0;

            for (int i = 0; i < ahmedGrades.Count; i++) 
            {
                averageGrade += (ahmedGrades[i]);
            }
            averageGrade /= ahmedGrades.Count;
            GetLevel(averageGrade,"Ahmed");

            averageGrade = 0;
            for (int i = 0; i < aliGrades.Count; i++)
            {
                averageGrade += (aliGrades[i]);
            }
            averageGrade /= aliGrades.Count;
            GetLevel(averageGrade, "Ali");


            averageGrade = 0;
            for (int i = 0; i < kareemGrades.Count; i++)
            {
                averageGrade += (kareemGrades[i]);
            }
            averageGrade /= kareemGrades.Count;
            GetLevel(averageGrade, "Kareem");


        }
    }
}
