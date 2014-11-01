using UnityEngine;
using System.Collections.Generic;

public class NewBehaviourScript : MonoBehaviour
{

  const string stringDots = "a1.1.2";

  void Start ()
  {
	DotsString ();
//	var ls1 = DotsString ();
//	var iEnd = ls1.Count;
//	for (int i1 = 0; i1 < iEnd; i0++)
//	{
//	  var s1 = string.Join ("/", ls1.GetRange (i1, iEnd - i1).ToArray ());
//	  print (s1);
//	  //			  tf1 = DotFind (tfRoot, s1);
//	  tf1 = _rootChapter.Find (s1);
//	  if (tf1)
//	  {
//		tfRoot = tf1;
//		break;
//	  }
//	}
  }

  protected internal List<string> DotsString ()
  {
	var lsDots = new List<string> ();
	var i0 = stringDots.IndexOf (".", System.StringComparison.Ordinal);
	do
	{
	  if (i0 == -1)
		break;
	  lsDots.Add (stringDots.Substring (0, i0));
	  i0 = stringDots.IndexOf (".", i0 + 1, System.StringComparison.Ordinal);
	} while(i0 > -1);
	lsDots.Add (stringDots);

	for (int i1 = 0; i1 < lsDots.Count; i1++)
	  print (i1 + " : " + string.Join ("/", lsDots.GetRange (i1, lsDots.Count - i1).ToArray ()));
	return lsDots;
  }
}