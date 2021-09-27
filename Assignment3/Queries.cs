using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Assignment3
{
    public class Queries
    {

        public static IEnumerable<string> getWizardsByRowling() {
            var wizards = Wizard.Wizards.Value;
            return wizards.Where(w => w.Creator == "J.K Rowling")
                          .Select(w => w.Name).Distinct();            
        }

        public static IEnumerable<string> getWizardsByRowlingLinq() {
            var wizards = Wizard.Wizards.Value;
            var name = from w in wizards 
                       where w.Creator == "J.K Rowling" 
                       select w.Name;   
            return name.Distinct();         
        }

        public static int? getFirstSithLordYear() {
            var wizards = Wizard.Wizards.Value;
            return wizards.Where(w => w.Name
                          .StartsWith("Darth"))
                          .Select(w => w.Year).Min();            
        }


        public static int? getFirstSithLordYearLinq() {
            var wizards = Wizard.Wizards.Value;
            var year = from w in wizards 
                       where w.Name.StartsWith("Darth") 
                       select w.Year;

            return year.Min();         
        }

        public static IEnumerable<(string, int?)> getWizardsByHarryPotter(){
             var wizards = Wizard.Wizards.Value;
             
             return wizards.Where(w => w.Medium == "Harry Potter")
                           .Select(w => (w.Name, w.Year)).Distinct();
        }
        
        public static IEnumerable<(string, int?)> getWizardsByHarryPotterLinq() {
            var wizards = Wizard.Wizards.Value;

            var tuple = from w in wizards
                        where w.Medium == "Harry Potter"
                        select (w.Name, w.Year);

            return tuple.Distinct();
        }

        public static IEnumerable<string> getWizardsByCreaterOrdered(){
             var wizards = Wizard.Wizards.Value;
             
             return wizards.OrderByDescending(w => w.Creator)
                           .ThenBy(w => w.Name)
                           .Select(w => w.Name).Distinct();
        }

        public static IEnumerable<string> getWizardsByCreaterOrderedLinq(){
            var wizards = Wizard.Wizards.Value;
            var names = from w in wizards 
                        orderby w.Creator descending, w.Name ascending 
                        select w.Name;          
            
            return names.Distinct();
        }   
    }
}
