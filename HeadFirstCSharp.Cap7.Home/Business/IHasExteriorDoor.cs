namespace HeadFirstCSharp.Cap7.Home.Business
{
    public interface IHasExteriorDoor
    {
        string DoorDescription { get; }
        Location DoorLocation { get; set; }
    }
}