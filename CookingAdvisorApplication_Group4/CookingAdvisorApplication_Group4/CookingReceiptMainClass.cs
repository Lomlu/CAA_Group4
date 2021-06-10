using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CookingAdvisorApplication_Group4
{
    class CookingReceiptMainClass
    {
        

        private string projectDirectory;
        private string receiptFolderName;
        private string receiptFolderPath;

        private int receiptID;
        private string receiptName;
        private string receiptCategory;
        private string receiptSubCategory;
        private int numberOfCalories;
        private double neededTime;
        private string[] ingredients;
        private string[] cookingDirections;

        public CookingReceiptMainClass() //this is our Main classes constructor, this sets our projects directory and Receipts folder path...
        {
            projectDirectory = Directory.GetParent(Directory.GetParent(Directory.GetParent(Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory)).FullName).FullName).FullName;
            receiptFolderName = @"\Receipts";
            receiptFolderPath = projectDirectory + receiptFolderName;
        }

        //set and get methods for the attributes
        public void setProjectDirectory(string pDirectory) //This part won't be necessary unless we change Receipts folders location...
        {
            projectDirectory = pDirectory;                //If we change Receipts folders location outside our projects directory we need to set the pDirectory to Receipts Folders outer path...
        }

        public string getProjectDirectory()
        {
            return projectDirectory;
        }

        public void setReceiptFolderName(string receiptFolName) //This part won't be necessary unless we change Receipts folders folder name...
        {
            receiptFolderName = @"\" + receiptFolName;
        }

        public string getReceiptFolderName()
        {
            return receiptFolderName;
        }

        public void setReceiptFolderPath() //Since ReceiptFolderPath is sum of projectDirectory and receiptFolderName, if we want to set receiptFolderPath first we need to set projectDirectory and receipt folderName...
        {
            receiptFolderPath = projectDirectory + receiptFolderName;
        }

        public string getReceiptFolderPath()
        {
            return receiptFolderPath;
        }

        public void setReceiptID(int rID)
        {
           receiptID = rID;
        }

        public int getReceiptID()
        {
            return receiptID;
        }

        public void setReceiptName(string rName)
        {
            receiptName = rName;
        }

        public string getReceiptName()
        {
            return receiptName;
        }

        public void setReceiptCategory(string rCategory)
        {
           receiptCategory = rCategory;
        }

        public string getReceiptCategory()
        {
            return receiptCategory;
        }

        public void setReceiptSubCategory(string subCat)
        {
            receiptSubCategory = subCat;
        }

        public string getReceiptSubCategory()
        {
            return receiptSubCategory;
        }

        public void setNumberOfCalories(int numCal)
        {
           numberOfCalories = numCal;
        }

        public int getNumberOfCalories()
        {
            return numberOfCalories;
        }

        public void setNeededTime(double time)
        {
            neededTime = time;
        }

        public double getNeededTime()
        {
           return neededTime;
        }

        public void setIngrediants(string[] ingrdnts)
        {
            ingredients = ingrdnts;
        }

        public string[] getIngrediants()
        {
            return ingredients;
        }

        public void setCookingDirections(string[] cDirect)
        {
           cookingDirections = cDirect;
        }

        public string[] getCookingDirections()
        {
            return cookingDirections;
        }

        public virtual void addNewReceipt()
        {
            Console.WriteLine();
            Console.WriteLine("Oh here comes a new receipt. It's delicious. Yummy!!!");
            Console.WriteLine();
            Console.WriteLine("Please enter the Receipt ID: ");
            this.setReceiptID(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine();
            Console.WriteLine("Please enter the Receipt Name: ");
            this.setReceiptName(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Please enter the Receipt Category: ");
            this.setReceiptCategory(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Please enter the Receipt Sub Category: ");
            this.setReceiptSubCategory(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Please enter Number of Calories: ");
            this.setNumberOfCalories(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine();
            Console.WriteLine("Please enter Time for being Prepared: ");
            this.setNeededTime(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine();
            Console.WriteLine("Please enter Ingredients: (enter -1 to stop entering ingredients...)");
            string[] innerIngredientsArray = new string[30];
            for(int i = 0; ; i++)
            {
                if (Console.ReadLine().Equals("-1"))
                {
                    break;
                }
                else
                {
                    innerIngredientsArray[i] = Console.ReadLine();
                }
            }
            this.setIngrediants(innerIngredientsArray);
            Console.WriteLine();
            Console.WriteLine("Please enter Cooking Directions: (Press enter after writing each step, enter -1 to stop entering directions...)");
            string[] innerCookingDirectionsArray = new string[30];
            for(int i = 0; ; i++)
            {
                if (Console.ReadLine().Equals("-1"))
                {
                    break;
                }
                else
                {
                    innerCookingDirectionsArray[i] = Console.ReadLine();
                }
            }
            this.setCookingDirections(innerCookingDirectionsArray);

        }

        public void displayAllReceipts()
        {
            //This part will be added after adding all classes...
        }

        public void displayReceiptByCategory(string category)
        {

        }

        public virtual void displayReceiptByReceiptName(string receiptName)
        {
            //I do not know if this part needs to be virtual...
        }

        public void displayReceiptByIngrediant(string ingredient)
        {

        } 
    }
}
