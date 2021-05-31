using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
namespace Ex3.Models
{
    class PersonManager
    {   
        
        public static void Save(List<Person> people,int Huihe)
        {
            try
            {
                FileStream fs = new FileStream("PeopleSave.txt", FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(Huihe);
                foreach (Person person in people)
                {
                    sw.WriteLine(person.Type);//写它的类型
                    sw.WriteLine(person.CurrentLife); //当前生命值
                    sw.WriteLine(person.Lei);
                }
                sw.Close();
                fs.Close();
            }catch(Exception e)
            {
                throw e;
            }
        }
        public static void Save2(List<Person> people,int Huihe)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream("peopleSave.bin",FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, people);
                bf.Serialize(fs, Huihe);
            }catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                fs.Close();
            }
        }
        public static  List<Person> Load2(ref int Huihe)
        {
            FileStream fs = null;
            List<Person> people = null;
            try
            {
                fs = new FileStream("peopleSave.bin", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                people = (List<Person>)bf.Deserialize(fs);
                Huihe = (int)bf.Deserialize(fs);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                fs.Close();
            }
            return people;
        }
        public static int Load(List<Person> people)
        {
            int type;
            int CurrentLife;
            int Lei;
            int Huihe = 0;
            try
            {
                FileStream fs = new FileStream("PeopleSave.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                Huihe = int.Parse(sr.ReadLine());
                for (int i = 0; i < people.Count; i++)
                {
                    type = int.Parse(sr.ReadLine()); //类型
                    foreach (Person person in people)
                    {
                        if (person.Type == type)
                        {
                            CurrentLife = int.Parse(sr.ReadLine());//当前生命值
                            person.CurrentLife = CurrentLife;
                            Lei = int.Parse(sr.ReadLine());
                            person.Lei = Lei;
                        }
                    }
                }
                sr.Close();
                fs.Close();
                return Huihe;
            }catch(Exception e){
                Console.WriteLine(e.Message);
                throw e;
            }
        }
    }
}
