using Constants = WinFrom_FF.Helpers.Constants;

namespace WinFrom_FF.Helpers
{
    public class SoundProvider
    {
        //
        //Sound types
        //

        public const string Correct = "Correct";
        public const string Wrong = "Wrong";

        //
        //Play sound
        //
        static Dictionary<string, string> soundContainer = new()
        {
            {Correct, "C:\\Desktop\\University\\3-cü kurs\\1-ci semestr\\Müasir proq. dilləri- Amin M\\FF\\Fayllar\\mixkit-correct-answer-tone-2870.wav" },
            {Wrong, "C:\\Desktop\\University\\3-cü kurs\\1-ci semestr\\Müasir proq. dilləri- Amin M\\FF\\Fayllar\\mixkit-wrong-long-buzzer-954.wav" }
        };

        public static string PlaySound(string sound) => soundContainer.FirstOrDefault(s=>s.Key == sound).Value??"";
   
    }
}
