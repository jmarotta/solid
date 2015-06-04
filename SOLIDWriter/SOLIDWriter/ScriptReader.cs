using System;
using System.IO;
using System.Collections.Generic;
using System.Xml;
using System.Text.RegularExpressions;

public class ScriptReader
{
    // Constructor
	public ScriptReader()
	{
        // May need to implement ScriptWriter here to allow for dictionary lookup.
        // Or not...
	}

    // Reads files.  This is the list-returning method.
    public List<string> ReadScriptsList(string fPath) 
    {
        List<string> fContents = new List<string>();
        using (StreamReader sr = new StreamReader(fPath))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                // Maybe do some other stuff.
                fContents.Add(line);
            }
        }
        return fContents;
    }

    // Reads files.  Returns array of strings.  This is how overloading works, right?
    public string[] ReadScripts(string fPath)
    {
        string[] lines = File.ReadAllLines(fPath);
        return lines;
    }

    // Reads from XML configuration file and produces dictionary.
    public Dictionary<string, string> ReadConfiguration(string FilePath)
    {
        Dictionary<string, string> commandDict = new Dictionary<string, string>();
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.Load(FilePath);
        // Creates a dictionary.  Key: firmware command to SOLiD system; Value: user-readable command.
        foreach (XmlNode xmlNode in xmlDoc.DocumentElement.ChildNodes)
            commandDict.Add(xmlNode.Attributes["solidcommand"].Value.ToString(),xmlNode.Attributes["usercommand"].Value.ToString());
        return commandDict;
    }

    // Translates from firmware input to human readable output.
    public string FromFirmwareCommand(Dictionary<string, string> dict, string fwLit)
    {
        string fwCmd;
        fwCmd = dict[fwLit];
        return fwCmd;
    }

    // Formats strings from files read, to make them more human readable.
    public string[] Formatter(string[] fileLines)
    {
        int i = 0;
        string[] corrLines = new string[fileLines.Length];
        string startPattern = @"\<.*\>\(\.*\)\(";
        string endPattern = @"\)(\(.?\)){4}";
        Regex startreg = new Regex(startPattern);
        Regex endreg = new Regex(endPattern);
        foreach (string line in fileLines)
        {
            corrLines[i] = startreg.Replace(line, "");
            corrLines[i] = endreg.Replace(corrLines[i], "");
            i++;
        }
        return corrLines;
    }

    /* Placeholder.  May want to implement this later.
     *public string[] RemoveHeader(string[] fileLines)
     *{
     *  foreach(string line in fileLines)
     *      if (line.StartsWith(@"<PROFILE>") || line.StartsWith(@"<POPUP>") || line.StartsWith(@"<CHECKEXTENSIONS>") || line.StartsWith(@"<END CONDITION>")
     *      {
     *          line.Replace(line, "");
     *      }
     *      else
     *      {
     *          continue;
     *      }
     *      
     *  return fileLines;
     *}
     */
}
