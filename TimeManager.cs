using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager {
	private static int prevLaunchYear{
		get{
//			return PlayerPrefs.GetInt ("prevLaunchYear", System.DateTime.Now.Year);
			return FileBasedPrefs.GetInt ("prevLaunchYear", System.DateTime.Now.Year);
		}
		set{ 
//			PlayerPrefs.SetInt ("prevLaunchYear", value);
			FileBasedPrefs.SetInt ("prevLaunchYear", value);
		}
	}

	private static int prevLaunchMonth{
		get{
//			return PlayerPrefs.GetInt ("prevLaunchMonth", System.DateTime.Now.Month);
			return FileBasedPrefs.GetInt ("prevLaunchMonth", System.DateTime.Now.Month);
		}
		set{ 
//			PlayerPrefs.SetInt ("prevLaunchMonth", value);
			FileBasedPrefs.SetInt ("prevLaunchMonth", value);

		}
	}

	private static int prevLaunchDay{
		get{
//			return PlayerPrefs.GetInt ("prevLaunchDay", System.DateTime.Now.Day);
			return FileBasedPrefs.GetInt ("prevLaunchDay", System.DateTime.Now.Day);
		}
		set{ 
//			PlayerPrefs.SetInt ("prevLaunchDay", value);
			FileBasedPrefs.SetInt ("prevLaunchDay", value);
		}
	}

	private static int prevLaunchHour{
		get{
//			return PlayerPrefs.GetInt ("prevLaunchHour", System.DateTime.Now.Hour);
			return FileBasedPrefs.GetInt ("prevLaunchHour", System.DateTime.Now.Hour);
		}
		set{ 
//			PlayerPrefs.SetInt ("prevLaunchHour", value);
			FileBasedPrefs.SetInt ("prevLaunchHour", value);
		}
	}

	private static int prevLaunchMinute{
		get{
//			return PlayerPrefs.GetInt ("prevLaunchMinute", System.DateTime.Now.Minute);
			return FileBasedPrefs.GetInt ("prevLaunchMinute", System.DateTime.Now.Minute);
		}
		set{ 
//			PlayerPrefs.SetInt ("prevLaunchMinute", value);
			FileBasedPrefs.SetInt ("prevLaunchMinute", value);
		}
	}

	private static int prevLaunchSecond{
		get{
//			return PlayerPrefs.GetInt ("prevLaunchSecond", System.DateTime.Now.Second);
			return FileBasedPrefs.GetInt ("prevLaunchSecond", System.DateTime.Now.Second);
		}
		set{ 
//			PlayerPrefs.SetInt ("prevLaunchSecond", value);
			FileBasedPrefs.SetInt ("prevLaunchSecond", value);
		}
	}


	public static void SaveLaunchTime(){
//		Debug.Log ("SAVELAUNCHTIME");
//		PlayerPrefs.SetInt ("prevLaunchYear", System.DateTime.Now.Year);
//		PlayerPrefs.SetInt ("prevLaunchMonth", System.DateTime.Now.Month);
//		PlayerPrefs.SetInt ("prevLaunchDay", System.DateTime.Now.Day);
//		PlayerPrefs.SetInt ("prevLaunchHour", System.DateTime.Now.Hour);
//		PlayerPrefs.SetInt ("prevLaunchMinute", System.DateTime.Now.Minute);
//		PlayerPrefs.SetInt ("prevLaunchSecond", System.DateTime.Now.Second);
		FileBasedPrefs.SetInt ("prevLaunchYear", System.DateTime.Now.Year);
		FileBasedPrefs.SetInt ("prevLaunchMonth", System.DateTime.Now.Month);
		FileBasedPrefs.SetInt ("prevLaunchDay", System.DateTime.Now.Day);
		FileBasedPrefs.SetInt ("prevLaunchHour", System.DateTime.Now.Hour);
		FileBasedPrefs.SetInt ("prevLaunchMinute", System.DateTime.Now.Minute);
		FileBasedPrefs.SetInt ("prevLaunchSecond", System.DateTime.Now.Second);
	}

	public static int PassedTimeInSeconds(){
		int passedTime = System.DateTime.Now.Second - prevLaunchSecond;
		passedTime += (System.DateTime.Now.Minute - prevLaunchMinute) * 60;
		passedTime += (System.DateTime.Now.Hour - prevLaunchHour)     * 60 * 60;
		passedTime += (System.DateTime.Now.Day - prevLaunchDay)       * 60 * 60 * 24;
		passedTime += (System.DateTime.Now.Month - prevLaunchMonth)   * 60 * 60 * 24 * 30;
		passedTime += (System.DateTime.Now.Year - prevLaunchYear)     * 60 * 60 * 24 * 30 * 12;
		return passedTime;
	}

	public static void DeletePrefs(){
		FileBasedPrefs.SetInt ("prevLaunchYear", System.DateTime.Now.Year);
		FileBasedPrefs.SetInt ("prevLaunchMonth", System.DateTime.Now.Month);
		FileBasedPrefs.SetInt ("prevLaunchDay", System.DateTime.Now.Day);
		FileBasedPrefs.SetInt ("prevLaunchHour", System.DateTime.Now.Hour);
		FileBasedPrefs.SetInt ("prevLaunchMinute", System.DateTime.Now.Minute);
		FileBasedPrefs.SetInt ("prevLaunchSecond", System.DateTime.Now.Second);
	}
}
