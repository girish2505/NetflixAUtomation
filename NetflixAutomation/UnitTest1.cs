using NUnit.Framework;

namespace NetflixAutomation
{
    public class Tests:Base.BaseClass
    {
        [Test]
        public void ReadingData()
        {
            ExcelOperations.PopulateInCollection(@"C:\Users\girish.v\source\repos\NetflixAutomation\NetflixAutomation\ExcelData\TestData.xlsx");

            DoActions.Action.EnterCedentials(driver);
        }
    }
}