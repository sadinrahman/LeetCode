public class Solution {
    public int FinalPositionOfSnake(int n, IList<string> commands) {
        int res=0;
        for(int i=0;i<commands.Count;i++){
            if(commands[i]=="DOWN"){
                res+=n;
            }else if(commands[i]=="UP"){
                res-=n;
            }else if(commands[i]=="RIGHT"){
                res+=1;
            }else if(commands[i]=="LEFT"){
                res-=1;
            }
        }
        return res;
    }
}