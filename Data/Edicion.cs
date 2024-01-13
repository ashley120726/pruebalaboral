namespace pruebalaboral.Data
{
    public class Edicion
    {
        public int id { get; set; }
        public string todo { get; set; }
        public bool completed { get; set; }
        public int userId { get; set; }

        public bool Editando { get; set; } = false;
        public string TodoEditado { get; set; }
    }
}
