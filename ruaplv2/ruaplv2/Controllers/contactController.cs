using ruaplv2.Models;
using ruaplv2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ruaplv2.Controllers
{
    public class ContactController : ApiController
    {
        private ContactRepository contactRepository;

        public ContactController()
        {
            this.contactRepository = new ContactRepository();
        }

       public Contact[] Get()
        {
            return contactRepository.GetAllContacts();
        }
    }
}
