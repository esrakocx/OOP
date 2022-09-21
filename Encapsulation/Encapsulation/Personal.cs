using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Personal
    {
        private string id;
        public string ID
        {
            get
            {
                return id.Substring(0, 5) + "******";        
            }

            set
            {
                if (value.Length == 11)
                {
                    for(int i=0; i<value.Length; i++)
                    {
                        if (char.IsNumber(value[i]))  // IsNumber() returns a bool value
                        {
                            id = value;
                        }
                        else
                        {
                            Console.WriteLine("Your id has invalid characters!");
                            break;
                        }     
                    }
                    
                }
                else
                    Console.WriteLine("Your ID is not 11 digits!");   
            }
        }
    }
}
