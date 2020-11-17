using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

manespace BettaTechAutocompleteSolution{

  class Program{
  
    public void main(string[] args){
      Console.WriteLine("Introducir texto: ");
      string text = Console.ReadLine();
      Console.WriteLine("Introducir prefijo: ");
      string prefix = Console.ReadLine();
       AutoCompleteWords(new List<string>(){ "Comida", "Comiendo", "Pedro", "Cocina", "Combo", "Nadar", "Caminando", "Comby"},"Com");
       AutoCompleteWords(text,prefix);
    }
    
    static IEnumerable AutoCompleteWords(string[] words, string prefix)
        {

            prefix = prefix.ToLower().Trim();
            List<string> autoCompletedWords = new List<string>();
            foreach (var word in words)
            {
                if (word.Length >= prefix.Length && prefix == word.ToLower().Trim().Substring(0, prefix.Length))
                {
                    autoCompletedWords.Add(word);
                }
            }
            return autoCompletedWords;
        }

        static IEnumerable AutoCompleteWords(string text, string prefix)
        {

            prefix = prefix.ToLower().Trim();
            List<string> words = text.Split(" ").ToList();
            List<string> autoCompletedWords = new List<string>();
            foreach (var word in words)
            {
                    if (word.Length >= prefix.Length && prefix == word.ToLower().Trim().Substring(0, prefix.Length))
                    {
                        autoCompletedWords.Add(word);
                    }
            }
            return autoCompletedWords;
        }
  }
}

