using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace truckTour
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<List<int>> arr = new List<List<int>>();

            List<int> a = new List<int>() { 1, 5 };
            arr.Add(a);
            List<int> b = new List<int>() { 10, 3 };
            arr.Add(b);
            List<int> c = new List<int>() { 3, 4 };
            arr.Add(c);

            Console.WriteLine(truckTour(arr));
        }
        public static int truckTour(List<List<int>> petrolpumps)
        {
            int truck = 0, pump = 0;

            for (int i = 0; i < petrolpumps.Count; i++)
            {
                truck += petrolpumps[i][0] - petrolpumps[i][1];
                if (truck < 0)
                {
                    pump = i + 1;
                    truck = 0;
                }
            }

            return pump;
        }
    }
}
