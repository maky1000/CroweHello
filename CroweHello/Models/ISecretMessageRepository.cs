using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CroweHello.Models
{
    // Repository Pattern used 
    public interface ISecretMessageRepository
    {
        string GetDecryptedSecretMessage { get; }
    }
}
