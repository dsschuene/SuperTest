using MusicalInstrunments;
Console.WriteLine("How many records do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());

var recordList = new List<Guitar>();
for (int i = 0; i < numberOfRecords; i++)
{
	// In this loop, populate the object's properties using Console.ReadLine()
	var myGuitar = new Guitar();

	Console.WriteLine("How many strings have I got? ");
	myGuitar.numberOfStrings = Convert.ToInt32(Console.ReadLine());
    

	recordList.Add(myGuitar);

    Console.WriteLine("Number of Strings: " + myGuitar.numberOfStrings);
}

// Print out the list of records using Console.WriteLine()