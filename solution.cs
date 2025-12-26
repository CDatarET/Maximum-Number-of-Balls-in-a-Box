public class Solution {
    private int sum(int n){
        int ret = 0;
        while(n > 0){
            ret = ret + (n % 10);
            n = n / 10;
        }

        return(ret);
    }

    public int CountBalls(int lowLimit, int highLimit) {
        Dictionary<int, int> d = new Dictionary<int, int>();
        for(int i = lowLimit; i <= highLimit; i++){
            int n = sum(i);
            if(d.ContainsKey(n)){
                d[n]++;
            }
            else{
                d[n] = 1;
            }
        }

        int max = 0;
        foreach(var key in d.Keys){
            max = Math.Max(max, d[key]);
        }

        return(max);
    }
}
