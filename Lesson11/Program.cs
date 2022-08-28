using System;

class Program
{
    static void Main(string[] args)
    {
        Courses Mat = new Courses();
        Mat.Name = "Mathematic";
        Mat.Id = 100000;

        Puples Pup1 = new Puples("Vasya Pupkin", 123456, Mat);
        Teachers Teach1 = new Teachers("Maria_Ivanovna", 654321, "mathematic");
        Schedule Schedule1 = new Schedule(new DateTime(2023, 1, 1, 9, 0, 0), Mat, Teach1);
    }
}

 class Teachers
{
    string Name { get; set; }
    int Id { get; set; }
    string Specialty { get; set; }

    public Teachers(string name, int id, string specialty)
    {
        Name = name;
        Id = id;
        Specialty = specialty;
    }
}

 class Puples
{   
    string Name { get; set; }
    int Id { get; set; }
    Courses Course;

    public Puples(string name, int id, Courses cours)
    {
        Name = name;
        Id = id;
        Course = cours;
    }
}

class Schedule
{
    DateTime DataOfCourse;
    Courses Course;
    Teachers Teacher;

    public Schedule(DateTime data, Courses cours, Teachers teacher)
    {
        DataOfCourse = data;
        Course = cours;
        Teacher = teacher;
    }
}

 class Courses
{
    public string Name { get; set; }
    public int Id { get; set; }
    public string Description { get; set; }
}
//checked
