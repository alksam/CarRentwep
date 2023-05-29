namespace CarRentwep.modeldatabase
{
    public class car1
    {
        public int Id { get; set; }
        public string Model { get; set; }
    
        public int Pric { get; set; }

        public car1(int id, string model,   int pric)
        {
            Id = id;
            Model = model;
            Pric = pric;
        }

        public car1() : this(-1, "BMW", "", "")
        {
        }

        public car1(int v1, string v2, string v3, string v4)
        {
        }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Model)}={Model}, {nameof(Pric)}={Pric}}}";
        }
    }
}
    

