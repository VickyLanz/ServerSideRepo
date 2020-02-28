using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChanllenge2002
{
    class Program
    {
        static void Main(string[] args)
        {          
            Console.WriteLine("Enter The Number of Subjects");
            int n = int.Parse(Console.ReadLine());
            int[] marks = new int[n];
            Console.WriteLine("Enter The Marks of {0} Subjects",n);
            for(int i=0;i<n;i++)
            {
                string m = Console.ReadLine();
                marks[i] = int.Parse(m);
            }
            Student s = new Student();       
            double re = s.GetAverageMarks(marks);
            s.ShowGrade(re);
        }
    }
    public interface IStudents
    {
        double GetAverageMarks(int[] m);
        void ShowGrade(double avg);
    }
    public class Student :IStudents
    {
        public double GetAverageMarks(int[] m)
        {
            double s = m.Sum();  
            int l = m.Length;           
            double avg = s / l;          
            return avg;
        }
        public void ShowGrade(double avg)
        {
            if(avg>70)
            {
                Console.WriteLine("Congradulations... Passed in Distinction");
            }
            else
            {
                Console.WriteLine("Better Luck Next Time.....Not a Distinction");
            }
        }
    }
}
