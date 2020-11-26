using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using _4Source;

namespace _4Source.persistencia
{
    public class Dados
    {
        private const string fileName = "dados.dat";

        public static void GuardarDados(Autarquia autarquia)
        {
            MemoryStream stream = SerializeToStream(autarquia);
            System.IO.File.WriteAllBytes(fileName, stream.ToArray());
        }


        public static Autarquia CarregarDados()
        {
            Autarquia data = null;
            if (File.Exists(fileName))
            {
                using (var stream = new MemoryStream(System.IO.File.ReadAllBytes(fileName)))
                {
                    data = (Autarquia)DeserializeFromStream(stream);
                }
            }
            else
            {
                data = new Autarquia("Viana do Castelo", 10);
            }
            return data;
        }

        private static MemoryStream SerializeToStream(object o)
        {
            MemoryStream stream = new MemoryStream();
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, o);
            return stream;
        }

        private static object DeserializeFromStream(MemoryStream stream)
        {
            IFormatter formatter = new BinaryFormatter();
            stream.Seek(0, SeekOrigin.Begin);
            object o = formatter.Deserialize(stream);
            return o;
        }
    }
}
