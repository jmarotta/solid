using System;
using System.IO;
using System.Collections.Generic;
using System.Xml;

public class ScriptWriter
{
	// Appends <STEP stepnumber to the front of each line.
    public string AppendStep(int StepNum, string Command)
	{
        string finalCommand;
        string stepNumberForm = String.Concat(@"<STEP", StepNum.ToString());
        stepNumberForm = String.Concat(stepNumberForm, @">");
        finalCommand = String.Concat(stepNumberForm, Command);
        // ALSO WANT TO ADD ENDING STUFF - (x)()(x)().
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

    // Reads from XML configuration file and produces dictionary
    public Dictionary<string, string> ReadConfiguration(string FilePath)
    {
        Dictionary<string, string> commandDict = new Dictionary<string, string>();
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.Load(FilePath);
        // Need to settle on XML structure.  Could use attributes or nodes.  FILL THIS IN.
        foreach (XmlNode xmlNode in xmlDoc.DocumentElement.ChildNodes[x])
            // Should probably iterate over ALL attributes or subnodes
            commandDict.Add(xmlNode.Attributes[""], xmlNode.Attributes[""].Value);
        return commandDict;
    }

    // Translates from input to firmware output.
    public string ToFirmwareCommand(Dictionary<string, string> dict, string inCmd)
    {
        string fwCmd;
        fwCmd = dict[inCmd];
        return fwCmd;
    }
}
