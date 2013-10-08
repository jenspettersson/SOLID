namespace Solid.InterfaceSegregationPrinciple
{
    public class BirthdayCalendar
    {
        public void Add(IPerson person)
        {
            // Does a birthday calendar really care about the persons height or weight?
            // And does it really need to be able to tell a person to walk/eat/sleep/work?
        }
    }
}