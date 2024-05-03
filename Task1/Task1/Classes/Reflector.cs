using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace Task1.Classes
{
    public class Reflector
    {
        private List<string> publicMethods;
        private List<string> fieldsAndProp;
        private List<string> interfaces;
        private List<string> methodsWithParam;

        // Сохраняет содержимое введенного класса в файл, по соответствующему пути.
        public void SaveMembersConcertSystemToFile(string nameClass, string filePath)
        {
            Type typeClas = Type.GetType(nameClass);
            
            if (typeClas == null)
                throw new Exception($"Класс {nameClass} пустой.");

            if (string.IsNullOrWhiteSpace(filePath))
                throw new Exception("Неизвестный путь.");

            if (File.Exists(filePath))
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    foreach (MemberInfo member in typeClas.GetMembers())
                    {
                        sw.WriteLine(member);
                    }
                }
            }
            else
                throw new Exception("Файл не существует");
        }

        // Извлечение публичных методов.
        public List<string> ExtrPublicMethods(string nameClass)
        {
            Type typeClas = Type.GetType(nameClass);

            if (typeClas == null)
                throw new Exception($"Класс {nameClass} пустой.");

            if (publicMethods == null)
                publicMethods = new List<string>();
            else
                publicMethods.Clear();

            foreach (MemberInfo mbInfo in typeClas.GetMethods(BindingFlags.Public | BindingFlags.Instance))
            {
                publicMethods.Add($"Публичные методы: {mbInfo.Name}");
            }

            return publicMethods;
        }

        // Извлечение полей и свойств
        public List<string> GetFieldsAndProps(string nameClass)
        {
            Type typeClas = Type.GetType(nameClass);

            if (typeClas == null)
                throw new Exception($"Класс {nameClass} пустой.");

            if (fieldsAndProp == null)
                fieldsAndProp = new List<string>();
            else
                fieldsAndProp.Clear();

            foreach (FieldInfo field in typeClas.GetFields())
            {
                fieldsAndProp.Add($"Поля: {field.Name}");
            }

            foreach (PropertyInfo property in typeClas.GetProperties())
            {
                fieldsAndProp.Add($"Свойства: {property.Name}");
            }

            return fieldsAndProp;
        }

        // Получение реализуемых интерфейсов
        public List<string> GetInterfaces(string nameClass)
        {
            Type typeClas = Type.GetType(nameClass);

            if (typeClas == null)
                throw new Exception($"Класс {nameClass} пустой.");

            if (interfaces == null)
                interfaces = new List<string>();
            else
                interfaces.Clear();

            foreach (Type interf in typeClas.GetInterfaces())
            {
                interfaces.Add(interf.Name);
            }

            return interfaces;
        }

        // Получение методов с соответствующим параметром
        public List<string> GetMethodsWithParam(string nameClass, Type type)
        {
            Type typeClas = Type.GetType(nameClass);

            if (typeClas == null)
                throw new Exception($"Класс {nameClass} пустой.");

            if (methodsWithParam == null)
                methodsWithParam = new List<string>();
            else
                methodsWithParam.Clear();

            var methodsWithParametrs = typeClas.GetMethods().Where(meth => meth.GetParameters().Any(param => param.ParameterType == type));

            foreach (var methodInfo in methodsWithParam)
            {
                methodsWithParam.Add($"Метод: {methodInfo}");
            }

            return methodsWithParam;
        }

        // Исполнение метода из файла
        public void ExecMethodFromFile(string nameClass, string nameMethod, string filePath)
        {
            Type typeClas = Type.GetType(nameClass);

            if (typeClas == null)
                throw new Exception($"Класс {nameClass} пустой.");

            object copy = Activator.CreateInstance(typeClas); // Создается экземпляр.

            MethodInfo method = typeClas.GetMethod(nameMethod);
            if (method == null)
                throw new Exception("Метод не найден");

            using (StreamReader sr = new StreamReader(filePath))
            {
                string textParam = sr.ReadLine();
                string[] textParams = textParam.Split(',');

                object[] arguments = new object[method.GetParameters().Length];

                for (int i = 0; i < method.GetParameters().Length; i++)
                {
                    arguments[i] = Convert.ChangeType(textParams[i], method.GetParameters()[i].ParameterType);
                }

                method.Invoke(copy, arguments);
            }
        }
    }
}
