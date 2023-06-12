using System;
using System.Collections.Generic;
using System.Text;

namespace Container_4_1_
{
    class Markt
    {
        private Custumer firstCustumer;
        private Custumer lastCustumer;
        private string MarketName;

        public Markt(string MarketName)
        {
            this.MarketName = MarketName;
            firstCustumer = null;
            lastCustumer = null;
        }

        public void addCustumer(Custumer famCustumer)
        {
            if (firstCustumer == null)
            {
                firstCustumer = famCustumer;
                lastCustumer = famCustumer;
            }
            else
            {
                lastCustumer.setNext(famCustumer);
                lastCustumer = famCustumer;
            }
        }

        public Custumer findCustumer(string famCustumer)
        {
            Custumer curr = firstCustumer;
            while (curr != null)
            {
                if (curr.getFam() == famCustumer)
                {
                    return curr;
                }
                else
                {
                    curr = curr.getNext();
                }
            }
            return null;
        }

        public float averageSum()
        {
            Custumer pTemp = firstCustumer;
            float aver = 0;
            int curr = 0;
            while (pTemp != null)
            {
                aver += pTemp.sumCs();
                pTemp.getNext();
                curr++;
            }
            aver = aver / curr;
            return aver;
        }

        public string GetAllData()
        {
            Custumer pTemp = firstCustumer;
            string total = "";

            while (pTemp != null)
            {
                total += pTemp.getData();
                pTemp = pTemp.getNext();
            }

            return total;
        }
    }
}
