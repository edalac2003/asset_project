using asset_project.API.Helpers.Interfaces;
using asset_project.Shared.Entities;
using asset_project.Shared.Enums;

namespace asset_project.API.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;
        private readonly IUserHelper _userHelper;

        public SeedDb(DataContext context, IUserHelper userHelper)
        {
            _context = context;
            _userHelper = userHelper;
        }

        public async Task SeedAsync()
        {
            await FillCategories();
            await FillCountries();
            await FillIdentificationTypes();
            await FillNotificationTypes();
            await FillStatusTypes();
            await CheckRolesAsync();
            await CheckUserAsync("456789", "Administrador", "administrador", "admin@yopmail.com", "300 123456", "Administrador", UserType.Administrador);
            await CheckUserToRoleAsync("admin@yopmail.com", UserType.Administrador);
            await CheckUserToRoleAsync("admin@yopmail.com", UserType.Solicitante);

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
                _context.StatusTypes.Add(new Shared.Entities.StatusType { Name = "Registrada", MaintenanceRequest = true });
                _context.StatusTypes.Add(new Shared.Entities.StatusType { Name = "Rechazada", MaintenanceRequest = true });
                _context.StatusTypes.Add(new Shared.Entities.StatusType { Name = "Asignada", MaintenanceRequest = true });
                _context.StatusTypes.Add(new Shared.Entities.StatusType { Name = "Finalizada", MaintenanceRequest = true });
                _context.StatusTypes.Add(new Shared.Entities.StatusType { Name = "Creada", WorkOrder = true });
                _context.StatusTypes.Add(new Shared.Entities.StatusType { Name = "Asignada a técnico", WorkOrder = true });
                _context.StatusTypes.Add(new Shared.Entities.StatusType { Name = "Asignada a proveedor", WorkOrder = true });
                _context.StatusTypes.Add(new Shared.Entities.StatusType { Name = "En ejecución", WorkOrder = true });
                _context.StatusTypes.Add(new Shared.Entities.StatusType { Name = "Pendiente Insumo", WorkOrder = true });
                _context.StatusTypes.Add(new Shared.Entities.StatusType { Name = "Terminada", WorkOrder = true });
                _context.StatusTypes.Add(new Shared.Entities.StatusType { Name = "Aprobada", WorkOrder = true });
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

        private async Task CheckRolesAsync()
        {
            await _userHelper.CheckRoleAsync(UserType.Administrador.ToString());
            await _userHelper.CheckRoleAsync(UserType.Coordinador.ToString());
            await _userHelper.CheckRoleAsync(UserType.Asistente.ToString());
            await _userHelper.CheckRoleAsync(UserType.Tecnico.ToString());
            await _userHelper.CheckRoleAsync(UserType.Gerente.ToString());
            await _userHelper.CheckRoleAsync(UserType.Solicitante.ToString());
        }

        private async Task<User> CheckUserAsync(string document, string firstName, string lastName, string email, string phone, string address, UserType userType)
        {
            var user = await _userHelper.GetUserAsync(email);
            if(user == null)
            {
                user = new User
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Email = email,
                    UserName = email,
                    PhoneNumber = phone,
                    Address = address,
                    Document = document,
                    City = _context.Cities.FirstOrDefault(),
                    UserType = userType,
                };
                await _userHelper.AddUserAsync(user, "123456");
            }

            return user;
        }

        private async Task CheckUserToRoleAsync(string email, UserType userType)
        {
            var user = await _userHelper.GetUserAsync(email);
            if (user != null)
            {
                await _userHelper.AddUserToRoleAsync(user, userType.ToString());
            }
        }

    }
}
