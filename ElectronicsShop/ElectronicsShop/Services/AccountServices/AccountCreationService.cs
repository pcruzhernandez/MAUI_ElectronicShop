﻿namespace ElectronicsShop.Services.AccountServices
{
    public class AccountCreationService
    {
        public async Task<AccountInfo> RegisterUserAsync(string login, string password, string repeatPassword)
        {
            string state = AuthDataChecker.CheckRegData(login, password, repeatPassword);
            if (state != AccountErrorMessages.SUCCESS) return new AccountInfo(null, null, state);

            IEnumerable<UserData> accounts = await DataSourceService<UserData>.GetDataAsync();
            if ((from acc in accounts where acc.UserName == login select acc).Any())
                return new AccountInfo(null, null, AccountErrorMessages.SAME_LOGIN_EXIST);

            string role = accounts.Any() ? Roles.User : Roles.Admin;

            UserData newUser = new()
            {
                UID = accounts.Count() + 1,
                UserName = login,
                Password = SHA256HashComputer.ComputeSha256Hash(password),
                Role = role,
            };
            await DataSourceService<UserData>.SaveDataAsync(newUser);

            return new AccountInfo(login, role, AccountErrorMessages.SUCCESS);
        }
    }
}
