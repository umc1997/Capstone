using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterPanel : MonoBehaviour
{
	public List<Transform> panelList;
	int idx;

	public void acticePanel()
	{
		idx = CharacterSwitch.idx;
		for(int i=0; i<panelList.Count; i++)
		{
			panelList[i].gameObject.SetActive(i==idx);
		}
	}
}
