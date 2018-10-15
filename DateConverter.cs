using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public static class DateConverter {

    public static string CurrentDateString {
        get {
            return System.DateTime.Now.Day + "." + System.DateTime.Now.Month + "." + System.DateTime.Now.Year;
        }
    }

    public static void ParseDateString(string dataStr, out int[] date) {
        date = new int[3];
        int counter = 0;
        int beginning = 0;
        for (int i = 0; i < dataStr.Length; i++) {
            if (dataStr[i] == '.') {
                int.TryParse(dataStr.Substring(beginning, i - beginning), out date[counter]);
                beginning = i + 1;
                counter++;
            }
        }
        int.TryParse(dataStr.Substring(beginning, dataStr.Length - beginning), out date[counter]);
    }

    public static bool WasTwoWeeksPassed(int[] lastDate) {
        if (lastDate.Length != 3) {
            return false;
        }
        return ((System.DateTime.Now.Day - lastDate[0]) + ((System.DateTime.Now.Month - lastDate[1]) + (System.DateTime.Now.Year - lastDate[2]) * 12) * 30) > 14;
    }

    public static bool WasTwoWeeksPassed(string lastDateString) {
        int[] lastDate = new int[3];
        ParseDateString(lastDateString, out lastDate);
        return WasTwoWeeksPassed(lastDate);  
    }
}
