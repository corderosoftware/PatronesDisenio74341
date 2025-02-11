namespace Singleton
{
    internal class EventLogger
    {
        //Campo estático para almacenar la única instancia de la clase
        private static EventLogger _instance;
        //Lista para almacenar los eventos registrados
        private readonly List<string> _events;

        //Constructor privado para evitar la creación de instancias desde el exterior
        private EventLogger()
        {
            _events = new List<string>();
        }

        //Método estático para obtener la instancia del logger.
        public static EventLogger GetInstance()
        {
            if (_instance == null)
            {
                _instance = new EventLogger();
            }
            return _instance;
        }

        // Método para registrar un nuevo evento
        public void AddEvent(string message)
        {
            string logEntry = $"[{DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss")}] {message}";
            _events.Add(logEntry);
            //Console.WriteLine($"Evento registrado: {logEntry}");
        }
        // Método para obtener todos los eventos registrados
        public List<string> GetEvents()
        {
            // Devolvemos una copia para evitar modificar la lista original
            return new List<string>(_events);
        }
    }
}
