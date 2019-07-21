using FiiiPay.Enterprise.Data;
using FiiiPay.Enterprise.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiiiPay.Enterprise.Business
{
    public class AccountComponent
    {
        public async Task<Account> GetAccountByUsernameAsync(string username)
        {
            return await new AccountDAC().SelectByUsernameAsync(username);
        }

        public async Task<Account> GetAccountByEmailAsync(string email)
        {
            return await new AccountDAC().SelectByEmailAsync(email);
        }

        public Account GetAccountById(Guid accountId)
        {
            return new AccountDAC().SelectById(accountId);
        }

        public async Task<Account> GetAccountByIdAsync(Guid accountId)
        {
            return await new AccountDAC().SelectByIdAsync(accountId);
        }

        public async Task<bool> CheckEmailBind(Guid accountId, string email)
        {
            return await new AccountDAC().CheckEmailExistAsync(accountId, email);
        }

        public async Task<RequestResult> SetPasswordAndEmailAsync(Guid accountId,string password,string email,byte status)
        {
            var accountDAC = new AccountDAC();
            var existEmailAccount = await accountDAC.CheckEmailExistAsync(accountId, email);
            if (existEmailAccount)
                return new RequestResult(false, "AccountFirstSetting", "EmailBindByOtherAccount");
            await accountDAC.SetPasswordAndEmailAsync(accountId, password, email, status);
            return new RequestResult(true);
        }
        public async Task<bool> ResetPasswordAsync(Guid accountId, string password)
        {
            await new AccountDAC().SetPasswordAsync(accountId, password);
            return true;
        }
        public async Task<bool> ResetEmailAsync(Guid accountId, string email)
        {
            await new AccountDAC().SetEmailAsync(accountId, email);
            return true;
        }
    }
}
