// See https://aka.ms/new-console-template for more information
string newpath = @"C:\Users\Lemucya\Desktop\FinalVerificationWork112022\Test";

string [] Text = File.ReadAllText(newpath)
.Split(new char[]{' ', ',', ':', ';','.','!'}
, StringSplitOptions.RemoveEmptyEntries); 
foreach (string item in Text)
{
    Console.WriteLine(item);
}
