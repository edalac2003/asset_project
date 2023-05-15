namespace asset_project.Shared.Entities
{
    public class ActivoFijo
    {
        public long Id { get; set; }

        public string Codigo { get; set; } = null!;

        public double ValorCompra { get; set; }

        public int estado { get; set; }

        public Categoria? Categoria { get; set; }

        public int IdCategoria { get; set; }

        public DateTime FechaCompra { get; set; }

        public int VidaUtil { get; set; }

        public string Responsable { get; set; } = null!;

        public string Ubicacion { get; set; } = null!;

        public TipoActivoFijo? TipoActivoFijo { get; set; }

        public long IdTipoActivoFijo { get; set; }
    }
}
