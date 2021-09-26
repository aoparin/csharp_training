﻿using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : AuthTestBase
    {
        [Test]
        public void ContactCreationTest()
        {
            ContactData contact = new ContactData("User1", "Test1");
            contact.Middlename = "Middlename1";
            contact.Notes = "123";

            app.Contacts.Add(contact);
        }

        [Test]
        public void EmptyContactCreationTest()
        {
            ContactData contact = new ContactData("", "");
            contact.Middlename = "";
            contact.Notes = "";

            app.Contacts.Add(contact);
        }
    }
}
