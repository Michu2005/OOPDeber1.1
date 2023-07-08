namespace OOPDeber1
{
    public class NombreBase
    {
        public int _FechaReserva;
        public string _nombreCliente;
        public int _numeroCedulaCliente;
        public int _numeroTelefonoCliente;

        public int FechadeReserva
        {
            get => default;
            set
            {
            }
        }

        public int NumeroCedula
        {
            get => default;
            set
            {
            }
        }

        public int NumeroTelefono
        {
            get => default;
            set
            {
            }
        }

        public static string GetNombre()
        {
            return default;
        }

        public void NombredePersonaReserva()
        {
            throw new System.NotImplementedException();
        }
    }
}