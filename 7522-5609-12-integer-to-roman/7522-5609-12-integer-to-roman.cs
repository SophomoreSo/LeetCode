public class Solution {
    public string ThousandsToRoman(int num){
        switch (num){
            case 1: return "M";
            case 2: return "MM";
            case 3: return "MMM";
            default: return "";
        }
    }
    public string HundredsToRoman(int num){
        switch (num){
            case 1: return "C";
            case 2: return "CC";
            case 3: return "CCC";
            case 4: return "CD";
            case 5: return "D";
            case 6: return "DC";
            case 7: return "DCC";
            case 8: return "DCCC";
            case 9: return "CM";
            default: return "";
        }
    }
    public string TenthsToRoman(int num){
        switch (num){
            case 1: return "X";
            case 2: return "XX";
            case 3: return "XXX";
            case 4: return "XL";
            case 5: return "L";
            case 6: return "LX";
            case 7: return "LXX";
            case 8: return "LXXX";
            case 9: return "XC";
            default: return "";
        }
    }
    public string OnesToRoman(int num){
        switch (num){
            case 1: return "I";
            case 2: return "II";
            case 3: return "III";
            case 4: return "IV";
            case 5: return "V";
            case 6: return "VI";
            case 7: return "VII";
            case 8: return "VIII";
            case 9: return "IX";
            default: return "";
        }
    }
    public string IntToRoman(int num) {
        int thousands   = (num % 10000) / 1000;
        int hundreds    = (num % 1000) / 100;
        int tenths      = (num % 100) / 10;
        int ones        = (num % 10) / 1;

        string result = "";

        result += ThousandsToRoman(thousands);
        result += HundredsToRoman(hundreds);
        result += TenthsToRoman(tenths);
        result += OnesToRoman(ones);

        return result;
    }
}