using System;
using System.IO;

public class FileWriter
{
	// Appends <STEP stepnumber to the front of each line.
    public string AppendStep(int StepNum, string Command)
	{
        string finalCommand;
        string stepNumberForm = String.Concat(@"<STEP", StepNum.ToString());
        stepNumberForm = String.Concat(stepNumberForm, @">");
        finalCommand = String.Concat(stepNumberForm, Command);
        return finalCommand;
	}

    // Actually writes each line of the script to a file.  
    public void WriteLineToFile(string fileName, string line)
    {
        using (System.IO.StreamWriter file = new System.IO.StreamWriter(fileName, true))
        {
            file.WriteLine(line);
        }
    }
}
