using System;
static string FullFIO(string surname, string name, string patronymic) {
	string fio = surname + " " + name + " " + patronymic;
	return fio;
}
static string CreateFIO(string surname, string name, string patronymic) {
	string fio = surname + " " + name.Substring(0, 1) + ". " + patronymic.Substring(0, 1) + ".";
	return fio;
}
string[,] FIO = {
	{"Yuhimuk", "Sergiy", "Vitaliyovych"},
	{"Grant", "Thomas", "Gustin"},
	{"Thomas", "Tom", "Cavanagh"}
};
for (int i = 0; i < 3; i++) {
	Console.WriteLine(FullFIO(FIO[i, 0], FIO[i, 1], FIO[i, 2]));
	Console.WriteLine(CreateFIO(FIO[i, 0], FIO[i, 1], FIO[i, 2]));
}
Console.ReadLine();