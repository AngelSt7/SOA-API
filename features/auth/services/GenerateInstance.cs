using SOA.features.auth.dtos;
using SOA.features.auth.dtos.response;
using SOA.features.auth.models;
using SOA.features.property.admin.dtos.request;
using SOA.features.property.admin.dtos.response;

namespace SOA.features.auth.services
{
    public static class GenerateInstance
    {
        public static User user(CreateUserDto dto)
        {
            return new User
            {
                Name = dto.Name,
                Lastname = dto.Lastname,
                Email = dto.Email,
                Password = BCrypt.Net.BCrypt.HashPassword(dto.Password),
                Phone = dto.Phone,
                BirthDate = dto.BirthDate,
                Confirmed = false
            };
        }

        public static UserResponseDto userResponseInfo(User user)
        {
            return new UserResponseDto
            {
                Name = user.Name,
                Lastname = user.Lastname,
                Email = user.Email,
                Confirmed = user.Confirmed
            };
        }

        public static Token token(String tokenValue, Guid userId)
        {
            return new Token
            {
                UserId = userId,
                TokenValue = int.Parse(tokenValue),
                ExpiresAt = DateTime.UtcNow.AddMinutes(15)
            };
        }

        public static PropertyUpdateDto PrepareProperty(PropertySingleResponseDto dto, UpdatePropertyAdminDto updateDto, string slug, Guid locationId)
        {
            return new PropertyUpdateDto
            {
                Id = dto.Id,
                Name = updateDto.Name ?? dto.Name,
                PropertyType = updateDto.PropertyType ?? dto.PropertyType,
                PropertyCategory = updateDto.PropertyCategory ?? dto.PropertyCategory,
                Currency = updateDto.Currency ?? dto.Currency,
                Price = (double)updateDto.Price,
                Address = updateDto.Address ?? dto.Address,
                Description = updateDto.Description ?? dto.Description,
                Phone = updateDto.Phone ?? dto.Phone,
                YearBuilt = updateDto.YearBuilt ?? dto.YearBuilt,
                Latitude = updateDto.Latitude ?? dto.Latitude,
                Longitude = updateDto.Longitude ?? dto.Longitude,
                ExtraInfo = updateDto.ExtraInfo ?? dto.ExtraInfo,
                LocationId = locationId,
                Bedrooms = updateDto.Bedrooms ?? dto.Bedrooms,
                Bathrooms = updateDto.Bathrooms ?? dto.Bathrooms,
                Area = updateDto.Area ?? dto.Area,
                Furnished = updateDto.Furnished ?? dto.Furnished,
                Floor = updateDto.Floor ?? dto.Floor,
                HasParking = updateDto.HasParking ?? dto.HasParking,
                ParkingSpaces = updateDto.ParkingSpaces ?? dto.ParkingSpaces,
                HasTerrace = updateDto.HasTerrace ?? dto.HasTerrace,

                Slug = slug,
                UpdatedAt = DateTime.UtcNow,

                Services = updateDto.ServicesId ?? dto.Services
            };
        }



    }
}
