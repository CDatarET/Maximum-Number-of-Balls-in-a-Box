class Solution {
    private int sum(int n){
        int ret = 0;
        while(n > 0){
            ret = ret + (n % 10);
            n = n / 10;
        }

        return(ret);
    }

    public int countBalls(int lowLimit, int highLimit) {
        HashMap<Integer, Integer> map = new HashMap<Integer, Integer>();
        for(int i = lowLimit; i <= highLimit; i++){
            int n = sum(i);
            map.put(n, map.getOrDefault(n, 0) + 1);
        }

        int max = 0;
        for(int i : map.keySet()){
            max = Math.max(max, map.get(i));
        }

        return(max);
    }
}
