class Solution:
    def add(self, n):
        ret = 0
        while n > 0:
            ret += n % 10
            n //= 10
        
        return ret

    def countBalls(self, lowLimit, highLimit):
        d = {}
        for i in range(lowLimit, highLimit + 1):
            n = self.add(i)
            if n in d: d[n] += 1
            else: d[n] = 1
        
        m = 0
        for x in d:
            m = max(m, d[x])
        
        return m
