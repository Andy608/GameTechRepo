using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class DemoTimelineController : MonoBehaviour {

	public PlayableDirector aDirector;
	public TimelineAsset aTimeline;

	void Update()
	{
		if(Input.GetKeyDown(KeyCode.Space))
			LaunchPlay();
	}

	void LaunchPlay()
	{
		aDirector.Play(aTimeline);
	}
}
