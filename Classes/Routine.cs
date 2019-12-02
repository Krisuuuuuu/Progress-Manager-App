using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Progress_Manager.Enums;
namespace Progress_Manager.Classes
{
    [Serializable]
    public abstract class Routine
    {
        public string RoutineName { get; set; }

        public List<OneDaySession> SessionsList = new List<OneDaySession>();

        public Dictionary<DaysOfWeek, bool> WhenIHaveToWorkout = new Dictionary<DaysOfWeek, bool>();

        public byte TotalSessions { get; set; }

        public bool IsEmpty { get; set; }

        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }

        public TimeSpan Duration { get; private set; }

        public Routine()
        {
            RoutineName = "";
            TotalSessions = 0;
            IsEmpty = true;
            Start = DateTime.Now;
            Finish = Start.AddDays(60);
            Duration = Finish.Subtract(Start);
            WhenIHaveToWorkout.Add(DaysOfWeek.MONDAY, false);
            WhenIHaveToWorkout.Add(DaysOfWeek.TUESDAY, false);
            WhenIHaveToWorkout.Add(DaysOfWeek.WEDNESDAY, false);
            WhenIHaveToWorkout.Add(DaysOfWeek.THURSDAY, false);
            WhenIHaveToWorkout.Add(DaysOfWeek.FRIDAY, false);
            WhenIHaveToWorkout.Add(DaysOfWeek.SATURDAY, false);
            WhenIHaveToWorkout.Add(DaysOfWeek.SUNDAY, false);
        }

        public Routine(string name, DateTime start, DateTime finish)
        {
            this.RoutineName = name;
            this.TotalSessions = 0;
            this.IsEmpty = true;
            this.Start = start;
            this.Finish = finish;
            this.Duration = Finish.Subtract(Start);
            WhenIHaveToWorkout.Add(DaysOfWeek.MONDAY, false);
            WhenIHaveToWorkout.Add(DaysOfWeek.TUESDAY, false);
            WhenIHaveToWorkout.Add(DaysOfWeek.WEDNESDAY, false);
            WhenIHaveToWorkout.Add(DaysOfWeek.THURSDAY, false);
            WhenIHaveToWorkout.Add(DaysOfWeek.FRIDAY, false);
            WhenIHaveToWorkout.Add(DaysOfWeek.SATURDAY, false);
            WhenIHaveToWorkout.Add(DaysOfWeek.SUNDAY, false);
        }

        public virtual void UpdateRoutine()
        {
            TotalSessions = (byte)SessionsList.Count();

            if (TotalSessions == 0)
                IsEmpty = true;
            else
                IsEmpty = false;
        }

        public bool CheckDayAndName(OneDaySession mySession)
        {
            bool isIn = false;
            bool isConfirmed = true;

            foreach (OneDaySession oneDaySession in SessionsList)
            {
                if (oneDaySession.SessionName == mySession.SessionName)
                    isIn = true;
            }

            if (isIn == true)
            {
                MessageBox.Show("This session (" + mySession.SessionName + ") has been added before.");
                isConfirmed = false;;
            }
            else
            {
                bool isBusy;

                if (WhenIHaveToWorkout[mySession.Day] == true)
                    isBusy = true;
                else
                    isBusy = false;

                if (isBusy == true)
                {
                    MessageBox.Show("This day (" + mySession.Day.ToString() + ") is busy.");
                    isConfirmed = false;
                }
            }

            if (isConfirmed == true)
                return true;
            else
                return false;
        }

        public void Add(OneDaySession mySession)
        {
            bool isConfirmed = CheckDayAndName(mySession);

            if(isConfirmed == true)
            {
                SessionsList.Add(mySession);
                WhenIHaveToWorkout[mySession.Day] = true;
                UpdateRoutine();
            }

        }

        public void Delete(OneDaySession mySession)
        {
            if(IsEmpty==true)
            {
                MessageBox.Show("Session list is empty.");
                return;
            }
            else
            {
                bool isIn=SessionsList.Contains(mySession);

                if(isIn==true)
                {
                    int index = SessionsList.IndexOf(mySession);
                    WhenIHaveToWorkout[mySession.Day] = false;
                    SessionsList.RemoveAt(index);
                    UpdateRoutine();
                }
                else
                {
                    MessageBox.Show("This session (" + mySession.SessionName + ") does not exist on session list.");
                    return;
                }
            }
        }
    }
}
