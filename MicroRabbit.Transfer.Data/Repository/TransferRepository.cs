using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Transfer.Data.Repository
{
    public class TransferRepository : ITransferRepository
    {
        private TransferDBContext _db;

        public TransferRepository(TransferDBContext db)
        {
            _db = db;
        }

        public void Add(TransferLog transferLog)
        {
            _db.TransferLogs.Add(transferLog);
            _db.SaveChanges();
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _db.TransferLogs;
        }
    }
}
