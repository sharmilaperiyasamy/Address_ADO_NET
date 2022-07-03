Address_Book_ADO_NET.Address_Book_System add = new Address_Book_ADO_NET.Address_Book_System();
Console.WriteLine("SQL Operations:\n0.Exit\n1.Display the data\n2.Create the new record\n3.Update the data\n4.Delete the record\nEnter your choice : ");
int choice = Convert.ToInt32(Console.ReadLine());

while (choice != 0)
{
    switch (choice)
    {
        case 1:
            add.getDataFromDB();
            break;
        case 2:
            add.createRecord();
            break;
        case 3:
            add.updateDatabase();
            break;
        case 4:
            add.DeletePerson();
            break;
        default:
            Console.WriteLine("Enter the valid choice : ");
            break;
    }
    Console.WriteLine("SQL Operations:\n0.Exit\n1.Display the data\n2.Create the new record\n3.Update the data\n4.Delete the record\nEnter your choice : ");
    choice = Convert.ToInt32(Console.ReadLine());
}
