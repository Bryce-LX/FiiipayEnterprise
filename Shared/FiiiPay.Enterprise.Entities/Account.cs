using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiiiPay.Enterprise.Entities
{
   public class Account
    {
        public Guid Id { get; set; }

        public string PhoneCode { get; set; }

        public string Cellphone { get; set; }

        public string Email { get; set; }

        public string Username { get; set; }

        public string MerchantName { get; set; }

        public decimal Balance { get; set; }

        public string Password { get; set; }

        public string PIN { get; set; }

        public byte Status { get; set; }

        public string CallbackUrl { get; set; }

        public bool IsVerifiedEmail { get; set; }

        public int CountryId { get; set; }

        public string Currency { get; set; }

        public DateTime RegistrationDate { get; set; }

        public Guid Photo { get; set; }

        public string SecretKey { get; set; }

        public bool IsAllowPayment { get; set; }

        public string AuthSecretKey { get; set; }
    }
}
