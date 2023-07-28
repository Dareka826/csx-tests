using System.Reflection;
using System;

static class ReflectDump {
    public static void DumpMethods(Type t) {
        var methods_data = t.GetMethods();
        foreach (var method_info in methods_data) {
            Console.Write($"{method_info.Name} -> {method_info.ReturnType} : {{");

            var params_data = method_info.GetParameters();
            foreach (var param in params_data) {
                Console.Write($" ({param.ParameterType} {param.Name})");
            }

            Console.WriteLine(" }");
        }
    }
}
