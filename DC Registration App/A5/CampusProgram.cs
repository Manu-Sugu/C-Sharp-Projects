using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5
{
    internal class CampusProgram
    {
        public string ProgramName { get; set; }
        public int ProgramFees { get; set; }
        public int ProgramDuration { get; set; }

        public CampusProgram(string programName, int programFee, int programDuration) 
        { 
            this.ProgramName = programName;
            this.ProgramFees = programFee;
            this.ProgramDuration = programDuration;
        }
    }
}
