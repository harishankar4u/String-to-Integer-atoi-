String to Integer (atoi)

Implement the myAtoi(string s) function, which converts a string into a 32-bit signed integer.

Algorithm Steps

1. Whitespace → Ignore any leading whitespace (" ").

2. Signedness →

If the next character is '-', the result is negative.

If the next character is '+', the result is positive.

If neither is present, assume positive.

3. Conversion →

Read characters until a non-digit is found or the end of the string is reached.

Convert those digits into an integer.

If no digits are read, return 0.

4. Clamping → The result must fit inside the 32-bit signed integer range:

[-2^31, 2^31 - 1] → [-2147483648, 2147483647]


If the number is less than -2^31, return -2147483648.

If the number is greater than 2^31 - 1, return 2147483647.

5. Return → Apply the sign and return the final integer.

Examples

Example 1

Input: "42"

Output: 42

Explanation: No spaces, no sign. Digits read → 42.

Example 2

Input: " -042"

Output: -42

Explanation: Skip spaces → sign = '-' → negative → digits = 042 → 42 → result = -42.

Example 3

Input: "1337c0d3"

Output: 1337

Explanation: Digits read = 1337, stop at 'c'.

Example 4

Input: "0-1"

Output: 0

Explanation: First digit = 0, stop at '-'.

Example 5

Input: "words and 987"

Output: 0

Explanation: First character 'w' is invalid → return 0.

Constraints

0 <= s.Length <= 200

The string may contain:

English letters (A–Z, a–z)

Digits (0–9)

Whitespace (' ')

Plus ('+')

Minus ('-')

Period ('.')
