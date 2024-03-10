namespace actividad_3_back.Models.DAO
{
    public class CommentsModel
    {
        public Guid IdComments { get; set; }
        public string Comment { get; set; } = string.Empty;
        public string? Email { get; set; }
        public Guid IdProduct { get; set; }
    }
}
