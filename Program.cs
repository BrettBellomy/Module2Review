using Module2Review;

var students = new List<Student>();

var student1 = new Student
{
    Name = "Megumi",
    ID = 1,
    Grades = new List<double> { 100, 95, 97, 98, 100 }

};

var student2 = new Student
{
    Name = "Yuji",
    ID = 2,
    Grades = new List<double> { 70, 0, 82, 80, 79 }

};

var student3 = new Student
{
    Name = "Nobara",
    ID = 3,
    Grades = new List<double> { 85, 90, 82, 88, 95 }

};

var student4 = new Student
{
    Name = "Junpei",
    ID = 4,
    Grades = new List<double> { 0, 0, 0, 0, 0 }

};

students.Add(student1);
students.Add(student2);
students.Add(student3);
students.Add(student4);

student1.AddGrade(100);
student1.AddGrade(99, 92, 95);

student2.AddGrade(65);
student2.AddGrade(68, 75, 80);

student3.AddGrade(86);
student3.AddGrade(91, 100, 88);

student4.AddGrade(0);
student4.AddGrade(0, 0, 0);


Console.WriteLine("Jujutsu High First-Year Students:\n");

foreach (var student in students)
{
    Console.Write($"Name: {student.Name}\nStudent ID:{student.ID}\nGrades:");
    foreach (var grade in student.Grades)
    {
        Console.Write($"{grade},");
    }
    Console.WriteLine($"\nAverage Grade:{student.CalculateAverageGrade()}\n");
}