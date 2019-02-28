/*
 * Matthew Arndt
 * 2/4/19
 * This class is the internals for making sure no two same numbers get called twice.
 * It does so by using an array of integers, when the number gets used, it assigns the number
 * called to the corresponding spot in the array.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArndtBingo
{
    public class SelectedNumbersListType
    {
        //array of ints
        private int[] arr = new int[76];
        
        //resets all of the values in the array back to 0
        public void reset()
        {
            for (int i = 0; i < 76; i++)
            {
                arr[i] = 0;
            }
        }

        //sets the number called randomly in the form to "used" by storing it in the array
        public void setUsedNumber(int a)
        {
            arr[a] = a;
        }

        //checks whether or not the number was called
        public bool isNumberUsed(int a)
        {

            if (arr[a] == a)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
