public class Solution {
    public int RomanToInt(string s) {

      var valorSimbolos = new Dictionary<char, int> {
            ['I'] = 1,
            ['V'] = 5,
            ['X'] = 10,
            ['L'] = 50,
            ['C'] = 100,
            ['D'] = 500,
            ['M'] = 1000
      };

      var resultado = 0;
      var valorPosterior = 0;

      for(int i = 0; i < s.Length; i++) {


          if(valorSimbolos.TryGetValue(s[i], out var valorAtual)) {

              if(i + 1 < s.Length) {
                  valorPosterior = valorSimbolos[s[i + 1]];
              }
            
              if(valorAtual < valorPosterior) 
              {
                  resultado -= valorAtual;
              }
              else if(valorAtual > valorPosterior)
              {
                  resultado += valorAtual;
              }
              else 
              {
                  resultado += valorAtual;
              }
          }
      }
        return resultado;
    }  
}
