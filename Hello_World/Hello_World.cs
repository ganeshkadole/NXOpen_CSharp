using NXOpen;
public class Program
{
    private static Session theSession;
    private static ListingWindow theLW;

        public static void Main(string[] args)

        {

        theSession = Session.GetSession();
        theLW = theSession.ListingWindow;
        theLW.WriteLine("Hello World!");

        }

    public static int GetUnloadOption(string arg)
    {
        return System.Convert.ToInt32(Session.LibraryUnloadOption.Immediately);

    }

}