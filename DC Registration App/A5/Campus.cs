using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5
{
    internal class Campus
    {
        public string CampusName {  get; set; }
        public int HSGradeReq { get; set; }
        public int AdmissionTSReq { get; set; }
        public int RegFees { get; set; }
        public List<CampusProgram> Programs { get; } = new List<CampusProgram>();

        private static readonly Random random = new Random();

        // Constructor
        public Campus(string campusName, int hsGradeReq, int admissionTSReq, int regFees)
        {
            CampusName = campusName;
            HSGradeReq = hsGradeReq;
            AdmissionTSReq = admissionTSReq;
            RegFees = regFees;

            // Generate a random number of programs for each campus
            int numberOfPrograms = random.Next(1, 6); // Randomly choose 1 to 5 programs

            for (int i = 0; i < numberOfPrograms; i++)
            {
                Programs.Add(GenerateRandomProgram());
            }
        }
        
        // To add programs to the campus object
        public void AddProgram(CampusProgram program)
        {
            Programs.Add(program);
        }

        // Method to generate a random program
        private CampusProgram GenerateRandomProgram()
        {
            string[] programNames = { "Architectural", "Science and Art", "Law", "Health", "Engineering", "Music", "Business" };

            // Randomly choose a program name
            string randomProgramName = programNames[random.Next(programNames.Length)];

            // Generate random program fees and duration
            int randomFees = random.Next(10000, 30001); // Random fees between 10000 and 30000
            int randomDuration = random.Next(1, 3); // Random duration between 1 and 3 years

            return new CampusProgram(randomProgramName, randomFees, randomDuration);
        }
    }
}
