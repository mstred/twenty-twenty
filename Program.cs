string[] students = ["Jenna", "Ayesha", "Carlos", "Viktor"];

DisplayStudents(students);
DisplayStudents(["Robert", "Vanya"]);

void DisplayStudents(string[] students)
{
    foreach (var student in students)
        Console.Write($"{student}, ");

    Console.WriteLine();
}
