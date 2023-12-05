using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace DesignAutomationHandler
{
    [Autodesk.Revit.Attributes.Regeneration(Autodesk.Revit.Attributes.RegenerationOption.Manual)]
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    class TestCommand : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            Document doc = commandData.Application.ActiveUIDocument.Document;
            JobExecute jobExecute = new JobExecute();
            jobExecute.ExportRoomNames(doc);
            return Result.Succeeded;
        }
    }
}