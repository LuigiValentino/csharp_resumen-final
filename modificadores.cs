using System;

namespace CSharpConcepts
{
    public class AccessModifiersExample
    {
        // Miembro publico - accesible desde cualquier parte
        public string PublicField = "Público";

        // Miembro privado - accesible solo dentro de esta clase
        private string PrivateField = "Privado";

        // Miembro protegido - accesible solo en clases derivadas
        protected string ProtectedField = "Protegido";

        // Miembro interno - accesible solo dentro del mismo ensamblado
        internal string InternalField = "Interno";

        public void ShowFields()
        {
            Console.WriteLine(PublicField);
            Console.WriteLine(PrivateField);
            Console.WriteLine(ProtectedField);
            Console.WriteLine(InternalField);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            AccessModifiersExample example = new AccessModifiersExample();
            example.ShowFields();
        }
    }
}
