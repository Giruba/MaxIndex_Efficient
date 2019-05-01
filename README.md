# MaxIndex_Efficient
C# program to print the maximum index [j-i] such that element at j is greater than element at i

Logic
-----
1. Construct two arrays, LeftMinHolders[], RightMaxHolders[] 

   1.a one capturing the minElement between the current array element and the previous min element

   1.b second capturing the maxElement between the current array element and the next max element

2. Iterate over both the arrays until arraylength such that
   
   2.a If LeftMinHodlers[i] < RightMaxHolders[j], calculate
          maxDiff = Max(maxDiff, j-i)
   
      2.a.1 Increment j as we have to check whether this left is still less than the next greater element
   
   2.b If LeftMinHolders[i] > RightMaxHolders[j]
   
      2.b.1 Increment i as we have to check whether left element is still greater than the right element

3. Print maxDiff
      
  
