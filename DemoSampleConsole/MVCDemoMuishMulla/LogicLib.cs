namespace MVCDemoMuishMulla
{
    public class LogicLib
    {
        public int x { get; set; }
        public int y { get; set; }
        public string GetPageTile()
        {
            return "ABC Company";
        }
        public string GetMonth(DateTime dt)
        {
            return  dt.Month.ToString();
        }

        public int Add() 
        { 

            return x + y; 
        }
    }
}
