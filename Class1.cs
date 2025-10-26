using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class IP
    {
        private int[] segments = new int[4];

        // to make a class indexer must do the following
        public int this[int index]
        {
            get
            {
                return segments[index];
            }
            set
            {
                segments[index] = value;
            }
        }
        public IP(string ipaddresses)
        {
            var segs = ipaddresses.Split('.');
            for (int i = 0; i < segs.Length; i++)
            {
                segments[i] = Convert.ToInt32(segs[i]);
            }

        }
        public IP(int seg1,int seg2,int seg3 , int seg4) 
        { 
            segments[0] = seg1;
            segments[1] = seg2;
            segments[2] = seg3;
            segments[3] = seg4;
        }
        public string address => string.Join('.', segments);
    }

    public class Soduko
    {
        private int[,] _matrix;
        // public Soduko(int[,] matrix)
        // {
        //     this._matrix = matrix;
        // }
       
       
        public int this[int row,int col]
        {
            get
            {
                if(row < 0 || row > this._matrix.GetLength(0)-1) // getlength(0) mean rows
                
                    return -1;
                
                if (col < 0 || col > this._matrix.GetLength(1) - 1)  // getlength(1) mean columns
                
                    return -1;
                
                return this._matrix[row,col];
            }
            set
            {
                if (value < 0 || value > this._matrix.GetLength(0)-1)
                
                    return;

                this._matrix[row,col] = value;
            }
            

        }
       
    }
}
