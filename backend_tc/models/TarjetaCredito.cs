namespace backend_tc.models
{
    public class TarjetaCredito
    {
        public int id { get; set; }
        public string nombre { get; set; }

        public int numTarjeta { get; set; }

        public string fecha { get; set; }

        public int cvv { get; set; }
    }
}
