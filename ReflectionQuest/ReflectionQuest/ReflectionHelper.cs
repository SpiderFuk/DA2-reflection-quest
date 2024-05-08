using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionQuest
{
    internal class ReflectionHelper
    {
        public MemberInfo GetNonStaticPublicClassMemberMethodWithLargestArgumentList(string assemblyPath)
        {
            Console.WriteLine("Get the name of a class member which is non static nad has the largest argument list in assembly");
            Assembly assembly = Assembly.LoadFrom(assemblyPath);
            var types = assembly.GetTypes();
            MethodInfo mi = null;
            Type ti = null;
            foreach (var type in types)
            {
                foreach (var method in type.GetMethods())
                {
                    if(mi == null)
                    {
                        mi = method;
                        ti = type;
                    }
                    if (method.GetParameters().Length > mi.GetParameters().Length)
                    {
                        mi = method;
                        ti = type;
                    }
                }
            }
            Console.WriteLine(ti.Name);
            Console.WriteLine(mi.Name);
            return null;
        }

        public MemberInfo FindMethodWithLocalVariablesOfTypeIntAndBool(string assemblyPath)
        {
            Console.WriteLine("Get the name of a method with local variables of type bool and int");
            Assembly assembly = Assembly.LoadFrom(assemblyPath);
            Console.ReadLine();
            throw new NotImplementedException("Not implemented D:");
        }

        public MemberInfo GetTypeThatImplementsIEnumerable(string assemblyPath)
        {
            Console.WriteLine("Get the name of a type that implements IEnumerable");
            Assembly assembly = Assembly.LoadFrom(assemblyPath);
            var types = assembly.GetTypes();
            MethodInfo mi = null;
            Type ti = null;
            foreach (var type in types)
            {
                if (typeof(IEnumerable).IsAssignableFrom(type)){
                    ti = type;
                }
            }
            Console.WriteLine(ti.Name);
            return null;
        }

        public MemberInfo GetTypeThatHasNestedTypeInSpanish(string assemblyPath)
        {
            Console.WriteLine("Get the name of a class member which has a nested type in spanish");
            Assembly assembly = Assembly.LoadFrom(assemblyPath);
            var types = assembly.GetTypes();
            MethodInfo mi = null;
            Type ti = null;
            foreach (var type in types)
            {
                if (typeof(IEnumerable).IsAssignableFrom(type))
                {
                    ti = type;
                }
            }
            throw new NotImplementedException("Not implemented D:");
        }
    }
}
