using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    //delegates
    public delegate int WorkPereformedHandler(int hours, WorkType workType);
    public class Worker
    {
        //events
        public event WorkPereformedHandler WorkPereformed;
        public event EventHandler WorkCompleted;

        public void DoWork(int hours, WorkType workType)
        {
            //Do work here and notify consumer that work has been performed
            for (int i = 0; i < hours; i++)
            {
                OnWorkPereformed(i+1, workType);
            }
            OnWorkCompleted();
        }

        protected virtual void OnWorkPereformed(int hours, WorkType workType) // function that raise event
        {
            //if (WorkPereformed!=null)
            //{
            //    WorkPereformed(hours, workType);
            //}

            var del = WorkPereformed as WorkPereformedHandler; //cast event as delegate
            if (del != null)
            {
                del(hours,workType); //raise event
            }
        }
        protected virtual void OnWorkCompleted()
        {
            //if (WorkPereformed!=null)
            //{
            //    WorkPereformed(hours, workType);
            //}

            var del = WorkCompleted as EventHandler;
            if (del != null)
            {
                del(this, EventArgs.Empty);
            }
        }
    }
}
