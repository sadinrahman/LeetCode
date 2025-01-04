public class Solution {
    public int CountEven(int num) {
        int count=0;
        for(int i=1;i<=num;i++){
            if(i%2==0 && i<10){
                count++;
                Console.WriteLine(i);
            }
            if(i>10 && CalculateDigitSum(i)%2==0){
                count++;
            }
        }
        return count;
    }
     int CalculateDigitSum(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            sum += number % 10; 
            number /= 10;       
        }
        return sum; 
    }
}