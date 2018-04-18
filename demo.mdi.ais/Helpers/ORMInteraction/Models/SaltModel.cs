using demo.mdi.ais.Helpers.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.mdi.ais.Helpers.ORMInteraction.Models
{
    class SaltModel : ORMBaseModel
    {
        public SaltModel()
            => Row = ORMRepository.Salts.GetNewRow();

        public string Id { get => Row["Id"] as string; set => Row["Id"] = value; }
        public string Salt { get => Row["Salt"] as string; set => Row["Salt"] = value; }
    }
}
