using Microsoft.EntityFrameworkCore;
using SOA.features.auth.models;

namespace SOA.features.auth.repositories
{
    public class TokenRepository(ApplicationDbContext context)
    {
        private readonly ApplicationDbContext _context = context;

        public async Task<Token?> FindByUserIdAsync(Guid userId)
        {
            return await _context.Tokens
                .FirstOrDefaultAsync(t => t.UserId == userId);
        }

        public async Task<int> DeleteByIdAsync(Guid tokenId)
        {
            return await _context.Tokens
                .Where(t => t.Id == tokenId)
                .ExecuteDeleteAsync();
        }

        public async Task<Token> UpsertAsync(String tokenValue, Token token)
        {
            var existing = await FindByUserIdAsync(token.UserId);

            if (existing is not null)
            {
                existing.TokenValue = int.Parse(tokenValue);
                existing.ExpiresAt = DateTime.UtcNow.AddMinutes(15);
                _context.Tokens.Update(existing);
                await _context.SaveChangesAsync();
                return existing;
            }

            _context.Tokens.Add(token);
            await _context.SaveChangesAsync();

            return token;
        }
    }
}
