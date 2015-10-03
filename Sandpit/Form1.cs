using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Sandpit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MakeSureYouDispose c = new MakeSureYouDispose();
            c.FindChar("abc", 'b');
        }
    }

    public class A 
    { 
        //private A instance; 
        //private A() { } 
        //public static A Instance 
        //{ 
        //    get 
        //    { 
        //        if (instance == null) instance = new A(); 
        //        return instance; 
        //    } 
        //} 
    }

    public class MakeSureYouDispose : IDisposable
    {
        internal bool FindChar (string s, char ch)
        {
            bool found = false;
            for (int i = 1; i <= s.Length; ++i)
            {
                if (s[i] == ch)
                {
                    found = true;
                }
            }
            return found;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }

}
