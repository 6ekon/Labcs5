using System;

namespace Labcs5
{
    delegate void singlethreaded();

    interface writeStudents
    {
        void wrStudents();
    }

    interface newStudents
    {
        void newnStudents();
    }

    class Program
    {
        private string Student = "Richi";
        private string Teacher = "Redmond";
        private string Person = "Azimov";
        private string DepartmentHead = "Bukovski";
        public string Student1 { get => Student; set => Student = value; }
        public string Teacher1 { get => Teacher; set => Teacher = value; }
        public string Person1 { get => Person; set => Person = value; }
        public string DepartmentHead1 { get => DepartmentHead; set => DepartmentHead = value; }

        public Program(string otherStudent, string otherTeacher, string otherPerson, string otherDepartmentHead)
        {
            Student1 = otherStudent;
            Teacher1 = otherTeacher;
            Person1 = otherPerson;
            DepartmentHead1 = otherDepartmentHead;
        }

        public Program() { }

        static void Main()
        {
            Program program = new Program();
            singlethreaded prog = program.Enter;
            prog();
        }

        public void Enter()
        {
            Conrewr conrewr = new Conrewr(Student1, Teacher1, Person1, DepartmentHead1);
            Info(conrewr);
        }

        static void Info(writeStudents students)
        {
            singlethreaded mor = students.wrStudents;
            mor();
        }
    }
    class Conrewr : writeStudents
    {
        private string Stud;
        private string Teach;
        private string Pers;
        private string DepHead;

        public string Stud1 { get => Stud; set => Stud = value; }
        public string Teach1 { get => Teach; set => Teach = value; }
        public string Pers1 { get => Pers; set => Pers = value; }
        public string DepHead1 { get => DepHead; set => DepHead = value; }

        public Conrewr(string working, string frames, string engineer, string administration)
        {
            Stud1 = working;
            Teach1 = frames;
            Pers1 = engineer;
            DepHead1 = administration;
        }

        void writeStudents.wrStudents()
        {
            Console.WriteLine($"\nСтудент: {Stud1}");
            Console.WriteLine($": {Teach1}");
            Console.WriteLine($"Инженер: {Pers1}");
            Console.WriteLine($"Администрация: {DepHead1}");
            Console.Write("\nНажмите 1 для редактирования данных: ");

            if (Convert.ToInt32(Console.ReadLine()) == 1)
            {
                ReWrite write = new ReWrite();
                NewInfo(write);
            }
        }
        static void NewInfo(newStudents write)
        {
            singlethreaded mor1 = write.newnStudents;
            mor1();
        }
    }


    class ReWrite : newStudents
    {
        private string New_Students;
        private string New_Teachers;
        private string New_Persons;
        private string New_Heads;
        public string New_Students1 { get => New_Students; set => New_Students = value; }
        public string New_Teachers1 { get => New_Teachers; set => New_Teachers = value; }
        public string New_Persons1 { get => New_Persons; set => New_Persons = value; }
        public string New_Heads1 { get => New_Heads; set => New_Heads = value; }

        public ReWrite() { }

        void newStudents.newnStudents()
        {
            Console.Write("\nВведите нового рабочего: ");
            New_Students1 = Console.ReadLine();
            Console.Write("Введите новые кадры: ");
            New_Teachers1 = Console.ReadLine();
            Console.Write("Введите нового инженера: ");
            New_Persons1 = Console.ReadLine();
            Console.Write("Введите новую администрацию: ");
            New_Heads1 = Console.ReadLine();
            Program program = new Program(New_Students1, New_Teachers1, New_Persons1, New_Heads1);
            singlethreaded prog = program.Enter;
            prog();
        }
    }
}
