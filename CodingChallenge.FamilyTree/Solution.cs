using System;
using System.Collections.Generic;

namespace CodingChallenge.FamilyTree
{
    public class Solution
    {
        // Kind of hacky, only goes down two levels
        public string GetBirthMonth(Person person, string descendantName)
        {
            string[] months = new string[12] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            Person currentParent = person;

            if (currentParent.Name == descendantName)
            {
                return months[currentParent.Birthday.Month - 1];
            }

            foreach (Person child in currentParent.Descendants)
            {
                if (child.Name == descendantName)
                {
                    return months[child.Birthday.Month - 1];
                }

                if (child.Descendants.Count != 0)
                {
                    foreach (Person grandchild in child.Descendants)
                    {
                        if (grandchild.Name == descendantName)
                        {
                            return months[grandchild.Birthday.Month - 1];
                        }
                    }
                }
            }

            return "";
        }
    }
}