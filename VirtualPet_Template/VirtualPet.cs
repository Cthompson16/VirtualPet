using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet_Template
{

    class VirtualPet
    {
        //Set fiels to private so only the VirtualPet class can modify them directly
        private string name;
        private int hunger;
        private int boredom;
        private int dirty;
        private int thirsty;
                
        //this defaut constructor is set options without giving us any options
        public VirtualPet()
        {
            this.name = " PeeWee";
            this.hunger = 0;
            this.boredom = 10;
            this.dirty = 5;
            this.thirsty = 0;

        }

        //Array: Set things with my construtors
        public VirtualPet(string name, int hunger, int boredom, int dirty, int thirsty)
            
        {
            this.name = name;
            this.hunger = hunger;
            this.boredom = boredom;
            this.dirty = dirty;
            this.thirsty = thirsty; 
        }
                //Loop which makes emotions increase or decrease based on users options
                public void HungerIncrease()
        {
            
            this.hunger = hunger + 7;
        }
                
        public void HungerDecrease()
            
        {   
            
            this.hunger =  hunger + 4 ;
        }

        public void BoredomDecrease()

        {
            this.boredom = boredom - 4;
        }

        public void BoredomIncrease()

        {
            this.boredom = boredom + 1;
        }

        public void DirtyDecrease()

        {
            this.dirty = dirty - 4;

        }

        public void DirtyIncrease()

        {
            this.dirty = dirty + 5;
        }

        public void ThirstyDecrease()

        {
            this.thirsty = thirsty - 5;
        }

        public void ThirstyIncrease()

        {
            this.thirsty = thirsty + 6;
        }
                 
                
        //method for stats of virtual pet
        public void MyPetStatus()

        {
            Console.WriteLine(name);
            Console.WriteLine("Hunger: " + hunger);
            Console.WriteLine("Bored:" + boredom);
            Console.WriteLine("Dirty:" + dirty);
            Console.WriteLine("Thirsty:" + thirsty);
        







            





        }
    }
}
