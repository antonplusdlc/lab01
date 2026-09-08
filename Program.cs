string myName = "Anton";
string groupName = "ISP-253/254/RUPO-265";
int courceNum = 2;
double averageGrade = 4.3;
bool isStud = true;

Console.WriteLine($"{myName}\n{groupName}\n{courceNum}\n{averageGrade}\n{isStud}");

Console.WriteLine();

Console.WriteLine("Remont: room");

double roomW = 3.5;
double roomL = 4.2;

double roomArea = roomW * roomL;
double roomPer = (roomW + roomL) * 2;

Console.WriteLine($"Shirina: {roomW} m, dlina: {roomL} m");
Console.WriteLine($"Ploshad: {roomArea} kv.m");
Console.WriteLine($"Per: {roomPer} m");

Console.WriteLine();
Console.WriteLine("pokupka noyta v rassrochky");

int laptopPrice = 65000;
int months = 12;
double interest = 0.08;

double total = laptopPrice * (1 + interest);
double monthlyPay = total / months;

Console.WriteLine($"Chena noyta: {laptopPrice} rub.");
Console.WriteLine($"Itogo c procentomi: {total} rub.");
Console.WriteLine($"Platesh: {monthlyPay} rub.");

Console.WriteLine();
Console.WriteLine("delenie int");

int totalStuds = 25;
int groupsCnt = 4;

int studsPerGroupWrong = totalStuds / groupsCnt;
double studsPerGroupCorrect = (double)totalStuds / groupsCnt;

Console.WriteLine($"25 / 4 int: {studsPerGroupWrong}");
Console.WriteLine($"25/4 double: {studsPerGroupCorrect}");

Console.WriteLine();
Console.WriteLine("Sposobi sobrat string");

string firstName = "Anna";
string lastName = "Smirnova";

// +
string fullNameConcat = firstName + " " + lastName;

// $""
string fullNameInterp = $"{firstName} {lastName}";

// str.Concat

string fullNameConcatMethod = string.Concat(firstName, " ", lastName);

Console.WriteLine($"{fullNameConcat}\n{fullNameInterp}\n{fullNameConcatMethod}\nVse strings ravni: {fullNameConcat == fullNameInterp && fullNameInterp == fullNameConcatMethod}");

Console.WriteLine();
Console.WriteLine("Constants");

const double VatRate = 0.20;
const string CollegeName = "VF VolSU"; // вряд-ли название поменяют, поэтому const

double productPrice = 1000;
double priceWithVat = productPrice * (1 + VatRate);

Console.WriteLine($"Ychebnoe zavedenie: {CollegeName}\nChena bez NDS: {productPrice}, s NDS ({VatRate:P0}):{priceWithVat}");

int stepend = 5000;
int mounthlyTrata = 4000;
const int MonthsInSemestr = 4;
Console.WriteLine();
Console.WriteLine($"skolko ostanetsa za semestr: {(stepend - mounthlyTrata) * MonthsInSemestr}");

int totalMinutes = 500;
int minutesPerLesson = 45;

Console.WriteLine($"{totalMinutes} min = {(totalMinutes / minutesPerLesson)} zanatiy + {(totalMinutes % minutesPerLesson)} min");