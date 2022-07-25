using AutoMapper;
using BestPractice.Api.Data.Model;
using BestPractice.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestPractice.Api.Service
{
    public class ContactService : IContactService
    {
        private readonly IMapper _mapper;

        public ContactService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public ContactDVO GetContactById(int id)
        {
            Contact data = GetDummyContact();
            return new ContactDVO()
            {
                FullName = data.FirstName + " " + data.LastName,
                Id = id
            };
        }

        private Contact GetDummyContact()
        {
            return new Contact()
            {
                FirstName = "Recep",
                LastName="Çelimli",
                Id = 58
            };
        }
    }
}
