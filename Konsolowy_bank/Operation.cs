using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsolowy_bank
{
    public class Operation
    {
        public enum OperationType
        {
            deposit,
            withdraw
        }

        public OperationType type;
        public DateOnly data;
        public decimal amount;

        public Operation(OperationType type, decimal amount)
        {
            this.type = type;
            this.amount = amount;
            data = DateOnly.FromDateTime(DateTime.Now);
        }
        
            
    }
}
