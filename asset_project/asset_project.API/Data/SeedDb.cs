﻿using asset_project.Shared.Entities;

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
                _context.Countries.Add(new Country 
                { 
                    Name = "Colombia ",
                    States = new List<State>() 
                    {
                        new State()
                        {
                            Name = "Antioquia",
                            Cities = new List<City>()
                            {
                                new City { Name = "Medellín" },
                                new City { Name = "Bello" },
                                new City { Name = "Envigado" },
                                new City { Name = "Itagüí" },
                                new City { Name = "Sabaneta" },
                                new City { Name = "La Estrella" },
                                new City { Name = "Caldas" },
                                new City { Name = "Copacabana" },
                                new City { Name = "Girardota" },

                            }
                        },
                        new State()
                        {
                            Name = "Sucre",
                            Cities = new List<City>()
                            {
                                new City { Name = "Sincelejo" },
                                new City { Name = "Corozal" },
                                new City { Name = "Sincé" },
                                new City { Name = "Betulia" },
                                new City { Name = "Tolú" },
                                new City { Name = "Coveñas" },
                                new City { Name = "Sampues" },
                                new City { Name = "Majagual" }

                            }
                        },
                        new State()
                        {
                            Name = "Cordoba",
                            Cities = new List<City>()
                            {
                                new City { Name = "Montería" },
                                new City { Name = "Chinú" },
                                new City { Name = "San Bernardo del Viento" },
                                new City { Name = "Ciénaga de Oro" },
                                new City { Name = "Tolú" },
                                new City { Name = "Cereté" },
                                new City { Name = "Sahagún" },
                                new City { Name = "San Antero" }

                            }
                        }
                    }
                });

                await _context.SaveChangesAsync();
            }
        }
    }
}
