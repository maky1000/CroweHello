using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CroweHello.Models
{
    //Repository Pattern 
    public class SecretMessagesRepository:ISecretMessageRepository
    {
        public string GetDecryptedSecretMessage {
            get
            {
                SecretMessages secretMessages = new SecretMessages {Data = "Hello World"}; // Ideally retrieved from any type of data source. 
                return secretMessages.Data;
            }
        }
    }
}