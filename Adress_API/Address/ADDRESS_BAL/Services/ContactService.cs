using ADDRESS_DAL.Data;
using ADDRESS_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADDRESS_BAL.Services
{
    public class ContactService
    {

        private readonly AddressAppContext _context;

        //Inyección de dependencia
        public ContactService() => _context= new AddressAppContext();
        

        public async void postNewContact(Contact contact)
        {
           await _context.Contacts.AddAsync(contact);
           await  _context.SaveChangesAsync();
        }

        public List<Contact> getContacts() {
           List<Contact> contacts = _context.Contacts.ToList();

            return contacts;
        }

        public Contact getContactById(int id)
        {
            Contact contact = _context.Contacts.Find(id);

            return contact;
        }

        public  void updateContact(Contact contact)
        {
            //Esta forma me tira error al hacer SaveChangesAsync()
            /*Contact contactToUpdate = _context.Contacts.Find(id);
            if(contactToUpdate != null)
            {
                contactToUpdate.Name = contact.Name;
                contactToUpdate.Address = contact.Address;
                contactToUpdate.BirthDate = contact.BirthDate;
                contactToUpdate.PhoneNumber = contact.PhoneNumber;

                await _context.AddAsync(contactToUpdate);
                await _context.SaveChangesAsync();
            }*/

            _context.Contacts.Update(contact);
            _context.SaveChanges();
        }

        public void deleteContact(int id)
        {
            Contact contact = _context.Contacts.Find(id);
            if(contact!= null)
            {
                _context.Contacts.Remove(contact);
                _context.SaveChanges();
            }
        }
    }
}
