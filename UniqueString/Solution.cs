namespace UniqueString{
    public class Solution{
       //brute force solution approach - 1
        public bool CheckStringBruteForce(string str){
            for(int i=0; i<str.Length; i++){
                for(int j = i+1; j<str.Length; j++){
                    if(str[i] == str[j]){
                        return false;
                    }
                }
            }
            return true;
        }
        //sorting solution approach - 2
        public bool CheckStringSorting(string str){
            char[] charArray = str.ToCharArray();
            for(int i = 0; i<charArray.Length - 1; i++){
                if(charArray[i] != charArray[i+1]){
                    continue;
                }else{
                    return false;
                }
            }
            return true;
        }
    }
}
