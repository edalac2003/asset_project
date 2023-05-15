namespace asset_project.Shared.Entities
{
    public class TipoActivoFijo
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;

        public Propiedad? propiedad { get; set; } = null!;
    }
}
