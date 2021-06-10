using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CookingAdvisorApplication_Group4
{
    class SaladReceipts : CookingReceiptMainClass
    {
        private string saladReceiptFolder;
        private string subCategoryFolderName;
        private string receiptTextFilePath;

        public SaladReceipts()
        {
            saladReceiptFolder = getReceiptFolderPath() + @"\Salad";
        }

        public void setSaladReceiptFolder(string saladRecFol)
        {
            saladReceiptFolder = getReceiptFolderPath() + @"\" + saladRecFol;
        }

        public string getSaladReceiptFolder()
        {
            return saladReceiptFolder;
        }

        public void setSubCategoryFolderName(string subCatName)
        {
            subCategoryFolderName = saladReceiptFolder + @"\" + subCatName;
        }

        public string getSubCategoryFolderName()
        {
            return subCategoryFolderName;
        }

        public void setReceiptTextFilePath(string receiptName)
        {
            receiptTextFilePath = subCategoryFolderName + @"\" + receiptName + @".txt" ;
        }

        public string getReceiptTextFilePath()
        {
            return receiptTextFilePath;
        }

        public override void addNewReceipt()
        {
            base.addNewReceipt();

            setSubCategoryFolderName(getReceiptSubCategory());
            setReceiptTextFilePath(getReceiptName());

            if (!Directory.Exists(getSubCategoryFolderName()))
            {
                Console.WriteLine("New Sub Category " + getReceiptSubCategory() +" Added...");

                Directory.CreateDirectory(getSubCategoryFolderName());
            }

            if (!File.Exists(getReceiptTextFilePath()))
            {
                using (StreamWriter streamWriter = File.CreateText(getReceiptTextFilePath()))
                {
                    streamWriter.WriteLine("Receipt ID: " + getReceiptID());
                    streamWriter.WriteLine();
                    streamWriter.WriteLine("Receipt Name: " + getReceiptName());
                    streamWriter.WriteLine();
                    streamWriter.WriteLine("Receipt Category: " + getReceiptCategory());
                    streamWriter.WriteLine();
                    streamWriter.WriteLine("Receipt Sub Category: " + getReceiptSubCategory());
                    streamWriter.WriteLine();
                    streamWriter.WriteLine("Number of Calories: " + getNumberOfCalories());
                    streamWriter.WriteLine();
                    streamWriter.WriteLine("Time for being Prepared: " + getNeededTime());
                    streamWriter.WriteLine();
                    streamWriter.WriteLine("Ingrediants: ");
                    for (int i = 0; i < getIngrediants().Length; i++)
                    {
                        streamWriter.WriteLine((i + 1) + ") " + getIngrediants()[i]);
                    }
                    streamWriter.WriteLine();
                    streamWriter.WriteLine("Cooking Directions: ");
                    for (int i = 0; i < getCookingDirections().Length; i++)
                    {
                        streamWriter.WriteLine(getCookingDirections()[i]);
                    }

                }
            }
            else
            {
                Console.WriteLine("Receipt Name Already Exists in this Sub Category. Enter 1 to overwrite 2 to enter everything from start...");
                int answer = Convert.ToInt32(Console.ReadLine());

                if(answer == 1)
                {
                    using (StreamWriter streamWriter = File.CreateText(getReceiptTextFilePath()))
                    {
                        streamWriter.WriteLine("Receipt ID: " + getReceiptID());
                        streamWriter.WriteLine();
                        streamWriter.WriteLine("Receipt Name: " + getReceiptName());
                        streamWriter.WriteLine();
                        streamWriter.WriteLine("Receipt Category: " + getReceiptCategory());
                        streamWriter.WriteLine();
                        streamWriter.WriteLine("Receipt Sub Category: " + getReceiptSubCategory());
                        streamWriter.WriteLine();
                        streamWriter.WriteLine("Number of Calories: " + getNumberOfCalories());
                        streamWriter.WriteLine();
                        streamWriter.WriteLine("Time for being Prepared: " + getNeededTime());
                        streamWriter.WriteLine();
                        streamWriter.WriteLine("Ingrediants: ");
                        for (int i = 0; i < getIngrediants().Length; i++)
                        {
                            streamWriter.WriteLine((i + 1) + ") " + getIngrediants()[i]);
                        }
                        streamWriter.WriteLine();
                        streamWriter.WriteLine("Cooking Directions: ");
                        for (int i = 0; i < getCookingDirections().Length; i++)
                        {
                            streamWriter.WriteLine(getCookingDirections()[i]);
                        }

                    }
                }
                else if(answer == 2)
                {
                    this.addNewReceipt();
                }
                else
                {
                    Console.WriteLine("Wrong Entry...");
                }
            }
        }
    }
}
