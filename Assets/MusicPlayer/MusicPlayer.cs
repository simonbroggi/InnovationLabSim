using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

	public AudioSource[] audioSources;
	
	public int audioPlayingIndex = -1;
	private int lastAudioIndex = -1;

	void Update () {
		if(audioPlayingIndex >= 0 && audioPlayingIndex < audioSources.Length) {
			if(audioPlayingIndex != lastAudioIndex) {
				foreach(AudioSource audioSource in audioSources) {
					audioSource.volume = 0f;
				}
				audioSources[audioPlayingIndex].volume = 1f;
			}
		}
	}
}
