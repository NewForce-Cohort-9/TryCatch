// For the address book's list of contacts, the easiest and most efficient way to structure your data is a dictionary with the person's email address as the key and their contact as a value. We'll talk about dictionaries in slightly more depth later, but for today you can skip ahead to this chapter and just read the part about dictionaries. Here's an example of what your data structure might look like in your AddressBook class.

public class AddressBook
{ 
    private Dictionary<string, Contact> _contactList {get; set;} = new Dictionary<string, Contact>();
}

