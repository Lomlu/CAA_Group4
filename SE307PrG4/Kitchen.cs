using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SE307PrG4
{
    abstract class Kitchen
    {
        protected string rcname = "None";
        protected string []ingredients = new string[10];
        protected string deftext = "Blank";
        protected string calories = "100";
        protected string time = "10 mims";

        public abstract void SetCategory();
        public abstract string GetCategory();

        public void SetRname()
        {
            Console.WriteLine("Enter a name for This Recipe");
            string s = Console.ReadLine();
            this.rcname = s;
        }

        public void SetRname(string u)
        {
            this.rcname = u;
        }

        public string GetRname()
        {
            return this.rcname;
        }

        public void SetTime(string r)
        {
            this.time = r;
        }

        public bool CmpIng(string d)
        {
            for (int i = 0; i < 10; i++) if (this.ingredients[i] == d) return true;
            return false;
        }

        public bool CmpCal(string d)
        {
            if (int.Parse(this.GetCalories()) <= int.Parse(d)) return true;
            else return false;
        }

        public bool CmpTime(string d)
        {
            int a, b;
            string t = this.time;
            char[] s = t.ToCharArray();
            char[] q = new char[s.Length];
            if (Int32.TryParse(d, out a) != true) return false;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '0' || s[i] == '1' || s[i] == '2' || s[i] == '3' || s[i] == '4' ||
                s[i] == '5' || s[i] == '6' || s[i] == '7' || s[i] == '8' || s[i] == '9')
                { q[i] = s[i]; }
                else q[i] = '\0';
                continue;
            }
            t = new string(q);
            if (Int32.TryParse(t, out b) != true)
                      { Console.WriteLine("Cooking time Error"); return false; }
            if (b <= a) return true;
            else return false;
        }

        public void SetTime()
        {
            Console.WriteLine("Enter Cooking time For this Menu Item: ");
            this.time = Console.ReadLine();
        }

        public string GetTime()
        {
            return this.time;
        }

        public void SetRDef(string g)
        {
            this.deftext = g;
        }

        public void SetRDef()
        {
            Console.WriteLine("Enter Brief Preparation Description");
            string s = Console.ReadLine();
            this.deftext = s;
        }

        public string GetRDef()
        {
            return this.deftext;
        }
// Single Ingredient set Method
        public void SetIng(int z, string a)
        {
            this.ingredients[z] = a;
        }
// Keyboard input for ingredients
        public void SetIng()
        {
            Console.WriteLine("Enter Ingredients For " + this.rcname + 
                                                    " - Hit only 'Enter' to finish");
            string []s = new string[10]; string st;
            int i = 0, k=0; bool l = true;
            while (l)
            {
                Console.WriteLine("Ingredient[" + (i + 1) + "]:");
                st = Console.ReadLine();
                if (st != "") s[i] = st;
                else { l = false; k = i;}
                i++;
                if (i >= 10) break;
            }
            for (i = k; i < 10; i++) s[i] = "0";
            this.ingredients = s;
        }

        public string[] GetIng(bool q)
        {
            string[] p = new string[10];
            for (int i = 0; i < 10; i++)
            {
                p[i] = this.ingredients[i];
                if (q == true && p[i] != "0")
                { Console.WriteLine("Ingredient[" + (i + 1) + "]: " + p[i]); }
            }
           return p;
        }
        // Set calorie method gets an integer input and stores as string.
        // 1 method to set by int keybord input + 1 overload for setting by string value
        public void SetCalories()
        {
            bool l = true; int cnt = 0, n=100;
            while (l)
            {
                Console.WriteLine("Enter Calories for This Recipe");
                while ((Int32.TryParse(Console.ReadLine(), out n)) == false)
                {
                    Console.WriteLine("Input Error Please Enter Again"); cnt++;
                    if (cnt++ > 3) 
                         { Console.WriteLine("Error Limit Exceeded Calories assigned as 100"); 
                                                                                   l = false; }
                }
            }

            this.calories = n.ToString();
        }

        public void SetCalories(string a)
        {
            this.calories = a;
        }

            // Set Calorie Methods gets string calorie rating and converts to int ready for comparison 
            public string GetCalories()
        {
            return this.calories;
        }
        // Recipe ınputting and single recipe selective edit & display method 
        public void SetRecipe(int y)
        {
            {
                if (y == 0 || y == 1) this.SetRname();
                if (y == 0 || y == 2) this.SetIng();
                if (y == 0 || y == 3) this.SetCalories();
                if (y == 0 || y == 4) this.SetRDef();
                if (y == 0 || y == 5) this.SetTime();
            }

            Console.WriteLine("____________________________________\n"+ 
                              "Recipe: " + this.GetRname() +
                            " --- Category: " + this.GetCategory() +
                            "\n____________________________________");
            Console.WriteLine("List of Ingredients"); this.GetIng(true);
            Console.WriteLine("____________________________________\n"+ 
                    "Brief Instructions: \n" + this.GetRDef() +
                              "\n____________________________________");
            Console.WriteLine("Calories per 100g: " + this.GetCalories() +
                                                 " Cooking Time: " + this.time + "\n");
        }

        public void DisplayRecipe()
        {
            string s = null,t;
            Console.WriteLine("_____________________________________________________" +
                              "Name : " + this.rcname + " Category " + this.GetCategory() + 
                          " Calories : " + this.calories + "\n" + " Cooking Time: " + this.time +
                              "_____________________________________________________");
            for (int i = 0; i < 10; i++) {if( (t = this.ingredients[i]) != "0") s += t + "  "; }
            Console.WriteLine("Ingredients: " + s + "\n" + "Instructions :" +
               "_____________________________________________________\n" + this.deftext);
 
        }

        //Write Item Records to CSV file in Create Or Append Mode
        public string WriteToFile(string path, string s, string sep)
        {
            int dim = 20;
            string[] st = new string[dim + 10]; string st1=null;
            st[0] = this.rcname; st[1] = sep; st[2] = this.GetCategory(); st[3] = sep;
            st[4] = this.deftext; st[5] = sep; st[6] = this.calories; st[7] = sep;
            st[5] = sep; st[8] = this.calories; st[9] = sep;
            for (int i = 0; i < dim; i += 2)
            {
                st[i + 10] = this.ingredients[i/2];
                if (i != dim - 2) st[i + 11] = sep;
                else st[i + 11] = Environment.NewLine;
            }
            for (int i = 0; i < dim + 10; i++) st1 +=  st[i];
            if (s == "cw") {File.WriteAllText(path, st1); return null; }
            if (s == "aw") { File.AppendAllText(path, st1); return null; }
            else  return st1;
 
        }
        // Read Items Record from CSV file
        public string[] ReadFromFile(string p, char sep)
        {
            if (!File.Exists(p)) { Console.WriteLine("File Not Created Yet"); return null; }
            string[] InLines = File.ReadAllLines(p);
            int dim = 15;
            int i = 0, j, k= InLines.Length, n=dim*k;
            string[] t;
            string[] tp = new string[n];

            foreach (string q in InLines)
            {
                t = q.Split(sep);
                for (j = 0; j < dim; j++)
                {
                    tp[i * dim + j] = t[j];
                }
                i++;
            }
            return tp;
        }



    }

}
