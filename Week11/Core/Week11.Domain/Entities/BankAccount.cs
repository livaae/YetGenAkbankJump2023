using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week11.Domain.Common;
//using Week11.API.Models.ModelMetadataTypes;



namespace Week11.Domain.Entities
{
   // [ModelMetadataType(typeof(BankAccountMetadata))]  
    public class BankAccount : EntityBase<Guid>
    { 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public decimal Balance { get; set; }
    }
}
