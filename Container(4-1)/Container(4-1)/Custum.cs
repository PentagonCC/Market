using System;
using System.Collections.Generic;
using System.Text;

namespace Container_4_1_
{
    class Custumer
    {
        private Custumer next;
        private string famCustumer;
        private int[] productsCost = new int[40];
        private int kolCost;


        public Custumer(string afam)
        {
            next = null;
            famCustumer = afam;
            kolCost = 0;
        }

        public Custumer getNext()
        {
            return next;
        }

        public void setNext(Custumer next)
        {
            this.next = next;
        }

        public string getFam()
        {
            return famCustumer;
        }


        public void setFam(string afam)
        {
            famCustumer = afam;
        }

        public int getKolCost()
        {
            return kolCost;
        }

        public int getPrCost(int nom)
        {
            if (kolCost <= 0 || nom > 39)
                return 0;
            else
                return productsCost[nom];
        }

        public void setPrCost(int nom, int newCost)
        {
            if (nom < kolCost && nom >= 0 && newCost > 1)
                productsCost[nom] = newCost;
        }

        public bool addPrCost(int newCost)
        {
            if (kolCost < 40 && newCost >= 1)
            {
                productsCost[kolCost] = newCost;
                kolCost++;
                return true;
            }
            else return false;
        }

        public float averageCs()
        {
            float aver = 0;
            if (kolCost <= 0)
                return 0;
            else
            {
                for (int i = 0; i < kolCost; i++)
                {
                    aver = aver + productsCost[i];
                }
                aver = aver / kolCost;
                return (float)aver;
            }
        }

        public float sumCs()
        {
            float aver = 0;
            if (kolCost <= 0)
                return 0;
            else
            {
                for (int i = 0; i < kolCost; i++)
                {
                    aver = aver + productsCost[i];
                }

                return (float)aver;
            }
        }

        public string getData()
        {
            string result = famCustumer;
            for (int i = 0; i < kolCost; i++)
            {
                result = result + " " + productsCost[i];
            }
            result = result + " average cost = " + Convert.ToString(averageCs());
            return result;
        }
    }
}
