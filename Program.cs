// See https://aka.ms/new-console-template for more information

//MTN NOTIFICATION
using System.Net.NetworkInformation;

Console.WriteLine("===Network Server Notification Message===");
Random rand =new();
int monthSubscriptionEnd = rand.Next(1,  6);
string rollOver = "Kindly roll over to get a 10% discount bonus, ";
string subExpiry = "Your monthly subscription will soon expire";
string subEnd = "Your monthly subscription will expire tommorow";
string greetings = "Thanks for choosing MTN";
Console.WriteLine($"{monthSubscriptionEnd} days left");

if (monthSubscriptionEnd == 5)
{
    Console.WriteLine($"Notification: {subExpiry}\n {rollOver}");
} 
else if (monthSubscriptionEnd ==4)
{
    Console.WriteLine($"Notification: {subExpiry}\n {greetings}");
}
else if (monthSubscriptionEnd ==3)
{
    Console.WriteLine($"Notification: {subExpiry}\n {greetings}");
}
else if (monthSubscriptionEnd ==2)
{
    Console.WriteLine($"Notification: {subExpiry}\n {greetings}");
}
else if (monthSubscriptionEnd ==1)
{
    Console.WriteLine($"Notification: {subEnd}\n{rollOver} {greetings}");
}


// switch (monthSubscriptionEnd)
// {
//     case int subscription when monthSubscriptionEnd == 5:
//       Console.WriteLine($"Notification: {subExpiry}\n {rollOver}");
//        break;
//     case int subscription when monthSubscriptionEnd ==4:
//       Console.WriteLine($"Notification: {subExpiry}\n {greetings}");
//        break;
//     default:
//     Console.WriteLine("Invalid operation entered");
//     break;
// }



