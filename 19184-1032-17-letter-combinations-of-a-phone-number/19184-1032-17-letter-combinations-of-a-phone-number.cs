public class Solution {

    IList<string> map_none = new List<string> {};
    IList<string> map_2 = new List<string> { "a", "b", "c" };
    IList<string> map_3 = new List<string> { "d", "e", "f" };
    IList<string> map_4 = new List<string> { "g", "h", "i" };
    IList<string> map_5 = new List<string> { "j", "k", "l" };
    IList<string> map_6 = new List<string> { "m", "n", "o" };
    IList<string> map_7 = new List<string> { "p", "q", "r", "s" };
    IList<string> map_8 = new List<string> { "t", "u", "v" };
    IList<string> map_9 = new List<string> { "w", "x", "y", "z" };

    public IList<string> GetMapping(char s){
        switch (s){
            case '2': return map_2;
            case '3': return map_3;
            case '4': return map_4;
            case '5': return map_5;
            case '6': return map_6;
            case '7': return map_7;
            case '8': return map_8;
            case '9': return map_9;
            default: return map_none;
        }
    }

    public IList<string> GetCombinationOne(IList<string> map1){
        return map1;
    }

    public IList<string> GetCombinationTwo(IList<string> map1, IList<string> map2){
        int len1 = map1.Count;
        int len2 = map2.Count;
        IList<string> result = new List<string>{};

        for(int i = 0; i < len1; i++){
            string c1 = map1[i];
            for(int j = 0; j < len2; j++){
                string c2 = map2[j];
                result.Add(c1 + c2);
            }
        }
        return result;
    }

    public IList<string> GetCombinationThree(IList<string> map1, IList<string> map2, IList<string> map3){
        int len1 = map1.Count;
        int len2 = map2.Count;
        int len3 = map3.Count;
        IList<string> result = new List<string>{};

        for(int i = 0; i < len1; i++){
            string c1 = map1[i];
            for(int j = 0; j < len2; j++){
                string c2 = map2[j];
                for(int k = 0; k < len3; k++){
                    string c3 = map3[k];
                    result.Add(c1 + c2 + c3);
                }
            }
        }
        return result;
    }

    public IList<string> GetCombinationFour(IList<string> map1, IList<string> map2, IList<string> map3, IList<string> map4){
        int len1 = map1.Count;
        int len2 = map2.Count;
        int len3 = map3.Count;
        int len4 = map4.Count;
        IList<string> result = new List<string>{};

        for(int i = 0; i < len1; i++){
            string c1 = map1[i];
            for(int j = 0; j < len2; j++){
                string c2 = map2[j];
                for(int k = 0; k < len3; k++){
                    string c3 = map3[k];
                    for(int l = 0; l < len4; l++){
                        string c4 = map4[l];
                        result.Add(c1 + c2 + c3 + c4);
                    }
                }
            }
        }
        return result;
    }

    public IList<string> LetterCombinations(string digits) {
        int len = digits.Length;

        switch (len){
            case 1:
                IList<string> map_1a = GetMapping(digits[0]);
                return GetCombinationOne(map_1a);

            case 2:
                IList<string> map_2a = GetMapping(digits[0]);
                IList<string> map_2b = GetMapping(digits[1]);
                return GetCombinationTwo(map_2a, map_2b);

            case 3:
                IList<string> map_3a = GetMapping(digits[0]);
                IList<string> map_3b = GetMapping(digits[1]);
                IList<string> map_3c = GetMapping(digits[2]);
                return GetCombinationThree(map_3a, map_3b, map_3c);

            case 4:
                IList<string> map_4a = GetMapping(digits[0]);
                IList<string> map_4b = GetMapping(digits[1]);
                IList<string> map_4c = GetMapping(digits[2]);
                IList<string> map_4d = GetMapping(digits[3]);
                return GetCombinationFour(map_4a, map_4b, map_4c, map_4d);

            default: return map_none;
        }
    }
}