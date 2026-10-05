public class Solution {
    public bool IsPalindrome(int x) {

        // var Unidade = x % 10; // 1 // 2
        // var Dezena = (x % 100) - Unidade; // 20 // 50
        // var Centena = (x % 1000) - (Dezena + Unidade); // 100 // 700

        // var UnidadeCent = Unidade * 100;
        // var CentenaUnid = Centena / 100;

        // 9876 % 10 = 6
        //  9876 / 10 = 987

        var reverseXunid = 0;
        var original = x;
        while(x > 0) {

            var ultimoDigito = x % 10;
            reverseXunid = reverseXunid * 10 + ultimoDigito;
            x /= 10;
        }

        if(original == reverseXunid) {
            return true;
        }

        return false;
    }
}
