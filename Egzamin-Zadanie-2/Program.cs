using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Egzamin_Zadanie_2
{
    [Serializable()]
    public class MojaKlasa {
        public int A = 7;
        [OnSerializing()]
        internal void OnSerializingMethod(StreamingContext context) {
            A += 1;
            Console.WriteLine("{0}", A);
        }
        [OnSerialized()]
        internal void OnSerializedMethod(StreamingContext context) {
            A += 2;
            Console.WriteLine("{0}", A);
        }
        [OnDeserializing()]
        internal void OnDeserializingMethod(StreamingContext context) {
            A -= 2;
            Console.WriteLine("{0}", A);
        }
        [OnDeserialized()]
        internal void OnDeserializedMethod(StreamingContext context) {
            A -= 1;
            Console.WriteLine("{0}", A);
        }
    }
    class Test {
        static void Main(string[] args) {
            MojaKlasa obj = new MojaKlasa();
            BinaryFormatter formater = new BinaryFormatter();
            FileStream fs = null;
            try {
                fs = new FileStream("dane.dat", FileMode.Create);
                formater.Serialize(fs, obj);
            }
            finally {
                if (fs != null)
                    fs.Close();
            }
            try {
                fs = new FileStream("dane.dat", FileMode.Open);
                obj = (MojaKlasa)formater.Deserialize(fs);
            }
            finally {
                if (fs != null)
                    fs.Close();
            }
            Console.WriteLine("{0}", obj.A);
        }
    }
}