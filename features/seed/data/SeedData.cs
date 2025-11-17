namespace SOA.features.seed.data
{
    public class SeedData
    {
        public static object[] Properties => new[]
        {
            new
            {
                Name = "Departamento en Miraflores",
                PropertyType = 0, // Residential
                PropertyCategory = 0, // Apartment
                Currency = 0,
                Price = 450000.0,
                Address = "Av. Larco 123, Miraflores",
                Description = "Hermoso departamento con vista al mar y acabados modernos.",
                Phone = "987654321",
                YearBuilt = 2018,
                Latitude = -12.121,
                Longitude = -77.03,
                ExtraInfo = "Incluye estacionamiento y seguridad 24/7.",
                // Residential Properties
                Bedrooms = 3,
                Bathrooms = 2,
                Area = 120.5,
                Furnished = true,
                HasTerrace = true,
                // Commercial Properties
                Floor = 5,
                HasParking = true,
                ParkingSpaces = 1
            },
            new
            {
                Name = "Casa Familiar en Surco",
                PropertyType = 0, // Residential
                PropertyCategory = 1, // House
                Currency = 0,
                Price = 850000.0,
                Address = "Calle Los Álamos 456, Surco",
                Description = "Casa amplia con jardín y área de parrilla.",
                Phone = "912345678",
                YearBuilt = 2015,
                Latitude = -12.14,
                Longitude = -76.99,
                ExtraInfo = "Perfecta para familia grande, zona segura.",
                Bedrooms = 5,
                Bathrooms = 4,
                Area = 280.0,
                Furnished = false,
                HasTerrace = true,
                Floor = 2,
                HasParking = true,
                ParkingSpaces = 3
            },
            new
            {
                Name = "Oficina Corporativa San Isidro",
                PropertyType = 1, // Commercial
                PropertyCategory = 0, // Apartment
                Currency = 1,
                Price = 3500.0,
                Address = "Av. Camino Real 789, San Isidro",
                Description = "Oficina amoblada en edificio empresarial premium.",
                Phone = "965432178",
                YearBuilt = 2020,
                Latitude = -12.095,
                Longitude = -77.035,
                ExtraInfo = "Recepción compartida y sala de reuniones incluida.",
                Bedrooms = 0,
                Bathrooms = 2,
                Area = 85.0,
                Furnished = true,
                HasTerrace = false,
                Floor = 12,
                HasParking = true,
                ParkingSpaces = 2
            },
            new
            {
                Name = "Departamento Moderno en Barranco",
                PropertyType = 0, // Residential
                PropertyCategory = 0, // Apartment
                Currency = 1,
                Price = 1800.0,
                Address = "Av. Grau 234, Barranco",
                Description = "Departamento estilo loft cerca al malecón.",
                Phone = "923456789",
                YearBuilt = 2019,
                Latitude = -12.145,
                Longitude = -77.02,
                ExtraInfo = "Zona bohemia, cerca a restaurantes y galerías.",
                Bedrooms = 2,
                Bathrooms = 2,
                Area = 95.0,
                Furnished = true,
                HasTerrace = true,
                Floor = 4,
                HasParking = true,
                ParkingSpaces = 1
            },
            new
            {
                Name = "Casa de Playa en Asia",
                PropertyType = 0, // Residential
                PropertyCategory = 1, // House
                Currency = 0,
                Price = 620000.0,
                Address = "Condominio Las Palmeras, Asia",
                Description = "Casa frente al mar con piscina privada.",
                Phone = "998765432",
                YearBuilt = 2017,
                Latitude = -12.77,
                Longitude = -76.63,
                ExtraInfo = "Acceso directo a playa privada.",
                Bedrooms = 4,
                Bathrooms = 3,
                Area = 220.0,
                Furnished = true,
                HasTerrace = true,
                Floor = 2,
                HasParking = true,
                ParkingSpaces = 4
            },
            new
            {
                Name = "Oficina en Centro de Lima",
                PropertyType = 1, // Commercial
                PropertyCategory = 1, // House
                Currency = 0,
                Price = 380000.0,
                Address = "Jr. de la Unión 567, Lima",
                Description = "Local comercial en zona de alto tráfico peatonal.",
                Phone = "945678912",
                YearBuilt = 2010,
                Latitude = -12.046,
                Longitude = -77.03,
                ExtraInfo = "Ideal para retail, restaurant o oficinas.",
                Bedrooms = 0,
                Bathrooms = 2,
                Area = 150.0,
                Furnished = false,
                HasTerrace = false,
                Floor = 1,
                HasParking = false,
                ParkingSpaces = 1
            },
            new
            {
                Name = "Penthouse en San Miguel",
                PropertyType = 0, // Residential
                PropertyCategory = 0, // Apartment
                Currency = 0,
                Price = 720000.0,
                Address = "Av. La Marina 890, San Miguel",
                Description = "Penthouse de lujo con terraza panorámica.",
                Phone = "987123654",
                YearBuilt = 2021,
                Latitude = -12.077,
                Longitude = -77.09,
                ExtraInfo = "3 estacionamientos y depósito.",
                Bedrooms = 4,
                Bathrooms = 3,
                Area = 200.0,
                Furnished = false,
                HasTerrace = true,
                Floor = 15,
                HasParking = true,
                ParkingSpaces = 3
            },
            new
            {
                Name = "Departamento en Jesús María",
                PropertyType = 1, // Commercial
                PropertyCategory = 0, // Apartment
                Currency = 1,
                Price = 1200.0,
                Address = "Av. Brasil 456, Jesús María",
                Description = "Departamento céntrico cerca al Campo de Marte.",
                Phone = "956789123",
                YearBuilt = 2016,
                Latitude = -12.073,
                Longitude = -77.05,
                ExtraInfo = "Amoblado, incluye servicios.",
                Bedrooms = 0,
                Bathrooms = 1,
                Area = 65.0,
                Furnished = true,
                HasTerrace = false,
                Floor = 8,
                HasParking = true,
                ParkingSpaces = 1
            },
            new
            {
                Name = "Casa en La Molina",
                PropertyType = 0, // Residential
                PropertyCategory = 1, // House
                Currency = 0,
                Price = 950000.0,
                Address = "Calle Las Retamas 123, La Molina",
                Description = "Casa moderna con acabados de primera.",
                Phone = "932165487",
                YearBuilt = 2019,
                Latitude = -12.09,
                Longitude = -76.95,
                ExtraInfo = "Área verde privada y cochera triple.",
                Bedrooms = 5,
                Bathrooms = 4,
                Area = 320.0,
                Furnished = false,
                HasTerrace = true,
                Floor = 3,
                HasParking = true,
                ParkingSpaces = 3
            },
            new
            {
                Name = "Estudio en Pueblo Libre",
                PropertyType = 1, // Commercial
                PropertyCategory = 0, // Apartment
                Currency = 1,
                Price = 900.0,
                Address = "Av. Bolívar 789, Pueblo Libre",
                Description = "Estudio acogedor ideal para estudiantes.",
                Phone = "978654321",
                YearBuilt = 2014,
                Latitude = -12.075,
                Longitude = -77.065,
                ExtraInfo = "Cerca a universidades y supermercados.",
                Bedrooms = 1,
                Bathrooms = 1,
                Area = 35.0,
                Furnished = true,
                HasTerrace = false,
                Floor = 3,
                HasParking = false,
                ParkingSpaces = 1
            },
            new
            {
                Name = "Departamento en Lince",
                PropertyType = 0, // Residential
                PropertyCategory = 0, // Apartment
                Currency = 0,
                Price = 320000.0,
                Address = "Av. Arenales 234, Lince",
                Description = "Departamento funcional en zona céntrica.",
                Phone = "965123789",
                YearBuilt = 2012,
                Latitude = -12.083,
                Longitude = -77.036,
                ExtraInfo = "Cerca al centro comercial Risso.",
                Bedrooms = 3,
                Bathrooms = 2,
                Area = 90.0,
                Furnished = false,
                HasTerrace = false,
                Floor = 6,
                HasParking = true,
                ParkingSpaces = 1
            },
            new
            {
                Name = "Casa en Chacarilla del Estanque",
                PropertyType = 1, // Commercial
                PropertyCategory = 1, // House
                Currency = 1,
                Price = 4500.0,
                Address = "Calle Los Sauces 567, Surco",
                Description = "Casa amplia con jardín y piscina.",
                Phone = "943218765",
                YearBuilt = 2016,
                Latitude = -12.135,
                Longitude = -76.985,
                ExtraInfo = "Urbanización exclusiva con vigilancia.",
                Bedrooms = 4,
                Bathrooms = 3,
                Area = 300.0,
                Furnished = true,
                HasTerrace = true,
                Floor = 2,
                HasParking = true,
                ParkingSpaces = 4
            },
            new
            {
                Name = "Oficina en Miraflores",
                PropertyType = 0, // Residential
                PropertyCategory = 1, // House
                Currency = 0,
                Price = 280000.0,
                Address = "Calle Schell 890, Miraflores",
                Description = "Oficina lista para implementar.",
                Phone = "921456987",
                YearBuilt = 2013,
                Latitude = -12.125,
                Longitude = -77.028,
                ExtraInfo = "Zona empresarial consolidada.",
                Bedrooms = 0,
                Bathrooms = 2,
                Area = 75.0,
                Furnished = false,
                HasTerrace = false,
                Floor = 3,
                HasParking = true,
                ParkingSpaces = 2
            },
            new
            {
                Name = "Departamento en Magdalena",
                PropertyType = 1, // Commercial
                PropertyCategory = 0, // Apartment
                Currency = 1,
                Price = 1100.0,
                Address = "Av. Brasil 1234, Magdalena",
                Description = "Departamento luminoso con balcón.",
                Phone = "987321654",
                YearBuilt = 2015,
                Latitude = -12.088,
                Longitude = -77.074,
                ExtraInfo = "Edificio con áreas comunes renovadas.",
                Bedrooms = 2,
                Bathrooms = 1,
                Area = 70.0,
                Furnished = true,
                HasTerrace = true,
                Floor = 7,
                HasParking = true,
                ParkingSpaces = 1
            },
            new
            {
                Name = "Casa en Ate",
                PropertyType = 0, // Residential
                PropertyCategory = 1, // House
                Currency = 0,
                Price = 420000.0,
                Address = "Urbanización Santa Clara, Ate",
                Description = "Casa de dos pisos con cochera doble.",
                Phone = "956741823",
                YearBuilt = 2018,
                Latitude = -12.031,
                Longitude = -76.95,
                ExtraInfo = "Zona residencial en crecimiento.",
                Bedrooms = 4,
                Bathrooms = 3,
                Area = 180.0,
                Furnished = false,
                HasTerrace = true,
                Floor = 2,
                HasParking = true,
                ParkingSpaces = 2
            },
            new
            {
                Name = "Oficina en Los Olivos",
                PropertyType = 1, // Commercial
                PropertyCategory = 1, // House
                Currency = 1,
                Price = 2200.0,
                Address = "Av. Alfredo Mendiola 2345, Los Olivos",
                Description = "Local amplio en avenida principal.",
                Phone = "932654178",
                YearBuilt = 2011,
                Latitude = -11.975,
                Longitude = -77.07,
                ExtraInfo = "Alto flujo vehicular y peatonal.",
                Bedrooms = 0,
                Bathrooms = 2,
                Area = 200.0,
                Furnished = false,
                HasTerrace = false,
                Floor = 1,
                HasParking = true,
                ParkingSpaces = 5
            },
            new
            {
                Name = "Departamento en Breña",
                PropertyType = 0, // Residential
                PropertyCategory = 0, // Apartment
                Currency = 0,
                Price = 250000.0,
                Address = "Av. Arica 678, Breña",
                Description = "Departamento económico bien ubicado.",
                Phone = "978123456",
                YearBuilt = 2010,
                Latitude = -12.059,
                Longitude = -77.051,
                ExtraInfo = "Cerca de hospitales y centros comerciales.",
                Bedrooms = 2,
                Bathrooms = 1,
                Area = 65.0,
                Furnished = false,
                HasTerrace = false,
                Floor = 4,
                HasParking = false,
                ParkingSpaces = 1
            },
            new
            {
                Name = "Casa en Chorrillos",
                PropertyType = 1, // Commercial
                PropertyCategory = 1, // House
                Currency = 1,
                Price = 2800.0,
                Address = "Av. Huaylas 345, Chorrillos",
                Description = "Casa residencial cerca al mar.",
                Phone = "965478912",
                YearBuilt = 2017,
                Latitude = -12.168,
                Longitude = -77.013,
                ExtraInfo = "Acceso rápido a playas del sur.",
                Bedrooms = 3,
                Bathrooms = 2,
                Area = 160.0,
                Furnished = true,
                HasTerrace = true,
                Floor = 2,
                HasParking = true,
                ParkingSpaces = 2
            },
            new
            {
                Name = "Oficina en La Victoria",
                PropertyType = 0, // Residential
                PropertyCategory = 1, // House
                Currency = 0,
                Price = 180000.0,
                Address = "Jr. Parinacochas 123, La Victoria",
                Description = "Oficina pequeña ideal para emprendimientos.",
                Phone = "943789654",
                YearBuilt = 2009,
                Latitude = -12.065,
                Longitude = -77.017,
                ExtraInfo = "Zona comercial consolidada.",
                Bedrooms = 0,
                Bathrooms = 1,
                Area = 45.0,
                Furnished = false,
                HasTerrace = false,
                Floor = 2,
                HasParking = false,
                ParkingSpaces = 1
            },
            new
            {
                Name = "Departamento en San Borja",
                PropertyType = 1, // Commercial
                PropertyCategory = 0, // Apartment
                Currency = 1,
                Price = 2100.0,
                Address = "Av. San Borja Norte 567, San Borja",
                Description = "Departamento moderno con vista al parque.",
                Phone = "921753864",
                YearBuilt = 2020,
                Latitude = -12.095,
                Longitude = -76.998,
                ExtraInfo = "Edificio con gimnasio y salón de eventos.",
                Bedrooms = 3,
                Bathrooms = 2,
                Area = 110.0,
                Furnished = true,
                HasTerrace = true,
                Floor = 9,
                HasParking = true,
                ParkingSpaces = 2
            },
            new
            {
                Name = "Casa en San Juan de Lurigancho",
                PropertyType = 0, // Residential
                PropertyCategory = 1, // House
                Currency = 0,
                Price = 350000.0,
                Address = "Urb. Zárate, San Juan de Lurigancho",
                Description = "Casa unifamiliar en urbanización tranquila.",
                Phone = "987456123",
                YearBuilt = 2016,
                Latitude = -12.003,
                Longitude = -76.998,
                ExtraInfo = "Cerca a colegios y parques.",
                Bedrooms = 3,
                Bathrooms = 2,
                Area = 140.0,
                Furnished = false,
                HasTerrace = true,
                Floor = 2,
                HasParking = true,
                ParkingSpaces = 2
            },
            new
            {
                Name = "Oficina en Independencia",
                PropertyType = 1, // Commercial
                PropertyCategory = 1, // House
                Currency = 1,
                Price = 1800.0,
                Address = "Av. Túpac Amaru 890, Independencia",
                Description = "Local comercial en esquina estratégica.",
                Phone = "956123987",
                YearBuilt = 2012,
                Latitude = -11.995,
                Longitude = -77.055,
                ExtraInfo = "Ideal para minimarket o farmacia.",
                Bedrooms = 0,
                Bathrooms = 2,
                Area = 120.0,
                Furnished = false,
                HasTerrace = false,
                Floor = 1,
                HasParking = true,
                ParkingSpaces = 3
            },
            new
            {
                Name = "Departamento en Rímac",
                PropertyType = 0, // Residential
                PropertyCategory = 0, // Apartment
                Currency = 0,
                Price = 220000.0,
                Address = "Jr. Trujillo 456, Rímac",
                Description = "Departamento en edificio histórico renovado.",
                Phone = "932147856",
                YearBuilt = 2011,
                Latitude = -12.025,
                Longitude = -77.045,
                ExtraInfo = "Vista al río Rímac.",
                Bedrooms = 2,
                Bathrooms = 1,
                Area = 75.0,
                Furnished = false,
                HasTerrace = false,
                Floor = 3,
                HasParking = false,
                ParkingSpaces = 1
            },
            new
            {
                Name = "Casa en Cieneguilla",
                PropertyType = 1, // Commercial
                PropertyCategory = 1, // House
                Currency = 1,
                Price = 3200.0,
                Address = "Club Campestre Las Casuarinas, Cieneguilla",
                Description = "Casa de campo con amplio terreno.",
                Phone = "978654123",
                YearBuilt = 2015,
                Latitude = -12.09,
                Longitude = -76.83,
                ExtraInfo = "Área de BBQ y jardín frutal.",
                Bedrooms = 4,
                Bathrooms = 3,
                Area = 250.0,
                Furnished = true,
                HasTerrace = true,
                Floor = 2,
                HasParking = true,
                ParkingSpaces = 5
            },
            new
            {
                Name = "Oficina en Surquillo",
                PropertyType = 0, // Residential
                PropertyCategory = 1, // House
                Currency = 0,
                Price = 195000.0,
                Address = "Av. Angamos Este 234, Surquillo",
                Description = "Oficina con buena iluminación natural.",
                Phone = "965789321",
                YearBuilt = 2014,
                Latitude = -12.115,
                Longitude = -77.015,
                ExtraInfo = "Estacionamiento para visitas.",
                Bedrooms = 0,
                Bathrooms = 2,
                Area = 60.0,
                Furnished = false,
                HasTerrace = false,
                Floor = 5,
                HasParking = true,
                ParkingSpaces = 1
            },
            new
            {
                Name = "Departamento en San Luis",
                PropertyType = 1, // Commercial
                PropertyCategory = 0, // Apartment
                Currency = 1,
                Price = 1000.0,
                Address = "Av. Canadá 678, San Luis",
                Description = "Departamento funcional y seguro.",
                Phone = "943216587",
                YearBuilt = 2013,
                Latitude = -12.072,
                Longitude = -76.995,
                ExtraInfo = "Cerca a estaciones del Metro de Lima.",
                Bedrooms = 2,
                Bathrooms = 1,
                Area = 55.0,
                Furnished = true,
                HasTerrace = false,
                Floor = 4,
                HasParking = false,
                ParkingSpaces = 1
            },
            new
            {
                Name = "Casa en Villa El Salvador",
                PropertyType = 0, // Residential
                PropertyCategory = 1, // House
                Currency = 0,
                Price = 280000.0,
                Address = "Sector 2, Villa El Salvador",
                Description = "Casa moderna en zona residencial.",
                Phone = "921487963",
                YearBuilt = 2017,
                Latitude = -12.21,
                Longitude = -76.94,
                ExtraInfo = "Parque y colegios cercanos.",
                Bedrooms = 3,
                Bathrooms = 2,
                Area = 130.0,
                Furnished = false,
                HasTerrace = true,
                Floor = 2,
                HasParking = true,
                ParkingSpaces = 2
            },
            new
            {
                Name = "Oficina en Villa María del Triunfo",
                PropertyType = 1, // Commercial
                PropertyCategory = 1, // House
                Currency = 1,
                Price = 1500.0,
                Address = "Av. Pachacutec 1234, Villa María del Triunfo",
                Description = "Local comercial en vía principal.",
                Phone = "987369258",
                YearBuilt = 2010,
                Latitude = -12.158,
                Longitude = -76.94,
                ExtraInfo = "Zona de alto comercio.",
                Bedrooms = 0,
                Bathrooms = 2,
                Area = 95.0,
                Furnished = false,
                HasTerrace = false,
                Floor = 1,
                HasParking = true,
                ParkingSpaces = 4
            },
            new
            {
                Name = "Departamento en El Agustino",
                PropertyType = 0, // Residential
                PropertyCategory = 0, // Apartment
                Currency = 0,
                Price = 190000.0,
                Address = "Av. Riva Agüero 567, El Agustino",
                Description = "Departamento accesible y práctico.",
                Phone = "956147823",
                YearBuilt = 2012,
                Latitude = -12.043,
                Longitude = -77.01,
                ExtraInfo = "Transporte público accesible.",
                Bedrooms = 2,
                Bathrooms = 1,
                Area = 60.0,
                Furnished = false,
                HasTerrace = false,
                Floor = 5,
                HasParking = false,
                ParkingSpaces = 1
            },
            new
            {
                Name = "Casa en Pachacámac",
                PropertyType = 1, // Commercial
                PropertyCategory = 1, // House
                Currency = 1,
                Price = 2500.0,
                Address = "Condominio Valle Hermoso, Pachacámac",
                Description = "Casa campestre con áreas verdes.",
                Phone = "932654789",
                YearBuilt = 2018,
                Latitude = -12.23,
                Longitude = -76.87,
                ExtraInfo = "Ambiente tranquilo y familiar.",
                Bedrooms = 4,
                Bathrooms = 3,
                Area = 240.0,
                Furnished = true,
                HasTerrace = true,
                Floor = 2,
                HasParking = true,
                ParkingSpaces = 4
            },
            new
            {
                Name = "Oficina en Callao",
                PropertyType = 0, // Residential
                PropertyCategory = 1, // House
                Currency = 0,
                Price = 210000.0,
                Address = "Av. Sáenz Peña 890, Callao",
                Description = "Oficina comercial cerca al puerto.",
                Phone = "978321456",
                YearBuilt = 2011,
                Latitude = -12.056,
                Longitude = -77.124,
                ExtraInfo = "Acceso a importantes vías.",
                Bedrooms = 0,
                Bathrooms = 1,
                Area = 70.0,
                Furnished = false,
                HasTerrace = false,
                Floor = 3,
                HasParking = true,
                ParkingSpaces = 2
            },
            new
            {
                Name = "Departamento en La Perla",
                PropertyType = 1, // Commercial
                PropertyCategory = 0, // Apartment
                Currency = 1,
                Price = 1300.0,
                Address = "Av. La Marina 123, La Perla",
                Description = "Departamento cerca al mar.",
                Phone = "965478321",
                YearBuilt = 2016,
                Latitude = -12.072,
                Longitude = -77.11,
                ExtraInfo = "Vista parcial al océano.",
                Bedrooms = 2,
                Bathrooms = 2,
                Area = 80.0,
                Furnished = true,
                HasTerrace = true,
                Floor = 6,
                HasParking = true,
                ParkingSpaces = 1
            },
            new
            {
                Name = "Casa en Bellavista",
                PropertyType = 0, // Residential
                PropertyCategory = 1, // House
                Currency = 0,
                Price = 480000.0,
                Address = "Calle Bolognesi 456, Bellavista",
                Description = "Casa tradicional restaurada.",
                Phone = "943789126",
                YearBuilt = 2014,
                Latitude = -12.061,
                Longitude = -77.115,
                ExtraInfo = "Arquitectura clásica chalaca.",
                Bedrooms = 4,
                Bathrooms = 3,
                Area = 200.0,
                Furnished = false,
                HasTerrace = true,
                Floor = 2,
                HasParking = true,
                ParkingSpaces = 3
            },
            new
            {
                Name = "Oficina en Carmen de la Legua",
                PropertyType = 1, // Commercial
                PropertyCategory = 1, // House
                Currency = 1,
                Price = 1600.0,
                Address = "Av. Elmer Faucett 789, Carmen de la Legua",
                Description = "Local industrial con patio de maniobras.",
                Phone = "921654873",
                YearBuilt = 2009,
                Latitude = -12.048,
                Longitude = -77.095,
                ExtraInfo = "Cercano al aeropuerto.",
                Bedrooms = 0,
                Bathrooms = 2,
                Area = 180.0,
                Furnished = false,
                HasTerrace = false,
                Floor = 1,
                HasParking = true,
                ParkingSpaces = 8
            },
            new
            {
                Name = "Departamento en Ventanilla",
                PropertyType = 0, // Residential
                PropertyCategory = 0, // Apartment
                Currency = 0,
                Price = 170000.0,
                Address = "Urbanización Satélite, Ventanilla",
                Description = "Departamento en zona residencial nueva.",
                Phone = "987123654",
                YearBuilt = 2019,
                Latitude = -11.867,
                Longitude = -77.12,
                ExtraInfo = "Parque infantil en el condominio.",
                Bedrooms = 3,
                Bathrooms = 2,
                Area = 85.0,
                Furnished = false,
                HasTerrace = true,
                Floor = 4,
                HasParking = true,
                ParkingSpaces = 1
            },
            new
            {
                Name = "Casa en Punta Hermosa",
                PropertyType = 1, // Commercial
                PropertyCategory = 1, // House
                Currency = 1,
                Price = 3800.0,
                Address = "Malecón Los Delfines, Punta Hermosa",
                Description = "Casa de playa frente al mar.",
                Phone = "956321478",
                YearBuilt = 2020,
                Latitude = -12.33,
                Longitude = -76.82,
                ExtraInfo = "Perfecta para temporada de verano.",
                Bedrooms = 5,
                Bathrooms = 4,
                Area = 280.0,
                Furnished = true,
                HasTerrace = true,
                Floor = 2,
                HasParking = true,
                ParkingSpaces = 4
            },
            new
            {
                Name = "Oficina en Punta Negra",
                PropertyType = 0,
                PropertyCategory = 1, // Office
                Currency = 0,
                Price = 165000.0,
                Address = "Centro Comercial Punta Negra",
                Description = "Oficina en desarrollo costero.",
                Phone = "932147856",
                YearBuilt = 2018,
                Latitude = -12.36,
                Longitude = -76.8,
                ExtraInfo = "Ambiente playero y tranquilo.",
                // Residential Properties
                Bedrooms = 0,
                Bathrooms = 1,
                Area = 55.0,
                Furnished = false,
                HasTerrace = false,
                // Commercial Properties
                Floor = 2,
                HasParking = true,
                ParkingSpaces = 1
            },
            new
            {
                Name = "Departamento en San Bartolo",
                PropertyType = 1,
                PropertyCategory = 1, // Apartment
                Currency = 1,
                Price = 1400.0,
                Address = "Malecón San Bartolo 234",
                Description = "Departamento vacacional con vista al mar.",
                Phone = "978654321",
                YearBuilt = 2017,
                Latitude = -12.38,
                Longitude = -76.78,
                ExtraInfo = "Ideal para descanso y surf.",
                // Residential Properties
                Bedrooms = 3,
                Bathrooms = 2,
                Area = 90.0,
                Furnished = true,
                HasTerrace = true,
                // Commercial Properties
                Floor = 5,
                HasParking = true,
                ParkingSpaces = 1
            },
            new
            {
                Name = "Casa en Santa María del Mar",
                PropertyType = 0,
                PropertyCategory = 0, // House
                Currency = 0,
                Price = 780000.0,
                Address = "Av. Principal, Santa María del Mar",
                Description = "Casa exclusiva en balneario privado.",
                Phone = "965147823",
                YearBuilt = 2019,
                Latitude = -12.39,
                Longitude = -76.77,
                ExtraInfo = "Seguridad privada y club de playa.",
                // Residential Properties
                Bedrooms = 5,
                Bathrooms = 4,
                Area = 320.0,
                Furnished = true,
                HasTerrace = true,
                // Commercial Properties
                Floor = 2,
                HasParking = true,
                ParkingSpaces = 3
            },
            new
            {
                Name = "Local Comercial en Pucusana",
                PropertyType = 1,
                PropertyCategory = 0, // Commercial Building
                Currency = 1,
                Price = 1900.0,
                Address = "Malecón Pucusana 567",
                Description = "Local comercial frente al puerto.",
                Phone = "943258796",
                YearBuilt = 2015,
                Latitude = -12.48,
                Longitude = -76.8,
                ExtraInfo = "Zona turística pesquera.",
                // Residential Properties
                Bedrooms = 0,
                Bathrooms = 2,
                Area = 120.0,
                Furnished = false,
                HasTerrace = false,
                // Commercial Properties
                Floor = 1,
                HasParking = false,
                ParkingSpaces = 1
            },
            new
            {
                Name = "Departamento en Lurín",
                PropertyType = 0,
                PropertyCategory = 1, // Apartment
                Currency = 0,
                Price = 200000.0,
                Address = "Av. Antigua Panamericana Sur, Lurín",
                Description = "Departamento en urbanización nueva.",
                Phone = "921369854",
                YearBuilt = 2020,
                Latitude = -12.27,
                Longitude = -76.87,
                ExtraInfo = "Cerca a centros comerciales.",
                // Residential Properties
                Bedrooms = 2,
                Bathrooms = 1,
                Area = 62.0,
                Furnished = false,
                HasTerrace = false,
                // Commercial Properties
                Floor = 3,
                HasParking = true,
                ParkingSpaces = 1
            },
            new
            {
                Name = "Casa en Ancón",
                PropertyType = 1,
                PropertyCategory = 0, // House
                Currency = 1,
                Price = 2600.0,
                Address = "Balneario de Ancón",
                Description = "Casa veraniega cerca a la playa.",
                Phone = "987456321",
                YearBuilt = 2016,
                Latitude = -11.76,
                Longitude = -77.17,
                ExtraInfo = "Ambiente tranquilo y playero.",
                // Residential Properties
                Bedrooms = 3,
                Bathrooms = 2,
                Area = 160.0,
                Furnished = false,
                HasTerrace = true,
                // Commercial Properties
                Floor = 2,
                HasParking = true,
                ParkingSpaces = 2
            },
            new
            {
                Name = "Oficina en Santa Anita",
                PropertyType = 0,
                PropertyCategory = 1, // Office
                Currency = 0,
                Price = 175000.0,
                Address = "Av. Los Ficus 890, Santa Anita",
                Description = "Oficina en zona industrial.",
                Phone = "956741852",
                YearBuilt = 2013,
                Latitude = -12.046,
                Longitude = -76.97,
                ExtraInfo = "Acceso a almacenes y logística.",
                // Residential Properties
                Bedrooms = 0,
                Bathrooms = 2,
                Area = 80.0,
                Furnished = false,
                HasTerrace = false,
                // Commercial Properties
                Floor = 2,
                HasParking = true,
                ParkingSpaces = 3
            },
            new
            {
                Name = "Departamento en Carabayllo",
                PropertyType = 1,
                PropertyCategory = 1, // Apartment
                Currency = 1,
                Price = 950.0,
                Address = "Urbanización Santa Isabel, Carabayllo",
                Description = "Departamento económico en zona en desarrollo.",
                Phone = "932654178",
                YearBuilt = 2018,
                Latitude = -11.86,
                Longitude = -77.03,
                ExtraInfo = "Transporte público frecuente.",
                // Residential Properties
                Bedrooms = 2,
                Bathrooms = 1,
                Area = 58.0,
                Furnished = false,
                HasTerrace = false,
                // Commercial Properties
                Floor = 4,
                HasParking = false,
                ParkingSpaces = 1
            },
            new
            {
                Name = "Casa en Comas",
                PropertyType = 0,
                PropertyCategory = 0, // House
                Currency = 0,
                Price = 390000.0,
                Address = "Urbanización La Pascana, Comas",
                Description = "Casa familiar en zona consolidada.",
                Phone = "978321654",
                YearBuilt = 2015,
                Latitude = -11.935,
                Longitude = -77.05,
                ExtraInfo = "Colegios y mercados cerca.",
                // Residential Properties
                Bedrooms = 4,
                Bathrooms = 2,
                Area = 170.0,
                Furnished = false,
                HasTerrace = false,
                // Commercial Properties
                Floor = 2,
                HasParking = true,
                ParkingSpaces = 2
            },
            new
            {
                Name = "Local Comercial en Puente Piedra",
                PropertyType = 1,
                PropertyCategory = 0, // Commercial Building
                Currency = 1,
                Price = 1700.0,
                Address = "Av. Panamericana Norte 1234, Puente Piedra",
                Description = "Local comercial en avenida principal.",
                Phone = "965123789",
                YearBuilt = 2014,
                Latitude = -11.86,
                Longitude = -77.07,
                ExtraInfo = "Alto tránsito vehicular.",
                // Residential Properties
                Bedrooms = 0,
                Bathrooms = 2,
                Area = 150.0,
                Furnished = false,
                HasTerrace = false,
                // Commercial Properties
                Floor = 1,
                HasParking = true,
                ParkingSpaces = 4
            },
            new
            {
                Name = "Departamento en San Martín de Porres",
                PropertyType = 0,
                PropertyCategory = 1, // Apartment
                Currency = 0,
                Price = 265000.0,
                Address = "Av. Perú 567, San Martín de Porres",
                Description = "Departamento céntrico y accesible.",
                Phone = "943789654",
                YearBuilt = 2016,
                Latitude = -12.01,
                Longitude = -77.08,
                ExtraInfo = "Cerca a universidades.",
                // Residential Properties
                Bedrooms = 3,
                Bathrooms = 2,
                Area = 88.0,
                Furnished = false,
                HasTerrace = false,
                // Commercial Properties
                Floor = 6,
                HasParking = true,
                ParkingSpaces = 1
            },
            new
            {
                Name = "Casa en Mala",
                PropertyType = 1,
                PropertyCategory = 0, // House
                Currency = 1,
                Price = 2200.0,
                Address = "Playa Bujama, Mala",
                Description = "Casa de playa para fines de semana.",
                Phone = "921753864",
                YearBuilt = 2019,
                Latitude = -12.658,
                Longitude = -76.63,
                ExtraInfo = "Acceso directo a playa.",
                // Residential Properties
                Bedrooms = 3,
                Bathrooms = 2,
                Area = 140.0,
                Furnished = true,
                HasTerrace = true,
                // Commercial Properties
                Floor = 2,
                HasParking = true,
                ParkingSpaces = 3
            },
            new
            {
                Name = "Oficina en San Juan de Miraflores",
                PropertyType = 0,
                PropertyCategory = 1, // Office
                Currency = 0,
                Price = 155000.0,
                Address = "Av. San Juan 234, San Juan de Miraflores",
                Description = "Oficina pequeña en distrito comercial.",
                Phone = "987654123",
                YearBuilt = 2012,
                Latitude = -12.16,
                Longitude = -76.975,
                ExtraInfo = "Zona de pequeños negocios.",
                // Residential Properties
                Bedrooms = 0,
                Bathrooms = 1,
                Area = 50.0,
                Furnished = false,
                HasTerrace = false,
                // Commercial Properties
                Floor = 1,
                HasParking = false,
                ParkingSpaces = 1
            },
            new
            {
                Name = "Departamento en Villa Rica",
                PropertyType = 1,
                PropertyCategory = 1, // Apartment
                Currency = 1,
                Price = 850.0,
                Address = "Condominio Los Jardines, Chorrillos",
                Description = "Departamento económico con servicios incluidos.",
                Phone = "956369147",
                YearBuilt = 2017,
                Latitude = -12.175,
                Longitude = -77.005,
                ExtraInfo = "Seguridad y áreas comunes.",
                // Residential Properties
                Bedrooms = 1,
                Bathrooms = 1,
                Area = 50.0,
                Furnished = true,
                HasTerrace = false,
                // Commercial Properties
                Floor = 3,
                HasParking = true,
                ParkingSpaces = 1
            }
        };
        }
}