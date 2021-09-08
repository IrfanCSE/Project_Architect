using Core.IRepository.Accounts;

namespace Accounts.Repository
{
    public class Bank : IBank
    {
        public string GetBankList(bool def)
        {
            return $"{def.ToString()} - from Accounts Bank";
        }
    }
}