public class Solution {
    public string ConvertDateToBinary(string date) {
        DateTime Date = DateTime.Parse(date);
        string binaryYear = Convert.ToString(Date.Year, 2);
        string binaryMonth=Convert.ToString(Date.Month,2);
        string binaryDay = Convert.ToString(Date.Day, 2);
        string ans=$"{binaryYear}-{binaryMonth}-{binaryDay}";
        return ans;
    }
}