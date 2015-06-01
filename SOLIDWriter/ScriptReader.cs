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
    public List<string> ReadScripts(string fPath) 
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

    // Reads from XML configuration file and produces dictionary
    public Dictionary<string, string> ReadConfiguration(string FilePath)
    {
        Dictionary<string, string> commandDict = new Dictionary<string, string>();
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.Load(FilePath);
        // Need to settle on XML structure.  Could use attributes or nodes.  FILL THIS IN.
        foreach (XmlNode xmlNode in xmlDoc.DocumentElements.ChildNodes[x])
            // Should probably iterate over ALL attributes or subnodes
            commandDict.Add(xmlNode.Attributes[""].Value,xmlNode.Attributes[""]);
        return commandDict;
    }

    // Translates from firmware input to human readable output.
    public string FromFirmwareCommand(Dictionary<string, string> dict, string fwCmd)
    {
        string fwCmd;
        fwCmd = dict[inCmd];
        return fwCmd;
    }

    // Formats strings from files read, to make them more human readable.
    public string[] Formatter(string[] fileLines)
    {
        string pattern = "<LINE-\\d>";
        Regex regx = new Regex(pattern);
        foreach (string line in fileLines)
            line= regx.Replace(pattern, "");
        return fileLines;
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
