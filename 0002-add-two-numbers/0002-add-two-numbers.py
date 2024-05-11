# Definition for singly-linked list.
class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next

class Solution:
    def addTwoNumbers(self, l1: Optional[ListNode], l2: Optional[ListNode]) -> Optional[ListNode]:
        carry_one = False
        
        temp = l1.val + l2.val
        if temp >= 10:
            temp -= 10
            carry_one = True

        root_node = ListNode(temp, None)
        current_node = root_node
        l1 = l1.next
        l2 = l2.next

        while l1 is not None and l2 is not None:
            temp = l1.val + l2.val
            if carry_one:
                temp += 1
                carry_one = False
            if temp >= 10:
                temp -= 10
                carry_one = True
            temp_node = ListNode(temp, None)
            current_node.next = temp_node
            current_node = temp_node
            l1 = l1.next
            l2 = l2.next

        # Case 1: l1 and l2 have the same length
        if l1 is None and l2 is None:
            if carry_one:
                node = ListNode(1, None)
                current_node.next = node
            return root_node
        
        # Case 2: l1 has larger length than l2
        if l1 is not None and l2 is None:
            while l1 is not None:
                temp = l1.val
                if carry_one:
                    temp += 1
                    carry_one = False
                if temp >= 10:
                    temp -= 10
                    carry_one = True
                temp_node = ListNode(temp, None)
                current_node.next = temp_node
                l1 = l1.next
                current_node = temp_node
            if carry_one:
                node = ListNode(1, None)
                current_node.next = node
            return root_node
        
        # Case 3: l2 has larger length than l1
        if l1 is None and l2 is not None:
            while l2 is not None:
                temp = l2.val
                if carry_one:
                    temp += 1
                    carry_one = False
                if temp >= 10:
                    temp -= 10
                    carry_one = True
                temp_node = ListNode(temp, None)
                current_node.next = temp_node
                l2 = l2.next
                current_node = temp_node
            if carry_one:
                node = ListNode(1, None)
                current_node.next = node
            return root_node