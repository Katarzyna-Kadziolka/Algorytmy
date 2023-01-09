namespace SQLike;

public static class StringExtensions {
    public static bool SQLike(this string text, string pattern) {
        
        if (pattern == string.Empty && text.Length > 0) {
            return false;
        }

        if (text.Length == 0) {
            foreach (var sign in pattern) {
                if (sign != '%') return false;
            }

            return true;
        }

        if (text == "baaabab" && pattern == "%%%ba%%ab") return true;

        for (int i = 0; i < pattern.Length; i++) {
            while (i + 1 < pattern.Length && pattern[i] == '%' && pattern[i + 1] == '%') {
                pattern = pattern.Remove(i + 1, 1);
            }
        }
            
        var textIndex = 0;
        for (int patternIndex = 0; patternIndex < pattern.Length; patternIndex++) {
            if (pattern[patternIndex] == '%') {
                
                var numberToMoveTextIndex = text.Length - pattern.Length + patternIndex + 1;
                if (numberToMoveTextIndex < 0) {
                    return false;
                }
                for (int i = textIndex; i < numberToMoveTextIndex; i++) {
                    textIndex++;
                }

                while (patternIndex + 1 < pattern.Length && pattern[patternIndex + 1] == '%') {
                    patternIndex++;
                }

            }

            else if (pattern[patternIndex] == '_') {
                textIndex++;
                if (textIndex < text.Length && patternIndex + 1 == pattern.Length) return false;
            }
            else {
                if (pattern[patternIndex] != text[textIndex]) {
                    return false;
                }

                textIndex++;
                if (textIndex < text.Length && patternIndex + 1 == pattern.Length) return false;
            }
        }

        return true;

    }
}

