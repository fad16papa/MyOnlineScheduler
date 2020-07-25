using System.Linq;
using System.Security.Claims;
using Application.Interface;
using Microsoft.AspNetCore.Http;

namespace Infrastructure.Security
{
    public class UserAccessor : IUserAccessor
    {
        #region Properties
        private readonly IHttpContextAccessor _httpContextAccessor;
        #endregion

        #region Contructor
        public UserAccessor(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        #endregion

        #region Methods
        //This will get the userName of the current user
        public string GetCurrentUsername()
        {
            var userName = _httpContextAccessor.HttpContext.User?.Claims?.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;

            return userName;
        }
        #endregion
    }
}