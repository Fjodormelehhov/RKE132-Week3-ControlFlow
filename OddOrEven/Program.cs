Console.WriteLine("Enter a number");
int usernum = Convert.ToInt32(Console.ReadLine());

//kas kasutaja arv on paaris või paaritu

int result = usernum % 2;

if  (result != 0) //!= ei ole
{
    Console.WriteLine("User number is odd");
}
else
{
    Console.WriteLine("Usernumber is even");
}