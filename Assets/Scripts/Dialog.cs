using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog : MonoBehaviour {

	public static string[] playerDialog = new string[] {

				"", //wait for dad's dialog

		"[1] Yep.\n" +
		"[2] It's gorgeous.\n" +
		"[3] I'm glad we came.",

				"", //wait for dad's dialog

				"", //wait for dad's dialog

		"[1] She's good.\n" +
		"[2] Home is home.\n" +
		"[3] Y'know.",

				"", //wait for dad's dialog

				"", //wait for dad's dialog

				"", //wait for dad's dialog

				"", //wait for dad's dialog

				"", //wait for dad's dialog

		"[1] You say that all the time.\n" +
		"[2] I know.\n" +
		"[3] Okay?",

				"", //wait for dad's dialog

				"", //wait for dad's dialog

				"", //wait for dad's dialog

				"", //wait for dad's dialog

		"[1] Wow.\n" +
		"[2] That's something else.\n" +
		"[3] No wonder you guys broke up.",

				"", //wait for dad's dialog

				"", //wait for dad's dialog

				"", //wait for dad's dialog

				"", //wait for dad's dialog

				"", //wait for dad's dialog

				"", //wait for dad's dialog

				"", //wait for dad's dialog

				"", //wait for dad's dialog

				"", //wait for dad's dialog

				"", //wait for dad's dialog

				"", //wait for dad's dialog

				"", //wait for dad's dialog

				"", //wait for dad's dialog

				"", //wait for dad's dialog

				"", //wait for dad's dialog

		"[1] Well... yeah.\n" +
		"[2] Those were different times back then.\n" +
		"[3] You didn't do a bad job.",

				"", //wait for dad's dialog

		"[1] You were talking about mom.\n" +
		"[2] Your divorce.\n" +
		"[3] Talking to your parents.",

				"", //wait for dad's dialog

				"", //wait for dad's dialog

				"", //wait for dad's dialog

				"", //wait for dad's dialog

				"", //wait for dad's dialog

				"", //wait for dad's dialog

				"", //wait for dad's dialog

		"[1] It's not that hard.\n" +
		"[2] Yeah, I guess you're right.\n" +
		"[3] I manage.",

				"", //wait for dad's dialog

				"", //wait for dad's dialog

				"", //wait for dad's dialog

				"", //wait for dad's dialog

				"", //wait for dad's dialog

				"", //wait for dad's dialog

				"", //wait for dad's dialog

		"[1] Yeah.\n" +
		"[2] I don't remember.\n" +
		"[3] ...",

				"", //wait for dad's dialog

				"", //wait for dad's dialog

				"", //wait for dad's dialog

		"[1] Dad...\n" +
		"[2] Look...\n" +
		"[3] I...",

				"", //wait for dad's dialog

		"[1] I don't like being caught between you two.\n" +
		"[2] Can we talk about something else?\n" +
		"[3] I just don't want to talk about this. Sorry.",

				"", //wait for dad's dialog

				"", //wait for dad's dialog

				"", //wait for dad's dialog

		"[1] ...\n" +
		"[2] ...\n" +
		"[3] ...",

				"", //wait for dad's dialog

				"", //wait for dad's dialog

				"", //wait for dad's dialog

				"", //wait for dad's dialog

				"", //wait for dad's dialog

				"", //wait for dad's dialog

				"", //wait for dad's dialog

				"", //wait for dad's dialog

				"" //end

	};



	public static string[] dadDialog = new string[] {

		"It’s real nice out here.",

				"", //wait for player input

		"...",

		"So how’s it going at home? How’s your mother?",

				"", //wait for player input

		"I know she can be a bit much sometimes, huh?",

		"...",

		"I know it can be tough living with her. Ha ha.",

		"She’s a very, uh... strong-tempered woman. Hard to get along with her sometimes.",

		"But listen, you know, I respect your mother very much. She’s very smart.",

				"", //wait for player input

		"I’m just saying. I mean, of course you know that. What I mean is, I want what’s best for you.",

		"When your mother and I were dating, she was off-the-walls practically all day and night.",

		"I remember one time, about a year before we divorced, we were having some big argument. Who knows what it was even about.",

		"But she was so mad, that after we went to sleep, she woke up just to start yelling at me again! Ha ha ha.",

				"", //wait for player input

		"Yeah, seriously.",

		"And of course, I have my faults too. But your mother was a real fighter.",

		"I mean, jeez.",

		"Y’know, it was a really long, drawn-out process when we got divorced. But it wasn’t the legal stuff, it was everything else.",

		"I talked to my parents about it plenty – because, as you know, I tell ‘em everything.",

		"I said, \"You know I’m not sure if this is gonna work out, blah blah blah.\" ",

		"\"I feel bad for Beckett. I don’t know what to do.\" You were two at the time, I think.",

		"Of course, my mother never once thought highly of your mother. So this... didn’t surprise her.",

		"But the real deal-breaker was when my father took me aside, and he said to me:",

		"\"This isn’t healthy. Staying together will only make things worse.\"",

		"And that’s when I knew.",

		"I always listen to everything my father says, because he’s a very wise man.",

		"I could always go to him with any problem I had, and he’d always have an answer.",

		"He made me a hard-worker too. When I wanted something as a kid, he made a deal that if I worked to pay for half, he’d pay the rest.",

		"Seems I kind of messed that one up with my own kids. Ha ha.",

				"", //wait for player input

		"Anyway, uh... what was I saying?",

				"", //wait for player input

		"Right, right.",

		"That’s all I wanted to say I think. Just that I care about you, and that I worry about how you and your mother get along.",

		"...",

		"I just think, sometimes, that she’s probably fucked you up in a lot of ways. To be blunt.",

		"The things she’s probably said to you, and the thing’s I know she’s done...",

		"I love – well, loved – your mother, but trust me, I know how she is.",

		"So I know it’s hard for you too.",

				"", //wait for player input
			
		"Women can be a bit, uh, tricky sometimes. Ha ha ha.",

		"...",

		"We must be coming to the end of the trail soon.",

		"...",

		"I’ve talked to my parents and my friends endlessly about it, and they all agree that your mother was being unreasonable.",

		"I feel like she kept you from me for a while. And that’s just not right.",

		"You know how, when you were a kid, I saw you once a week or so? What was it, Wednesdays?",

				"", //wait for player input

		"I was supposed to see you more often. There was an agreed upon plan that we made in court, but your mother never really followed it.",

		"And I let her get away with that.",

		"I could easily take her back to court, and I’ve thought about it quite a few times over the years, but of course I’m not going to.",

				"", //wait for player input

		"Yeah?",

				"", //wait for player input

		"Right, I know. I'm sorry. I shouldn't be saying this stuff.",

		"But I'm just telling you all this so you know, I guess.",

		"And I'm sure your mother has said her fair share of bad shit about me.",

				"", //wait for player input

		"But I guess it’s important to hear, because you’re old enough. I don’t know.",

		"...",

		"I’m just saying that your mother hasn’t been the best–",

		"Pff, who am I kidding? You already know this. Sorry for yakkin’ your ear off. Ha ha.",

		"I hope I haven’t, y’know, messed you up or anything.",

		"...",

		"But know that... I love you very much.",

		"And you’ll always be my son.",

				"" //end

	};

}