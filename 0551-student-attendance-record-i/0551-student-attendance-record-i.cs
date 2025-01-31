public class Solution {
    public bool CheckRecord(string s) {
        
        int absent=0;
        int late=0;
        for(int i=0;i<s.Length;i++){
            if(s[i]=='A'){
                absent++;
                if(absent>1){
           return false;
        }
            }
            if(s[i]=='L'){
                late++;
                if (late >= 3) return false; 
            } else {
                late = 0; 
            }
            }
        
        return true;
    }
}