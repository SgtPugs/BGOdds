using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    
    public class Method
    {
        /*  N CHOOSE R = n!/ r!*(n-r)!
         * 18/728
         * 0.0247
         * */
        // 0 is left blank due to array starting at 0

        private readonly int[] minionCount = { 0, 252, 255, 221, 176, 144, 66 };
        private readonly int[] minioncounttier = { 0, 18, 15, 14, 11, 9, 6 };
        private readonly int[] demand = { 0, 3, 6, 9, 12 };

       
        public float oddsForMinion(int pTier,int mTier, int demandnum)
        {
            if (pTier < mTier)
            {
                return 0F;
            }
            int MinionSum = 0;
            
            for (int i = 1; i <= pTier; i++)
            {
                MinionSum = MinionSum + minionCount[i];
            }
            int rolls = 3;
            for(int i = 1; i <= pTier; i++)
            {
                if(i % 2 == 0)
                {
                    ++rolls;
                }
            }
            Console.WriteLine(rolls);
            int mCount = minioncounttier[mTier] - demand[demandnum];
            float Success = (float)mCount / (float)MinionSum;
            var distribution = new Distribution(Success, rolls);
            return (float)distribution.atleast(1);
            
            
        }
    }
}
