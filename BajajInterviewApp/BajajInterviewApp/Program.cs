namespace BajajInterviewApp
{
    internal class Program
    {
        private static void Db2StudentRegistry()
        {
            Console.WriteLine("Student Record Saved in DB2 Server!");
        }
        private static void OracleStudentRegistry()
        {
            Console.WriteLine("Student Record Saved in Oracle Database!");
        }
        private static void MySqlStudentRegistry()
        {
            Console.WriteLine("Student Record Saved in MySQL Server Database!");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Bajaj Interview Application!");
            try
            {
                Candidate candidate = new Candidate();
                candidate.SelectedCandidate += OracleStudentRegistry;
                candidate.SelectedCandidate += Db2StudentRegistry;
                candidate.RejectedCandidate += MySqlStudentRegistry;
                candidate.CandidateId = 9929;
                candidate.ContactName = "Alisha C.";
                candidate.City = "Mumbai";
                candidate.TotalMarks = 98;
                if (candidate.TotalMarks<95)
                {
                    candidate.SelectedCandidate -= Db2StudentRegistry;
                }
                bool bajajConfirmation = false;
                string result = candidate.CalculateResult(candidate.TotalMarks, ref bajajConfirmation);
                Console.WriteLine($"Bajaj Confirmation value is {bajajConfirmation}");
                Console.WriteLine(result);
                Console.WriteLine("");
                candidate.PrintCities("A", "B");
                Console.WriteLine("");
                candidate.PrintCities("A", "B", "C");
                Console.WriteLine("");
                candidate.PrintCities("A", "B", "C", "D", "E");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

}