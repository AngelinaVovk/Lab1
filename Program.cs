using System;
//пространство имен
namespace ConsolSettings
{
    //класс программы
    class Program
    {
        //точка начала выполнения команды
        static void Main(string[] args)  
        {
            //название консоли
            Console.Title = "Информационное табло";
            //цвет текста 
            Console.ForegroundColor = ConsoleColor.Green;
            //вывод текста на консоли
            Console.WriteLine("Информация о системе");
            //Имя этого компьютера и вывод на консоль
            Console.WriteLine(Environment.MachineName);
            //Идентификатор платформы и номер версии,вывод на консоль
            Console.WriteLine(Environment.OSVersion);
            //Имя сетевого домена, связанное с текущим пользователем и вывод на консоль
            Console.WriteLine(Environment.UserDomainName);
            //вывод на консоль имени пользователя
            Console.WriteLine(Environment.UserName);
            //Версия среды CLR и вывод на консоль
            Console.WriteLine(Environment.Version);
            //возвращает или задает полный путь к рабочей папке и вывод на консоль
            Console.WriteLine(Environment.CurrentDirectory);
            //Возвращает уникальный идентификатор текущего управляемого потока и вывод на консоль
            Console.WriteLine(Environment.CurrentManagedThreadId);
            //
            Console.WriteLine(Environment.ProcessId);
            //32-разрядное целое число со знаком, указывающее количество доступных процессоров и вывод на консоль
            Console.WriteLine(Environment.ProcessorCount);
            //Значение true, если процесс является 64-разрядным; в противном случае —значение false
            Console.WriteLine(Environment.Is64BitProcess);
            //Значение true, если операционная система является 64-разрядной; в противном случае — значение false
            Console.WriteLine(Environment.Is64BitOperatingSystem);
            //пустая строка
            Console.WriteLine();
            //чтения введенного на консоль слова и вывод его в следующей строке
            Console.WriteLine(Console.ReadLine());
        }
    }
}












