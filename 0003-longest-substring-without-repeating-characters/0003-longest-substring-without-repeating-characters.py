# s consists of English letters, digits, symbols and spaces.
# There are finite number of characters, so O(1)?

# the time complexity from the hint provided is O(nlogn) wtf?
# we can achieve O(n) by following

# get a char and an index pair, make them unique

class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:
        # python set uses hash table
        str_length = len(s)
        unique_set = set()
        base_index = 0
        i = 0
        max_len = 0
        while i < str_length:
            current_char = s[i]
            if current_char in unique_set:
                
                unique_set = set()
                for j in range(base_index, i):
                    dup_char = s[j]
                    if current_char == dup_char:
                        base_index = j + 1
                        i = base_index
                        break
            
            unique_set.add(s[i])
            i += 1
            max_len = max(max_len, i - base_index)
        return max_len