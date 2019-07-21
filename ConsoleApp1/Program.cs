using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class data
    {
        public string surname;
        public string name ;
        public string patronymic;
        public string phone;
        public string country;
        public string birth;
        public string org;
        public string post;
        public string other;
        public data(string surnameIN, string nameIN, string patronymicIN, string phoneIN, string countryIN, string birthIN, string orgIN, string postIN, string otherIN)
        {
            surname = surnameIN;
            name = nameIN;
            patronymic = patronymicIN;
            phone = phoneIN;
            country = countryIN;
            birth = birthIN;
            org = orgIN;
            post = postIN;
            other = otherIN;
        }    
    }
    class phone
    {
        public List<data> Contacts = new List<data>();
        public void IN(string surnameIN, string nameIN, string patronymicIN, string phoneIN, string countryIN, string birthIN, string orgIN, string postIN, string otherIN)
        {
            data contact = new data(surnameIN, nameIN, patronymicIN, phoneIN, countryIN, birthIN, orgIN, postIN, otherIN);
            Contacts.Add(contact);
        }
        public bool checkName(string name) {
            data contact1 = Contacts.Find( 
                delegate (data f)
        {
                return f.name == name;
              });
            data contact2 = Contacts.FindLast(
                delegate (data f)
                {
                    return f.name == name; 
                });
            if (contact1 == contact2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool empty()
        {
            return (Contacts.Count == 0);
        }
        public data findname(string name)
        {
            data contact = Contacts.Find(
              delegate (data f)
              {
                  return f.name == name;
              });
        return contact;
        }
        public bool checkSurname(string name, string surname)
        {
            data contact1 = Contacts.Find(
                delegate (data f)
                {
                    return (f.name == name && f.surname == surname);
                });
            data contact2 = Contacts.FindLast(
                delegate (data f)
                {
                    return (f.surname == surname && f.name == name);
                });
            if (contact1 == contact2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public data findsurname(string name, string surname)
        {
            data contact = Contacts.Find(
              delegate (data f)
              {
                  return f.surname == surname && f.name == name;
              });
            return contact;
        }
        public bool checkPdatronymic(string name, string surname,string patronymic)
        {
            data contact1 = Contacts.Find(
                delegate (data f)
                {
                    return (f.patronymic == patronymic && f.surname == surname && f.name == name);
                });
            data contact2 = Contacts.FindLast(
                delegate (data f)
                {
                    return (f.patronymic == patronymic && f.surname == surname && f.name == name);
                });
            if (contact1 == contact2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
            public data finpdatronymic(string name, string surname, string patronymic)
        {
            data contact = Contacts.Find(
              delegate (data f)
              {
                  return (f.patronymic == patronymic && f.surname == surname && f.name == name);
              });
            return contact;
        }
        public bool checkCountry( string name, string surname, string patronymic, string country)
        {
            data contact1 = Contacts.Find(
                delegate (data f)
                {
                    return (f.country == country && f.patronymic == patronymic && f.surname == surname && f.name == name);
                });
            data contact2 = Contacts.FindLast(
                delegate (data f)
                {
                    return (f.country == country && f.patronymic == patronymic && f.surname == surname && f.name == name);
                });
            if (contact1 == contact2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public data findcountry(string name, string surname, string patronymic, string country)
        {
            data contact = Contacts.Find(
              delegate (data f)
              {
                  return (f.country == country && f.patronymic == patronymic && f.surname == surname && f.name == name);
              });
            return contact;
        }
        public void remove(data a)
        {
            Contacts.Remove(a);
        }
        public void showAll(Action<data> f)
        {
            Contacts.ForEach(f);
        }
    }
    
    class job
    {
        phone Phone = new phone();
        static void Main(string[] args)
        {
            string choose = "";
            job j = new job();
            j.menu();
            while (!choose.ToUpper().Equals("QUIT"))
            {
                Console.WriteLine("Select the action");
                choose = Console.ReadLine();
                j.action(choose);
            }

        }
        void menu()
        {
            Console.WriteLine("List of commands \n   Add - Add new contact \n   Delete - Remove contact \n   Edit - Edit contact \n   List - List of all contacts \n   Contact - List of one contact \n   Quit - End the session ");
        }
        void action(string choose)
        {
         string surnameIN="";
         string nameIN = "";
         string patronymicIN = "";
         string phoneIN = "";
         string countryIN = "";
         string birthIN = "";
         string orgIN = "";
         string postIN = "";
         string otherIN = "";
            switch (choose.ToUpper())
            {
                case "ADD": Console.WriteLine("Enter the name of contact");
                    nameIN = Console.ReadLine();
                    while (nameIN == null)
                    {
                        Console.WriteLine("Invalid data entered");
                        nameIN = Console.ReadLine();
                    }
                    Console.WriteLine("Enter the surname of contact");
                    surnameIN = Console.ReadLine();
                    while (surnameIN == null)
                    {
                        Console.WriteLine("Invalid data entered");
                        surnameIN = Console.ReadLine();
                    }
                    Console.WriteLine("Enter the patronymic of contact");
                    patronymicIN = Console.ReadLine();
                    while (patronymicIN == null)
                    {
                        Console.WriteLine("Invalid data entered");
                        patronymicIN = Console.ReadLine();
                    }
                    Console.WriteLine("Enter the phone of contact");
                    phoneIN = Console.ReadLine();
                    while (phoneIN == null)
                    {
                        Console.WriteLine("Invalid data entered");
                        phoneIN = Console.ReadLine();
                    }
                    Console.WriteLine("Enter the country of contact");
                    countryIN = Console.ReadLine();
                    while (countryIN == null)
                    {
                        Console.WriteLine("Invalid data entered");
                        countryIN = Console.ReadLine();
                    }
                    Console.WriteLine("Enter the birthday of contact");
                    birthIN = Console.ReadLine();
                    while (birthIN == null)
                    {
                        Console.WriteLine("Invalid data entered");
                        birthIN = Console.ReadLine();
                    }
                    Console.WriteLine("Enter the organization of contact (if this box is empty, enter '-')");
                    orgIN = Console.ReadLine();
                    while (orgIN == null)
                    {
                        Console.WriteLine("Invalid data entered");
                        orgIN = Console.ReadLine();
                    }
                    Console.WriteLine("Enter the post in organization of contact (if this box is empty, enter '-')");
                    postIN = Console.ReadLine();
                    while (postIN == null)
                    {
                        Console.WriteLine("Invalid data entered");
                        postIN = Console.ReadLine();
                    }
                    Console.WriteLine("Enter the other info about contact (if this box is empty, enter '-')");
                    otherIN = Console.ReadLine();
                    while (otherIN == null)
                    {
                        Console.WriteLine("Invalid data entered ");
                        otherIN = Console.ReadLine();
                    };
                    Phone.IN( surnameIN, nameIN, patronymicIN, phoneIN, countryIN,  birthIN, orgIN,postIN, otherIN);
                    break;
                case "DELETE":
                    find(choose, surnameIN, nameIN, patronymicIN, countryIN, birthIN);
                    break;
                case "EDIT":
                    find(choose, surnameIN, nameIN, patronymicIN, countryIN, birthIN);
                    break;
                case "LIST":
                    if (Phone.empty())
                    {
                        Console.WriteLine("-----------------\nThe list is empty\n-----------------");
                    }
                    else
                    {
                        Phone.showAll(delegate (data a)
                        {
                            Console.WriteLine("-----------------\nName --- {0}\nSurname --- {1}\nPhone number --- {2}\n-----------------", a.name,a.surname,a.phone);
                        });
                    }
                    break;
                case "CONTACT":
                    data one = find(choose, surnameIN, nameIN, patronymicIN, countryIN, birthIN);
                    if (one != null)
                    {
                        Console.WriteLine("-----------------\nName --- {0}\nSurname --- {1}\nPatronymic --- {2}\nPhone number --- {3}\nCountry --- {4}\nBirthday --- {5}\nOrganization --- {6}\nPost --- {7}\nOther --- {8}\n-----------------", one.name, one.surname,one.patronymic, one.phone, one.country, one.birth, one.org, one.post, one.other);
                    }
                    else
                    {
                        Console.WriteLine("Еhis user does not exist");
                    }
                    break;
            }
         }
        data find(string choose, string surnameIN, string nameIN, string patronymicIN, string countryIN, string birthIN)
        {
            data r ;
            int search;
            data time;
            Console.WriteLine("Enter the name of contact");
            nameIN = Console.ReadLine();
            if (Phone.checkName(nameIN))
            {
                if (choose.ToUpper() == "DELETE")
                {
                    Phone.remove(Phone.findname(nameIN));
                    Console.WriteLine("The removal was successful");
                }
                else
                {
                    if (choose.ToUpper() == "EDIT")
                    {
                        ShowTheVariants();
                        search = int.Parse(Console.ReadLine());
                        time = Phone.findname(nameIN);
                        editer(search, time);
                    }
                }
                r= Phone.findname(nameIN);
            }
            else
            {
                Console.WriteLine("There is more than one contact with this description \n Enter the surname");
                surnameIN = Console.ReadLine();
                if (Phone.checkSurname(nameIN, surnameIN))
                {
                    if (choose.ToUpper() == "DELETE")
                    {
                        Phone.remove(Phone.findsurname(nameIN, surnameIN));
                        Console.WriteLine("The removal was successful");
                    }
                    else
                    {
                        if (choose.ToUpper() == "EDIT")
                        {
                            ShowTheVariants();
                            search = int.Parse(Console.ReadLine());
                            time = Phone.findsurname(nameIN, surnameIN);
                            editer(search, time);
                        }
                    }
                    r= Phone.findsurname(nameIN, surnameIN);
                }
                else
                {
                    Console.WriteLine("There is more than one contact with this description \n Enter the patronymic");
                    patronymicIN = Console.ReadLine();
                    if (Phone.checkPdatronymic(nameIN, surnameIN, patronymicIN))
                    {
                        if (choose.ToUpper() == "DELETE")
                        {
                            Phone.remove(Phone.finpdatronymic(nameIN, surnameIN, patronymicIN));
                            Console.WriteLine("The removal was successful");
                        }
                        else
                        {
                            if (choose.ToUpper() == "EDIT")
                            {
                                ShowTheVariants();
                                search = int.Parse(Console.ReadLine());
                                time = Phone.finpdatronymic(nameIN, surnameIN, patronymicIN);
                                editer(search, time);
                            }
                        }
                        r= Phone.finpdatronymic(nameIN, surnameIN, patronymicIN);
                    }
                    else
                    {
                        Console.WriteLine("There is more than one contact with this description \n Enter the country");
                        countryIN = Console.ReadLine();
                        if (Phone.checkCountry(nameIN, surnameIN, patronymicIN, countryIN))
                        {
                            if (choose.ToUpper() == "DELETE")
                            {
                                Phone.remove(Phone.findcountry(nameIN, surnameIN, patronymicIN, countryIN));
                                Console.WriteLine("The removal was successful");
                            }
                            else
                            {
                                if (choose.ToUpper() == "EDIT")
                                {
                                    ShowTheVariants();
                                    search = int.Parse(Console.ReadLine());
                                    time = Phone.findcountry(nameIN, surnameIN, patronymicIN, countryIN);
                                    editer(search, time);
                                }
                            }
                            r = Phone.findcountry(nameIN, surnameIN, patronymicIN, countryIN);
                        }
                        else { Console.WriteLine("Sorry I tired to check this conditions!!!");
                            r = null;
                            }
                    }
                }
            }
            return r;
        }
        void ShowTheVariants()
        {
            Console.WriteLine("Select the number of the item you want to change \n1)Name\n2)Surname\n3)Patronymic\n4)Number\n5)Country\n6)Birthday\n7)Organization\n8)Post\n9)Other");
        }
        void editer(int search,data time)
        {
            switch (search)
            {
                case 1:
                    Console.WriteLine("Enter new name");
                    time.name = Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Enter new surname");
                    time.surname = Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Enter new patronymic");
                    time.patronymic = Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine("Enter new phone");
                    time.phone = Console.ReadLine();
                    break;
                case 5:
                    Console.WriteLine("Enter new country");
                    time.country = Console.ReadLine();
                    break;
                case 6:
                    Console.WriteLine("Enter new birthday");
                    time.birth = Console.ReadLine();
                    break;
                case 7:
                    Console.WriteLine("Enter new organization");
                    time.org = Console.ReadLine();
                    break;
                case 8:
                    Console.WriteLine("Enter new post");
                    time.post = Console.ReadLine();
                    break;
                case 9:
                    Console.WriteLine("Enter new other info");
                    time.other = Console.ReadLine();
                    break;
            }
        }
    }
}