using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructAFarm
{
    class Farmer
    {
        public int BagsOfFeed { get; private set; }
        /*property*/
        //BagsofFeed is a read only field, it can not be modified outside of this class

        private int feedMultiplier;
        public int FeedMultiplier { get { return feedMultiplier; } }
        /*property*/
        //this property acts just like an int field, but instead of storing a value it just returns the
        //backing field (feedMultiplier). There is no set accessor, meaning it is read-only
        //its public get means other classes can access it to read, but it can only be set within Farmer

        public Farmer(int numberOfCows, int feedMultiplier)
        {
            this.feedMultiplier = feedMultiplier;
            NumberOfCows = numberOfCows;
        }
        /*contructor*/
        //nb lack of void / int etc as contrsuctor has no return value
        //this keyword used to ref the field, not the parametet. EG 'for this instance of farmer, this..'


        private int numberOfCows;
        //lowercase n to indicate private field
        public int NumberOfCows
        {
            get { return numberOfCows; }
            //the get accessor is a method. its run any time the NumberOfCows property is read
            //it has a return value that matches the type of variable, in this case the value
            //of the private numberOfCows property.
            //read as: when I am asked to get my value, I will return x
            set {
                numberOfCows = value;
                BagsOfFeed = NumberOfCows * FeedMultiplier;
                }
            //read as: when I asked to remember my value (given one) I will store this number,
            //I will also influence the BagsOfFeed value
        }
        //declartion for NumberOfCows
        //get and set to be considered methods, these 'accessors' are simply methods
        //all get / set accessors accept a parameter (value). it contains whatever field is set to


    }
}
