using demo.mdi.ais.Helpers.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.mdi.ais.Helpers.ORMInteraction.Models
{
    class AccountModel : ORMBaseModel
    {
        public AccountModel()
            => Row = ORMRepository.Accounts.GetNewRow();

        public int Id { get => (int)Row["Id"]; set => Row["Id"] = value; }
        public string Login { get => Row["Login"] as string; set => Row["Login"] = value; }
        public string Password { get => Row["Password"] as string; set => Row["Password"] = value; }
        public SaltModel Salt
        {
            get => ORMRepository.Salts.ToList().FirstOrDefault(x => x.Row["Id"] == Row["SaltId"]) as SaltModel;
            set => Row["SaltId"] = (ORMRepository.Salts.ToList().FirstOrDefault(x => x == value) as SaltModel).Id;
        }
    }
}
