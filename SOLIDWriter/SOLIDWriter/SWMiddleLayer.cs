using System;
using System.Collections.Generic;
using System.Xml;

public class SWMiddleLayer
{
    ScriptWriter writer = new ScriptWriter();
    ScriptReader reader = new ScriptReader();
    // Constructor.
	public SWMiddleLayer()
	{       
	}

    // Implements formatting and script reading to populate listview
    public List<string> ListViewFormat(string FilePath, string dictPath)
    {
        int i = 0;
        string[] allLines = reader.ReadScripts(FilePath);
        string[] formatLines = reader.Formatter(allLines);
        List<string> readableLines = new List<string>();
        Dictionary<string, string> cmdDict = new Dictionary<string, string>();
        cmdDict = reader.ReadConfiguration(dictPath);
        foreach (string line in formatLines)
        {
            string tmpLine = reader.FromFirmwareCommand(cmdDict, line);
            tmpLine.Replace(@"<", "");
            tmpLine.Replace(@">", "");
            readableLines.Add(tmpLine);
            i++;
        }
        return readableLines;
    }

    
    // Prepares list of user-readable commands for populating the second combo box.
    // This is what lets the user generate the script.
    public List<string> GetCommandByType(string dictPath, string type)
    {
        XmlDocument xDoc = new XmlDocument();
        List<string> usableCmds = new List<string>();
        xDoc.Load(dictPath);
        foreach(XmlNode xNode in xDoc.DocumentElement.ChildNodes)
        {
            if (xNode.Attributes["type"].Value.ToString() == type)
            {
                usableCmds.Add(xNode.Attributes["usercommand"].Value.ToString());
            }
        }
        return usableCmds;
    }

    // Actually writes the header and command set to file from a string list of listview items.
    public void WriteToFile(List<string> lvItems, string outpath)
    {        
        List<string> outputItems = new List<string>();
        string[] head = writer.MakeHeader();
        foreach(string headItem in head) outputItems.Add(headItem);
        foreach(string cmd in lvItems)
        {
            string steppedLine = writer.AppendStep(lvItems.IndexOf(cmd),cmd);
            string finalLine = writer.AppendLast(steppedLine, "type1");//curType);
            outputItems.Add(finalLine);
        }
        foreach (string outLine in outputItems) writer.WriteLineToFile(outpath, outLine);
    }

    // Parses type from the XML document and stores in dictionary.
    // This may not be necessary...?
    public Dictionary<string, string> GetCommandType(string fPath)
    {
        Dictionary<string, string> typeDict = new Dictionary<string, string>();
        XmlDocument xDoc = new XmlDocument();
        xDoc.Load(fPath);
        foreach (XmlNode xNode in xDoc.DocumentElement.ChildNodes)
        {
            typeDict.Add(xNode.Attributes["usercommand"].Value.ToString(), xNode.Attributes["type"].Value.ToString());    
        }
        return typeDict;
    }

    // Sets the type for the last part of each line (the (X)()(X)(), etc)

}
