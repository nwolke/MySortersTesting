# Sorting algorithm testing

## Purpose

I recently attempted to create the bubble sort algorithm on the fly, using only the knowledge of how it works and without any guidance.

It wrapped the general `for` loop into `while(true)` loop, incremented a counter to only count up to the next to last swapped value in the array (as the end of the array is slowly sorted first) and checked if the loop was already sorted, `break` the `while(true)` and move on. I believe this is O(nlogn);

I then went out to find how it's been accepted, in terms of interview questions, to test against my version.

I was surprised to find that the generally accepted algorithm, at least the threads I found on Stack Overflow, were typically O(n<sup>2</sup>):

```
int temp = 0;
for (int write = 0; write < arr.Length; write++) {
    for (int sort = 0; sort < arr.Length - 1; sort++) {
        if (arr[sort] > arr[sort + 1]) {
            temp = arr[sort + 1];
            arr[sort + 1] = arr[sort];
            arr[sort] = temp;
        }
    }
}
```
 Obviously this is odd. In comparison between the two, at especially larger (but reasonable for testing) ranges, say 100000, mine came in at 1 min while the much worse, but highly voted, answer was 1 min 30 seconds.

 I'm not saying I discovered something. I'm just wondering why it was so upvoted and accepted as the answer.

 Meh, anyways, it led me to decide to post this, and more that I do, up.

 Maybe someone will learn something from it. Or maybe someone will offer advice to making them better.
