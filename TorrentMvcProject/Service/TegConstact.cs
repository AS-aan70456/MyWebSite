using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TorrentMvcProject.Service{
    public static class TegConstact{

        public static string TegsCorrect(string input) {
            return input.Trim();
        }

        public static string[] TegsToStringArrey(string input) {
            return input.Split('/');
        }

        public static bool CheckMatches(string[] tegs, string teg) {
            for (int i = 0; i < tegs.Length; i++)
                if (tegs[i] == teg) return true;
            return false;
        }
    }
}
