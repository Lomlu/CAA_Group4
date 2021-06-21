using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE307PrG4
{
    // This classs is used for input and output operations on List<T> items
    //Class has no attributes. Helps to facilitate input/output operations
    //Additional Exception handling may be developed here in future expansion
 
    class InOut
    {
        private string OutPath = @"..\\..\\Pasta.csv";
        string wsep = ","; char rsep = ',';

        public List<Pasta> Pastas = new List<Pasta>();
        public List<MeatFish> MeatFishs = new List<MeatFish>();
        public List<OliveOil> OliveOils = new List<OliveOil>();
        public List<Salad> Salads = new List<Salad>();
        public List<Dessert> Desserts = new List<Dessert>();
        public List<Soup> Soups = new List<Soup>();

        public Pasta Pasta1 = new Pasta();
        public MeatFish MeatFish1 = new MeatFish();
        public OliveOil OliveOil1 = new OliveOil();
        public Salad Salad1 = new Salad();
        public Dessert Dessert1 = new Dessert();
        public Soup Soup1 = new Soup();

        public InOut()
        {
        }

        public void SetOutPath(string s)
        {
            this.OutPath = @"..\\..\\" + s;
        }

        public string GetOutPath()
        {
            return this.OutPath;
        }

        public string GetKeyb(int a, int b, string s)
        {
            Console.WriteLine("Please Enter: " + s);
            string kin = Console.ReadLine();
            if (kin != "0" && kin != "1" && kin != "2" && kin != "3" && kin != "4" &&
                kin != "5" && kin != "6" && kin != "7" && kin != "8" && kin != "9") goto reject;
            int c = int.Parse(kin);
            if (c < a || c > b) goto reject;
            return kin;
        reject:
            Console.WriteLine("Invalid Entry. Type " + a + " - " + b + " Please");
            return null;
        }

        public int GetKeyb()
        {
            int i;
            try
            {
                    if (Int32.TryParse(Console.ReadLine(), out i) != true)
                    throw new Exception("Input error. Try Again");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception " + e);
                i = -1000;
            }

            return i;
        }

        public void AddMenuItem(int k)
        {
            switch (k)
            {
                case 1:
                    Pasta1.SetRecipe(0);
                    Pastas.Add(Pasta1);
                    break;

                case 2:
                    MeatFish1.SetRecipe(0);
                    MeatFishs.Add(MeatFish1);
                    break;

                case 3:
                    OliveOil1.SetRecipe(0);
                    OliveOils.Add(OliveOil1);
                    break;

                case 4:
                    Salad1.SetRecipe(0);
                    Salads.Add(Salad1);
                    break;

                case 5:
                    Dessert1.SetRecipe(0);
                    Desserts.Add(Dessert1);
                    break;

                case 6:
                    Soup1.SetRecipe(0);
                    Soups.Add(Soup1);
                    break;
                default:
                    Console.WriteLine("Please Select Category First");
                    break;
            }
        }

        public void DisplayAll(int t, int c, string h, string cat)
        {
            bool l1=false, m1=false;
            switch(c)
            {
                case 0: Console.WriteLine("__________________ LISTING ALl RECIPES FOR " 
                        + cat + "s ____________________\n");break;

                case 1: break;

                case 2: Console.WriteLine("______________ LISTING ALL RECIPES WITH " + h +
                    " FOR " + cat + "s ________________\n"); break;
                case 3:
                    Console.WriteLine("______________ LISTING ALL RECIPES BELOW " + h + " Cal." +
                " FOR " + cat + "s ________________\n"); break;
                case 4:               
                    Console.WriteLine("______________ LISTING ALL RECIPES UNDER " + h +
                " Mins. FOR " + cat + "s ________________\n"); break;

                default: break;
            }

            int i = 1;
            switch (t)
            {
                case 1:
                   foreach (var q in Pastas)
                   {
                        l1 = false; m1 = false;
                        switch (c)
                        {
                            case 0: l1 = true; break;
                            case 1: if (q.GetRname() == h) m1 = true; break;
                            case 2: l1 = (q.CmpIng(h)); break;
                            case 3: l1 = (q.CmpCal(h)); break;
                            case 4: l1 = (q.CmpTime(h)); break;
                            default: break;
                        }
                         if (m1) q.SetRecipe(-1);
                         if (l1) Console.WriteLine("________________________________________________" + 
                                          "__________________________________\n" +
                             "Menu no.: " + i + " " + q.GetRname() + " " + q.GetCategory() +
                             " Calories in 100g: " + q.GetCalories() + " Cooking Time: " + 
                          q.GetTime() + "\n________________________________________________" + 
                                          "__________________________________");
                        i++;
                   }
                   Console.WriteLine("\n");
                   break;

                case 2:
                    foreach (var q in MeatFishs)
                    {
                        l1 = false; m1 = false;
                        switch (c)
                        {
                            case 0: l1 = true; break;
                            case 1: if (q.GetRname() == h) m1 = true; break;
                            case 2: l1 = (q.CmpIng(h)); break;
                            case 3: l1 = (q.CmpCal(h)); break;
                            case 4: l1 = (q.CmpTime(h)); break;
                            default: break;
                        }
                        if (m1) q.SetRecipe(-1);
                        if(l1)Console.WriteLine("________________________________________________" +
                                          "__________________________________\n" +
                             "Menu no.: " + i + " " + q.GetRname() + " " + q.GetCategory() +
                             " Calories in 100g: " + q.GetCalories() + " Cooking Time: " +
                          q.GetTime() + "\n________________________________________________" +
                                          "__________________________________");
                        i++;
                    }
                    Console.WriteLine("\n");
                    break;

                case 3:
                    foreach (var q in OliveOils)
                    {
                        l1 = false; m1 = false;
                        switch (c)
                        {
                            case 0: l1 = true; break;
                            case 1: if (q.GetRname() == h) m1 = true; break;
                            case 2: l1 = (q.CmpIng(h)); break;
                            case 3: l1 = (q.CmpCal(h)); break;
                            case 4: l1 = (q.CmpTime(h)); break;
                            default: break;
                        }
                        if (m1) q.SetRecipe(-1);
                        if(l1)Console.WriteLine("________________________________________________" +
                                          "__________________________________\n" +
                             "Menu no.: " + i + " " + q.GetRname() + " " + q.GetCategory() +
                             " Calories in 100g: " + q.GetCalories() + " Cooking Time: " +
                          q.GetTime() + "\n________________________________________________" +
                                          "__________________________________");
                        i++;
                    }
                    Console.WriteLine("\n");
                    break;

                case 4:
                    foreach (var q in Salads)
                    {
                        l1 = false; m1 = false;
                        switch (c)
                        {
                            case 0: l1 = true; break;
                            case 1: if (q.GetRname() == h) m1 = true; break;
                            case 2: l1 = (q.CmpIng(h)); break;
                            case 3: l1 = (q.CmpCal(h)); break;
                            case 4: l1 = (q.CmpTime(h)); break;
                            default: break;
                        }
                        if (m1) q.SetRecipe(-1);
                        if(l1)Console.WriteLine("________________________________________________" +
                                          "__________________________________\n" +
                             "Menu no.: " + i + " " + q.GetRname() + " " + q.GetCategory() +
                             " Calories in 100g: " + q.GetCalories() + " Cooking Time: " +
                          q.GetTime() + "\n________________________________________________" +
                                          "__________________________________");
                        i++;
                    }
                    Console.WriteLine("\n");
                    break;

                case 5:
                    foreach (var q in Desserts)
                    {
                        l1 = false; m1 = false;
                        switch (c)
                        {
                            case 0: l1 = true; break;
                            case 1: if (q.GetRname() == h) m1 = true; break;
                            case 2: l1 = (q.CmpIng(h)); break;
                            case 3: l1 = (q.CmpCal(h)); break;
                            case 4: l1 = (q.CmpTime(h)); break;
                            default: break;
                        }
                        if (m1) q.SetRecipe(-1);
                        if(l1)Console.WriteLine("________________________________________________" +
                                          "__________________________________\n" +
                             "Menu no.: " + i + " " + q.GetRname() + " " + q.GetCategory() +
                             " Calories in 100g: " + q.GetCalories() + " Cooking Time: " +
                          q.GetTime() + "\n________________________________________________" +
                                          "__________________________________");
                        i++;
                    }
                    Console.WriteLine("\n");
                    break;

                case 6:
                    foreach (var q in Soups)
                    {
                        l1 = false; m1 = false;
                        switch (c)
                        {
                            case 0: l1 = true; break;
                            case 1: if (q.GetRname() == h) m1 = true; break;
                            case 2: l1 = (q.CmpIng(h)); break;
                            case 3: l1 = (q.CmpCal(h)); break;
                            case 4: l1 = (q.CmpTime(h)); break;
                            default: break;
                        }
                        if (m1) q.SetRecipe(-1);
                        if(l1)Console.WriteLine("________________________________________________" +
                                          "__________________________________\n" +
                             "Menu no.: " + i + " " + q.GetRname() + " " + q.GetCategory() +
                             " Calories in 100g: " + q.GetCalories() + " Cooking Time: " +
                          q.GetTime() + "\n________________________________________________" +
                                          "__________________________________");
                        i++;
                    }
                    Console.WriteLine("\n");
                    break;
                default: break;
            }
        }

        public void WriteList(int w)
        {
            int l = 0;
            switch (w)
            {
                case 1:
                     foreach (var q in Pastas)
                     {
                        if (l == 0) q.WriteToFile(@"..\\..\\Pasta.csv", "cw", wsep);
                        else q.WriteToFile(@"..\\..\\Pasta.csv", "aw", wsep);
                        l++;
                     }
                     break;

                case 2:
                    foreach (var q in MeatFishs)
                    {
                        if (l == 0) q.WriteToFile(@"..\\..\\MeatFish.csv", "cw", wsep);
                        else q.WriteToFile(@"..\\..\\MeatFish.csv", "aw", wsep);
                        l++;
                    }
                    break;

                case 3:
                    foreach (var q in OliveOils)
                    {
                        if (l == 0) q.WriteToFile(@"..\\..\\OliveOil.csv", "cw", wsep);
                        else q.WriteToFile(@"..\\..\\OliveOil.csv", "aw", wsep);
                        l++;
                    }
                    break;

                case 4:
                    foreach (var q in Salads)
                    {
                        if (l == 0) q.WriteToFile(@"..\\..\\Salad.csv", "cw", wsep);
                        else q.WriteToFile(@"..\\..\\Salad.csv", "aw", wsep);
                        l++;
                    }
                    break;

                case 5:
                    foreach (var q in Desserts)
                    {
                        if (l == 0) q.WriteToFile(@"..\\..\\Dessert.csv", "cw", wsep);
                        else q.WriteToFile(@"..\\..\\Dessert.csv", "aw", wsep);
                        l++;
                    }
                    break;

                case 6:
                    foreach (var q in Soups)
                    {
                        if (l == 0) q.WriteToFile(@"..\\..\\Soup.csv", "cw", wsep);
                        else q.WriteToFile(@"..\\..\\Soup.csv", "aw", wsep);
                        l++;
                    }
                    break;

                default: break;

            }

        }

        public void ReadList(int w)
        {
            int i = 0, dim = 15;

            switch (w)
            {
                case 1:
                    Pastas = new List<Pasta>();
                    Pasta pst = new Pasta();
                    string[] pas = pst.ReadFromFile(@"..\\..\\Pasta.csv", rsep);
                    if (pas == null) { Console.WriteLine("Pasta.csv"); break; }
                    for (i = 0; i < pas.Length; i += dim)
                    {
                        pst = new Pasta();
                        pst.SetRname(pas[i + 0]);
                        pst.SetRDef(pas[i + 2]);
                        pst.SetCalories(pas[i + 3]);
                        pst.SetTime(pas[i + 4]);
                        for (int j = 5; j < dim; j++) pst.SetIng(j - 5, pas[i + j]);
                        Pastas.Add(pst);
                    }
                    break;

                case 2:
                    MeatFishs = new List<MeatFish>();
                    MeatFish fst = new MeatFish();
                    string[] fas = fst.ReadFromFile(@"..\\..\\MeatFish.csv", rsep);
                    if (fas == null) { Console.WriteLine("MeatFish.csv"); break; }
                    for (i = 0; i < fas.Length; i += dim)
                    {
                        fst = new MeatFish();
                        fst.SetRname(fas[i + 0]);
                        fst.SetRDef(fas[i + 2]);
                        fst.SetCalories(fas[i + 3]);
                        fst.SetTime(fas[i + 4]);
                        for (int j = 5; j < dim; j++) fst.SetIng(j - 5, fas[i + j]);
                        MeatFishs.Add(fst);
                    }
                    break;

                case 3:
                    OliveOils = new List<OliveOil>();
                    OliveOil ost = new OliveOil();
                    string[] oas = ost.ReadFromFile(@"..\\..\\OliveOil.csv", rsep);
                    if (oas == null) { Console.WriteLine("OliveOil.csv"); break; }
                    for (i = 0; i < oas.Length; i += dim)
                    {
                        ost = new OliveOil();
                        ost.SetRname(oas[i + 0]);
                        ost.SetRDef(oas[i + 2]);
                        ost.SetCalories(oas[i + 3]);
                        ost.SetTime(oas[i + 4]);
                        for (int j = 5; j < dim; j++) ost.SetIng(j - 5, oas[i + j]);
                        OliveOils.Add(ost);
                    }
                    break;

                case 4:
                    Salads = new List<Salad>();
                    Salad sst = new Salad();
                    string[] sas = sst.ReadFromFile(@"..\\..\\Salad.csv", rsep);
                    if (sas == null) { Console.WriteLine("Salad.csv"); break; }
                    for (i = 0; i < sas.Length; i += dim)
                    {
                        sst = new Salad();
                        sst.SetRname(sas[i + 0]);
                        sst.SetRDef(sas[i + 2]);
                        sst.SetCalories(sas[i + 3]);
                        sst.SetTime(sas[i + 4]);
                        for (int j = 5; j < dim; j++) sst.SetIng(j - 5, sas[i + j]);
                        Salads.Add(sst);
                    }
                    break;

                case 5:
                    Desserts = new List<Dessert>();
                    Dessert dst = new Dessert();
                    string[] das = dst.ReadFromFile(@"..\\..\\Dessert.csv", rsep);
                    if (das == null) { Console.WriteLine("Dessert.csv"); break; }
                    for (i = 0; i < das.Length; i += dim)
                    {
                        dst = new Dessert();
                        dst.SetRname(das[i + 0]);
                        dst.SetRDef(das[i + 2]);
                        dst.SetCalories(das[i + 3]);
                        dst.SetTime(das[i + 4]);
                        for (int j = 5; j < dim; j++) dst.SetIng(j - 5, das[i + j]);
                        Desserts.Add(dst);
                    }
                    break;

                case 6:
                    Soups = new List<Soup>();
                    Soup ust = new Soup();
                    string[] uas = ust.ReadFromFile(@"..\\..\\Soup.csv", rsep);
                    if (uas == null) { Console.WriteLine("Soup.csv"); break; }
                    for (i = 0; i < uas.Length; i += dim)
                    {
                        ust = new Soup();
                        ust.SetRname(uas[i + 0]);
                        ust.SetRDef(uas[i + 2]);
                        ust.SetCalories(uas[i + 3]);
                        ust.SetTime(uas[i + 4]);
                        for (int j = 5; j < dim; j++) ust.SetIng(j - 5, uas[i + j]);
                        Soups.Add(ust);
                    }
                    break;

                default: break;


            }
        }

    }
}
