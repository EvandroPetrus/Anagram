class Program {  
    public class Anagram {  
        public bool areAnagram(string firstString, string secondString) {  
            if (firstString.Length != secondString.Length) {  
                return false;  
            }  
            //Convert string to character array  
            char[] firstCharsArray = firstString.ToLower().ToCharArray();  
            char[] secondCharsArray = secondString.ToLower().ToCharArray();  
            //Sort array  
            Array.Sort(firstCharsArray);  
            Array.Sort(secondCharsArray);  
            //Check each character and position.  
            for (int i = 0; i < firstCharsArray.Length; i++) {  
                if (firstCharsArray[i].ToString() != secondCharsArray[i].ToString()) {  
                    return false;  
                }  
            }  
            return true;  
        }  
    }  
    static void Main(string[] args) {  
        string firstString, secondString;  
       

        Console.WriteLine("Enter first string");  
        firstString = Console.ReadLine();  
        Console.WriteLine("Enter second string");  
        secondString = Console.ReadLine();  
        
        // Creating new object Anagram
        Anagram anagram = new Anagram();  
        
        //Check if words are anagram  
        if (anagram.areAnagram(firstString, secondString) == true) {  
            Console.WriteLine("Both inputs are anagrams.");  
        } else {  
            Console.WriteLine("Both inputs are not anagrams of each other.");  
        }  
        Console.ReadLine();  
    }  
}  