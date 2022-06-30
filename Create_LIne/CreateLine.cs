using NXOpen;
using NXOpen.UF;

public class CreateLine
{

    public static void Main(string[] args)
    {

        Session theSession = Session.GetSession();
        UFSession theUFSession = UFSession.GetUFSession();
        Part workPart = theSession.Parts.Work;

        Point3d p1 = new Point3d(0, 0, 0);
        Point3d p2 = new Point3d(10, 10, 0);

        Line theLine = theSession.Parts.Work.Curves.CreateLine(p1, p2);

        theLine.Layer = 16;

        theSession.Parts.Work.Layers.SetState(16, NXOpen.Layer.State.Selectable);
        theSession.Parts.Work.Views.WorkView.Fit();

    }

    public static int GetUnloadOption(string arg)
    {
        return System.Convert.ToInt32(Session.LibraryUnloadOption.Immediately);

    }
}



