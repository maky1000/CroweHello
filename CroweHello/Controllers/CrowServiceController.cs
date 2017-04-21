using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CroweHello.Models;

namespace CroweHello.Controllers
{
    public class CrowServiceController : ApiController
    {
        private readonly ISecretMessageRepository _messageRepository;

        /// <summary>
        /// Dependency Injection is to enable to do unit testing. For DI, I have used IOC Container Ninject, please refer App_Start\NinjectWebCommon.cs
        /// </summary>
        /// <param name="messageRepository">Object injected from NinjectWebCommon.cs</param>
        public CrowServiceController(ISecretMessageRepository messageRepository)
        {
            this._messageRepository = messageRepository;
        }

        [AcceptVerbs("GET")]
        [HttpGet]
        public string SecretMessage()
        {
            return _messageRepository.GetDecryptedSecretMessage;
        }

    }
}
