using System;

namespace LogAn
{
    public class LogAnalyzer
    {

        private bool wasLastFileNameValid;


        public bool WasLastFileNameValid
        {
            get
            {
                return wasLastFileNameValid;
            }

            set
            {
                wasLastFileNameValid = value;
            }
        }
        public bool IsValidLogFileName(String filename)
        {

            if (String.IsNullOrEmpty(filename))
            {
                throw new ArgumentException("No filename providerd!");
            }

            if (!filename.ToLower().EndsWith(".slf"))
            {
                wasLastFileNameValid = false;
                return false;
            }

            wasLastFileNameValid = true;

            return true;
        }
    }
}
