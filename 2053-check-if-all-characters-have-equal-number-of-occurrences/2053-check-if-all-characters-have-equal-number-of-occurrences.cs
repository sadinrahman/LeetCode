public class Solution {
    public bool AreOccurrencesEqual(string s) {
        var groupedCharacters = s.GroupBy(c => c)
                                 .Select(g => new { Character = g.Key
                                 , Count = g.Count() }).ToList();
        bool allSame = groupedCharacters
        .All(g => g.Count == groupedCharacters.First().Count);
         return allSame;
    }
}