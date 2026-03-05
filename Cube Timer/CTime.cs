using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cube_Timer
{
    public class CTime
    {
        //props - minutes, seconds and milliseconds
        public int Minutes { get; set; } = 0;
        public int Seconds { get; set; } = 0;
        public int Milliseconds { get; set; } = 0;

        public CTime()
        {

        }
        public CTime(int minutes, int seconds, int milliseconds)
        {
            //takes in 3 params (m:s:ms) and sets props to that data.
            Minutes = minutes;
            Seconds = seconds;
            Milliseconds = milliseconds;
        }
        public CTime( CTime inCTime)
        {
            //takes in 1 param (CTime) and copies props.
            Minutes = inCTime.Minutes;
            Seconds = inCTime.Seconds;
            Milliseconds= inCTime.Milliseconds;
        }

        public override string ToString()
        {
            string outSeconds = "", outMs = "";

            if (Seconds < 10)
            {
                outSeconds = $"0{Seconds}";
            }
            else
            {
                outSeconds = Seconds.ToString();
            }

            if(Milliseconds < 100)
            {
                if(Milliseconds < 10)
                {
                    outMs = $"00{Milliseconds}";
                }
                else
                {
                    outMs = $"0{Milliseconds}";
                }
            }
            else
            {
                outMs = Milliseconds.ToString();
            }

                return $"{Minutes}:{outSeconds}  {outMs}";
        }

        public int GetValue()
        {
            return (Minutes * 60000) + (Seconds * 1000) + Milliseconds;
        }

        public static CTime FromMilliseconds(int milliseconds)
        {
            int m = milliseconds / 60000;
            int s = (milliseconds % 60000) / 1000;
            int ms = milliseconds % 1000;

            return new CTime(m, s, ms);
        }
    }
}
