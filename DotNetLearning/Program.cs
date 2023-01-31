// See https://aka.ms/new-console-template for more information

using DotNetLearning.ExceptionTasks;
using DotNetLearning.KeyWorlds;
using DotNetLearning.RefTasks;

ExceptionTasks exception = new ExceptionTasks();
MyCustomException e = new MyCustomException();

//exception.ThrowWithStackTraceException(e);
exception.ThrowWithStackTraceException();  

Console.WriteLine("Hello, World!");

//Try to send long to method SetInt, check how boxing and unboxing work
var keyWordsTask = new KeyWordsTask();
object int5 = 5;
object string5  = "5";
object chsr5 = '5';
object double5 = 5.5;
string newStr = keyWordsTask.SetString(string5);

RefTasks refTasks = new RefTasks();
int value = 5;
refTasks.RefValueType(ref value);
Console.WriteLine(value);
RefTasksParam param = new RefTasksParam();
refTasks.SimpleReferenceType(param);
refTasks.RefReferenceType(ref param);
Console.WriteLine(param);