using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using LocalizeSpace;

public static class YarlNameGenerator {

	private static int yarlPart0Count = 10;
	private static int yarlPart1Count = 10;
	private static int yarlPart2Count = 10;

	public static string GenerateName(){
		//return 	Words.GetWords ("yarl_name_part_0_" + Random.Range (0, yarlPart0Count)) +
				//" " +
				//Words.GetWords ("yarl_name_part_1_" + Random.Range (0, yarlPart1Count)) +
				//" " +
				//Words.GetWords ("yarl_name_part_2_" + Random.Range (0, yarlPart2Count));
        return Localizator.Instance.GetWord("yarl_name_part_0_" + Random.Range(0, yarlPart0Count)) +
        " " +
               Localizator.Instance.GetWord("yarl_name_part_1_" + Random.Range(0, yarlPart1Count)) +
        " " +
               Localizator.Instance.GetWord("yarl_name_part_2_" + Random.Range(0, yarlPart2Count));
	}

}
