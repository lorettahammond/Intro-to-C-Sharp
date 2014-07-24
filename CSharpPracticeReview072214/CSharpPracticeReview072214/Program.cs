using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeReview072214
{
    class Program
    {
        static void Main(string[] args)             //Scope: var is only good between the {} within the static void Main method
        {

            //var x = new System.DateTime();          //Could be System.DateTime(); known as fully qualified name; built into C# system
           // Console.WriteLine("Hello, World!");     //Displays message in Console
            //Console.ReadKey();                      //Keeps Console open

            var task = new Task();

            //task.Timestamp = new DateTime(2015, 1, 1);

            task._currentDate = new DateTime(2015, 1, 1);       //allows for future dates, which bypasses validation

            var timeStamp = task.Timestamp;
            var taskName = task.TaskName;
            var x = task._taskDescription;

            Console.WriteLine(timeStamp);

            var newTimeStamp = timeStamp.AddDays(1);    
            task.Timestamp = newTimeStamp;              //newTimeStamp must match that set up with var
            

            var existingTask = new Task(42);

        }

        public class Task
        {
            public DateTime _currentDate;      // _currentDate - personal naming convention
            public string _taskDescription;     //not a good idea to make public; anyone can see, use, & change, bypassing code; 
                                                //shows up in Intellisense
            public Task(int id)
            {
                //look up id from the database
            }
            public Task()
            {
                _currentDate = DateTime.Now;
                TaskName = "Default task name";

                //var CurrentDate = new DateTime();

                var bar = "Test";


                //Do an initialization
                //lookup info from databses
                //open files
                //feed lamas
                //get permissions
                //etc...
            }

            public bool CancelTask()
            {
                //step 1
                doStep1();
                //step 3
                doStep3();
                //step 2
                doStep2();

                return false;
            }

            private void doStep1()
            {

            }

            private void doStep2()
            {

            }

            private void doStep3()
            {

            }
            
            
            public DateTime Timestamp                   // Timestamp property of DateTime class
            {
                get { return _currentDate;}

                //set { _currentDate = value;}

                set
                {
                if (value < DateTime.Now)               //does not allow for future dates/days
                {
                    _currentDate = value;
                }
                else
                {
                    _currentDate = DateTime.Now;
                }
            }
                
            }

            public string TaskName { get; set; }        //easier way of getting/setting property
        }

    }
}
