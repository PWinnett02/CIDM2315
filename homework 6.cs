//Professor class
class Professor
{
    //Public variables
    public String profName;
    public String classTeach;
    private double salary;

    //setter for salary
    public void SetSalary(double salary_amount)
    {
        this.salary = salary_amount;
    }
    
    //getter for salary
    public double GetSalary()
    {
        return this.salary;
    }
}

//Student class
class Student
{
    //variables
    public String studentName;
    public String classEnroll;
    private double studentGrade;

    //setter for grade
    public void SetGrade(double newGrade)
    {
        this.studentGrade = newGrade;
    }

    //getter for grade
    public double getGrade()
    {
        return this.studentGrade;
    }
}

public class StudentProfessor
{
    public static void main(String[] args)
    {
        //creating objects 
        Professor prof1 = new Professor();
        Professor prof2 = new Professor();

        //assigning values
        prof1.profName = "Alice";
        prof1.classTeach = "Java";
        prof1.SetSalary(9000);

        prof2.profName = "Bob";
        prof2.classTeach = "Math"
        prof2.SetSalary(8000);

        Student stud1 = new Student();
        Student stud2 = new Student();

        stud1.studentName = "Lisa";
        stud1.classEnroll = "Java";
        stud1.SetGrade(90);

        stud2.studentName = "Tom";
        stud2.classEnroll = "Math";
        stud2.SetGrade(80);

        //printing result
        System.Out.println("Professor" + prof1.profName + "teaches" + prof1.classTeach + ", and the salary is:" + prof1.GetSalary());
        System.Out.println("Professor" + prof2.profName + "teaches" + prof2.classTeach + ", and the salary is:" + prof2.GetSalary());

        System.Out.println("Student" + stud1.studentName + "enrolls" + stud1.classEnroll + ", and the grade is: " + stud1.getGrade());
        System.Out.println("Student" + stud2.studentName + "enrolls" + stud2.classEnroll + ", and the grade is: " + stud2.getGrade());

        System.Out.println("The salary difference between " + prof1.profName + " and" + prof2.profName + " is: " + (prof1.GetSalary() - prof2.GetSalary()));
        System.Out.println("The total grade of " + stud1.studentName + " and" + stud2.studentName + " is: " + (stud1.getGrade() + stud2.getGrade()));
    }
}