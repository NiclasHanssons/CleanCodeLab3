using HouseF;

HouseFactory factory = new HouseFactory();
House studenHouse = factory.BuildHouse("studenthouse");
House familyHouse = factory.BuildHouse("familyhouse");
House mansionHouse = factory.BuildHouse("mansionhouse");

Console.WriteLine("--- Student house ---");
Console.WriteLine(studenHouse);

Console.WriteLine("--- Family house ---");
Console.WriteLine(familyHouse);

Console.WriteLine("--- Mansion house ---");
Console.WriteLine(mansionHouse);

