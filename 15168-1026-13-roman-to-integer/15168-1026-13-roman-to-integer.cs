public class Solution {
    // One char input
    public int CharToInt(char c){
        switch (c) {
            case 'I': return 1;
            case 'V': return 5;
            case 'X': return 10;
            case 'L': return 50;
            case 'C': return 100;
            case 'D': return 500;
            case 'M': return 1000;
            default: return -1;
        }
    }

    // Two chars input
    public int TwoCharsToint(char c1, char c2){
        if (c1 == 'I'){
            if (c2 == 'V'){
                return 4;
            }
            else if (c2 == 'X'){
                return 9;
            }
        }
        else if (c1 == 'X'){
            if (c2 == 'L'){
                return 40;
            }
            else if (c2 == 'C'){
                return 90;
            }
        }
        else if (c1 == 'C'){
            if (c2 == 'D'){
                return 400;
            }
            else if (c2 == 'M'){
                return 900;
            }
        }
        return -1;
    }

    public int RomanToInt(string s) {
        int result = 0;
        bool two_char_activated = false;
        int len = s.Length;
        // One loop and it is done!
        for (int i = 0; i < len; i++){
            if(two_char_activated){
                two_char_activated = false;
                continue;
            }

            if (i == len - 1){
                result += CharToInt(s[i]);
                break;
            }

            int two_char_int = TwoCharsToint(s[i], s[i + 1]);
            if(two_char_int == -1){
                result += CharToInt(s[i]);
            }
            else {
                result += two_char_int;
                two_char_activated = true;
            }
        }
        return result;
    }
}