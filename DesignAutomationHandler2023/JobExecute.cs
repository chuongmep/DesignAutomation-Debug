using System;
using System.Diagnostics;
using System.IO;
using Autodesk.Revit.DB;

namespace DesignAutomationHandler;

public class JobExecute
{
    public void ExportRoomNames(Document? doc)
    {
        string path = "result.txt";
        using (StreamWriter sw = new StreamWriter(path))
        {
            FilteredElementCollector collector = new FilteredElementCollector(doc);
            collector.OfClass(typeof(SpatialElement));
            foreach (var element in collector)
            {
                var e = (SpatialElement) element;
                sw.WriteLine(e.Name);
            }
        }
        Trace.WriteLine("Exported room names to " + path);
    }
}