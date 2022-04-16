namespace InterfaceExercise
{
    interface IVehicle
    {
        string Make { get; set; }
        string Model { get; set; }
        string Year { get; set; }
        int NumberOfWheels { get; set; }

        void Drive();
    }
}