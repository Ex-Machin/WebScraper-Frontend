namespace NET9.BlazorWebAssemblyStandaloneApp
{
    public class Employee1
    {
        public int Id {get; set;}
        public string Name {get; set;} = null!;
        public string Designation {get; set;} = null!;
        public DateOnly DOJ {get; set;}
        public bool IsActive {get; set;}
    }
}