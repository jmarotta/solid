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
        string prependCommand;
        string stepNumberForm = String.Concat(@"<LINE-", (StepNum + 1).ToString());
        stepNumberForm = String.Concat(stepNumberForm, @">");
        prependCommand = String.Concat(stepNumberForm, Command);
        // Give this a meaningful type and a way to detect.
        finalCommand = this.AppendLast(prependCommand, "currtype");
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
    public Dictionary<string, List<string>> ReadConfiguration(string FilePath)
    {
        Dictionary<string, List<string>> commandDict = new Dictionary<string, List<string>>();
        
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.Load(FilePath);
        // Creates a dictionary.  Key: user-readable command; Value: firmware command to SOLiD system.
        foreach (XmlNode xmlNode in xmlDoc.DocumentElement.ChildNodes)
        {
            List<string> infos = new List<string>();
            infos.Add(xmlNode.Attributes["solidcommand"].Value.ToString());
            infos.Add(xmlNode.Attributes["type"].Value.ToString());
            commandDict.Add(xmlNode.Attributes["usercommand"].Value.ToString(), infos);
        }            
        return commandDict;
    }

    // Translates from input to firmware output.
    public string ToFirmwareCommand(Dictionary<string, List<string>> dict, string inCmd)
    {
        string fwCmd;
        string preAmb = "";
        string type = "none";
        List<string> outStr;
        if (dict.TryGetValue(inCmd, out outStr)) type = outStr[1];
        switch (type)
        { 
            case "temp":
                preAmb = @"(FC1)(<";
                break;
            case "pump":
                preAmb = @"(PUMP)(<";
                break;
            case "wait":
                preAmb = @"(TIMER)(<";
                break;
            case "none":
                preAmb = @"()(<";
                break;
        }
        string prefwCmd = String.Concat(preAmb, outStr[0]);
        fwCmd = String.Concat(prefwCmd, @">)");
        return fwCmd;
    }

    // Appends the (x)'s to the end.  Replace "type" with something more meaningful.
    public string AppendLast(string inLine, string typeList)
    {
        string completeStr;
        string endStr = "";
        switch (typeList)
        {
            case "type1":
                endStr = @"(X)()()()";
                break;
            case "type2":
                endStr = @"()(X)()()";
                break;
            case "type3":
                endStr = @"()()(X)()";
                break;
            case "type4":
                endStr = @"()()()(X)";
                break;
            case "type5":
                endStr = @"(X)(X)()()";
                break;
            case "type6":
                endStr = @"(X)(X)(X)()";
                break;
            case "type7":
                endStr = @"(X)(X)(X)(X)";
                break;
            case "type8":
                endStr = @"()(X)(X)()";
                break;
            case "type9":
                endStr = @"()()(X)(X)";
                break;
            case "type10":
                endStr = @"()(X)(X)(X)";
                break;
            case "type11":
                endStr = @"(X)()(X)()";
                break;
            case "type12":
                endStr = @"(X)()()(X)";
                break;
            case "type13":
                endStr = @"()(X)()(X)";
                break;
            case "type14":
                endStr = @"(X)()(X)(X)";
                break;
            case "type15":
                endStr = @"(X)(X)()(X)";
                break;
        }
        completeStr = String.Concat(inLine, endStr);
        return completeStr;
    }

    // Generates header to file.
    public string[] MakeHeader()
    {
        string[] header = new string[4];
        header[0] = @"<PROFILE>(.\Cavro.pro)";
        header[1] = @"<POPUP>()";
        header[2] = @"<CHECKEXTENSION>(false)";
        header[3] = @"<END CONDITION>(ONE CYCLE)";
        return header;
    }
}
