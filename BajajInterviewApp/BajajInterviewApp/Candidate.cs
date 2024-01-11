using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BajajInterviewApp
{
    public delegate void InterviewDelegate();
    internal class Candidate
    {
        public event InterviewDelegate SelectedCandidate;
        public event InterviewDelegate RejectedCandidate;
        private int m_CandidateId;
        //GETTER/SETTER Property
        public int CandidateId
        {
            get
            {
                return m_CandidateId;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Candidate Id must be greater than Zero!");
                }
                m_CandidateId = value;
            }
        }
        //Auto Implemented Properties
        public string ContactName { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public int TotalMarks { get; set; }

        //public string CalculateResult(int totalMarks,out bool confirmation)
        public string CalculateResult(int totalMarks, ref bool confirmation)
        {
            if (totalMarks > 80)
            {
                if(SelectedCandidate != null)
                {
                    SelectedCandidate();
                }
               confirmation = true;
                return $"{ContactName} has been selected in Bajaj! Pune!";
            }
            else
            {
                if (RejectedCandidate != null)
                {
                    RejectedCandidate();
                }
                //confirmation = false;
                return $"{ContactName} has been Rejected! Try after 6 months!";
            }
        }
        public void PrintCities(params string[] cities)
        {
            for (int i = 0; i < cities.Length; i++)
            {
                Console.WriteLine($"City - {cities[i]}");
            }
        }
    }
}
