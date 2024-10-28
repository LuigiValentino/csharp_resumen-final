using System;
using System.IO;

namespace CSharpConcepts
{
    public class FileOperations
    {
        public static void Main(string[] args)
        {
            string filePath = "example.txt";
            string copyPath = "copy_example.txt";
            string text = "Este es un ejemplo de texto.";

            // AppendText() - Agrega texto al final de un archivo existente
            File.AppendAllText(filePath, "Texto agregado al final del archivo.\n");

            // Copy() - Copia un archivo
            File.Copy(filePath, copyPath, overwrite: true);
            Console.WriteLine("Archivo copiado a " + copyPath);

            // Create() - Crea o sobrescribe un archivo
            using (FileStream fs = File.Create("newfile.txt"))
            {
                byte[] info = new System.Text.UTF8Encoding(true).GetBytes("Este es un nuevo archivo.");
                fs.Write(info, 0, info.Length);
            }
            Console.WriteLine("Archivo 'newfile.txt' creado.");

            // Delete() - Elimina un archivo
            if (File.Exists(copyPath))
            {
                File.Delete(copyPath);
                Console.WriteLine("Archivo copiado eliminado.");
            }

            // Exists() - Verifica si el archivo existe
            if (File.Exists(filePath))
            {
                Console.WriteLine("El archivo " + filePath + " existe.");
            }
            else
            {
                Console.WriteLine("El archivo " + filePath + " no existe.");
            }

            // ReadAllText() - Lee el contenido de un archivo
            if (File.Exists(filePath))
            {
                string fileContent = File.ReadAllText(filePath);
                Console.WriteLine("Contenido del archivo:");
                Console.WriteLine(fileContent);
            }

            // Replace() - Reemplaza el contenido de un archivo con el contenido de otro archivo
            File.WriteAllText("file_to_replace.txt", "Este es el contenido original.");
            File.WriteAllText("replacement_file.txt", "Este es el nuevo contenido.");

            File.Replace("replacement_file.txt", "file_to_replace.txt", "backup_file.txt");
            Console.WriteLine("Contenido del archivo reemplazado.");

            // WriteAllText() - Crea un nuevo archivo y escribe contenido en el. Si ya existe, lo sobrescribe
            File.WriteAllText("write_example.txt", text);
            Console.WriteLine("Contenido escrito en 'write_example.txt'.");
        }
    }
}
