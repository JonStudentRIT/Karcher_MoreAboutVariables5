using System;

namespace MoreAboutVariables5
{
    /* Author: Jonathan Karcher
     * Purpose: To store the values of x, y, and z when incramented by .1 in the equation 3y^2 + 2x - 1
     * Restrictions: None
     */
    class Program
    {
        /* Method: Main
         * Purpose: calculate z = 3y^2 + 2x - 1, and store x and y
         * Restrictions: None
         */
        static void Main(string[] args)
        {
            // create an array to store x, y, and z
            double[,,] calculation = new double[21, 30, 3];
            // create a variable for z
            double z = 0;
            // create a variable for the x index
            int xIndex = 0;
            // create a variable for the y index
            int yIndex = 0;
            // start at -1 and incrament by .1 to 1
            for (double x = -1; x <= 1; x += .1, xIndex++)
            {
                // reset the y index to 0
                yIndex = 0;
                // start at 1 and incrament by .1 to 4
                for (double y = 1; y <= 4; y += .1, yIndex++)
                {
                    // calculate z
                    z = 3 * Math.Pow(y, 2) + 2 * x - 1;
                    // store x
                    calculation[xIndex, yIndex, 0] = x;
                    // store y
                    calculation[xIndex, yIndex, 1] = y;
                    // store z
                    calculation[xIndex, yIndex, 2] = z;
                }
            }
        }
    }
}
