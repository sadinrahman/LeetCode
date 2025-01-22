public class Solution {
    public int DayOfYear(string date) {
        int dayOfYear=0;
        if (DateTime.TryParse(date,out DateTime _date))
        {
             dayOfYear = _date.DayOfYear;
        }
        return dayOfYear;
    }
}