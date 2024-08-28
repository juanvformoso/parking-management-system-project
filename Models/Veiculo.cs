namespace ParkingSystem.Models
{
    public class Veiculo
    {
        public string Placa { get; set; }

        public Veiculo(string placa)
        {
            Placa = placa.ToUpper();
        }
    }
}