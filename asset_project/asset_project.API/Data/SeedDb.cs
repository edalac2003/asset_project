using asset_project.Shared.Entities;

namespace asset_project.API.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;
        public SeedDb(DataContext context)
        {
            _context = context;

        }

        public async Task SeedAsync()
        {
            await FillCategories();
            //await FillCountries();
            await FillIdentificationTypes();
            await FillNotificationTypes();
            await FillStatusTypes();
        }


        /*
         * Se llenan las tablas maestras
         */

        private async Task FillIdentificationTypes()
        {
            if (!_context.IdentificationTypes.Any())
            {
                _context.IdentificationTypes.Add(new IdentificationType { Name = "Cédula de Ciudadanía", Abbreviation = "CC" });
                _context.IdentificationTypes.Add(new IdentificationType { Name = "Cédula de Extranjería", Abbreviation = "CE" });
                _context.IdentificationTypes.Add(new IdentificationType { Name = "Pasaporte", Abbreviation = "PAS" });
                _context.IdentificationTypes.Add(new IdentificationType { Name = "Nit", Abbreviation = "NIT" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task FillCategories()
        {
            if (!_context.Categories.Any())
            {
                _context.Categories.Add(new Category { Name = "Equipos de Computo", Description = "CPU, Laptops, Server, Monitor, Teclado, Mouse" });
                _context.Categories.Add(new Category { Name = "Equipos de Oficina", Description = "Escritorio, Silla, Gabinete, Archivador" });
                _context.Categories.Add(new Category { Name = "Equipos de Telecomunicaciones", Description = "Rack, Switch, Router, Modem, PBX, Otros" });
                _context.Categories.Add(new Category { Name = "Electrodomesticos", Description = "Nevera, Estufa, Microondas, Lavadora, Secadora, Lavavajillas, Licuadora" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task FillNotificationTypes()
        {
            if (!_context.NotificationTypes.Any())
            {
                _context.NotificationTypes.Add(new NotificationType { name = "EMAIL" });
                _context.NotificationTypes.Add(new NotificationType { name = "SMS" });
                _context.NotificationTypes.Add(new NotificationType { name = "DASHBOARD" });
                await _context.SaveChangesAsync();
            }
        }

        private async Task FillStatusTypes()
        {
            if (!_context.StatusTypes.Any())
            {
                _context.StatusTypes.Add(new StatusType { Name = "Registrada", MaintenanceRequest = true });
                _context.StatusTypes.Add(new StatusType { Name = "Rechazada", MaintenanceRequest = true });
                _context.StatusTypes.Add(new StatusType { Name = "Asignada", MaintenanceRequest = true });
                _context.StatusTypes.Add(new StatusType { Name = "Finalizada", MaintenanceRequest = true });
                _context.StatusTypes.Add(new StatusType { Name = "Creada", WorkOrder = true });
                _context.StatusTypes.Add(new StatusType { Name = "Asignada a técnico", WorkOrder = true });
                _context.StatusTypes.Add(new StatusType { Name = "Asignada a proveedor", WorkOrder = true });
                _context.StatusTypes.Add(new StatusType { Name = "En ejecución", WorkOrder = true });
                _context.StatusTypes.Add(new StatusType { Name = "Pendiente Insumo", WorkOrder = true });
                _context.StatusTypes.Add(new StatusType { Name = "Terminada", WorkOrder = true });
                _context.StatusTypes.Add(new StatusType { Name = "Aprobada", WorkOrder = true });
                await _context.SaveChangesAsync();
            }
        }

        private async Task FillCountries()
        {
            if (!_context.Countries.Any())
            {
                _context.Countries.Add(new Country { Id = 1, Name = "Colombia " });
                _context.States.Add(new State { Id = 1, Name = "Antioquia", CountryId = 1 });
                _context.Cities.Add(new City { Id = 1, Name = "Medellín", StateId = 1 });
                _context.Cities.Add(new City { Id = 2, Name = "Bello", StateId = 1 });
                _context.Cities.Add(new City { Id = 3, Name = "Envigado", StateId =1 });
                _context.Cities.Add(new City { Id = 4, Name = "Itagüí", StateId = 1 });
                _context.Cities.Add(new City { Id = 5, Name = "Sabaneta", StateId = 1 });
                _context.Cities.Add(new City { Id = 6, Name = "La Estrella", StateId =1 });
                _context.Cities.Add(new City { Id = 7, Name = "Caldas", StateId = 1 });
                _context.Cities.Add(new City { Id = 8, Name = "Copacabana", StateId = 1 });
                _context.Cities.Add(new City { Id = 9, Name = "Girardota", StateId = 1 });

                await _context.SaveChangesAsync();
            }
        }
    }
}
