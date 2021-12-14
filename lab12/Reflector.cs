using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace lab12
{
    static class Reflector
    {
        public static string GetAssemblyName(string className)
        {
            return Type.GetType(className).Assembly.ToString();
        }

        public static bool IsAnyPublicConstructors(string className)
        {
            if (Type.GetType(className).GetConstructors().Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static IEnumerable<string> GetPublicMethods(string className)
        {
            List<string> methods = new List<string>();

            foreach(var item in Type.GetType(className).GetMethods())
            {
                methods.Add(item.Name);
            }

            return methods;
        }

        public static IEnumerable<string> GetFieldsAndProp(string className)
        {
            List<string> fieldsAndProp = new List<string>();

            foreach (var item in Type.GetType(className).GetFields())
            {
                fieldsAndProp.Add(item.Name);
            }

            foreach (var item in Type.GetType(className).GetProperties())
            {
                fieldsAndProp.Add(item.Name);
            }

            return fieldsAndProp;
        }

        public static IEnumerable<string> GetInterfaces(string className)
        {
            List<string> interfaces = new List<string>();

            foreach (var item in Type.GetType(className).GetInterfaces())
            {
                interfaces.Add(item.Name);
            }

            return interfaces;
        }

        public static void MethodType(string name, string param, StreamWriter sw)
        {
            Type type = Type.GetType(name);
            foreach (var item in type.GetMethods())
            {
                if (item.GetParameters().Any(e => e.Name == param))
                {
                    sw.WriteLine(item);
                }
            }
        }
        public static void Invoke(string name, string methodName)
        {
            try
            {
                Type type = Type.GetType(name, false, true);
                object obj = Activator.CreateInstance(type);
                string[] param = File.ReadAllLines(@"param.txt");
                MethodInfo method = type.GetMethod(methodName);
                method.Invoke(obj, param);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static object Create(string name)
        {
            return Activator.CreateInstance(Type.GetType(name));
        }
    }
}
