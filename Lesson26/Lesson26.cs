using System;

class Lesson26{
    static void Main(){
        int dd, dr, qt, rt; // dd = dividend | dr = devider | qt = quotient | rt = rest
        dd = 10;
        dr = 3;
        qt = divide(dd, dr, out rt);
        Console.WriteLine("{0}/{1}: quotient = {2} and rest = {3}", dd, dr, qt, rt);

    }

    static int divide(int dividend, int divider, out int rest) {
        int quotient;
        quotient = dividend / divider;
        rest = dividend % divider;
        return quotient;
    }
}