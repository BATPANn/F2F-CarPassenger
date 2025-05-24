using Palmmedia.ReportGenerator.Core.Reporting.Builders;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class F2FCarpassangerCamInteract : MonoBehaviour
{


    public Text Subtext;
    private string holder;
    private float texttypetime = 0.025f;


    private bool CanInteract = true;


    // dialouge

    public GameObject TalkPanel;

    public Text InteractionText;

    // dialouge

    // Update is called once per frame
    void Update()
    {


        if(CanInteract == true)
        {


            Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {

                if (hit.collider.CompareTag("Friend"))
                {


                    InteractionText.text = "Talk To Alex";

                    if (Input.GetKeyDown(KeyCode.E))
                    {


                        StartCoroutine(TalkToAlexCO());


                    }


                }
                else
                {


                    InteractionText.text = "";

                }
                


            }
            else
            {


                InteractionText.text = "";

            }





        }


        
    }



    IEnumerator TalkToAlexCO()
    {

        CanInteract = false;
        InteractionText.text = "";
        TalkPanel.SetActive(true);

        Subtext.text = "Me: ";
        holder = "Are you Ok Alex ?";
        foreach(char c in holder)
        {


            Subtext.text += c;
            yield return new WaitForSeconds(texttypetime);

        }


        yield return new WaitForSeconds(1.5f);

        Subtext.text = "Alex: ";
        holder = "Yeah, Im fine";
        foreach (char c in holder)
        {


            Subtext.text += c;
            yield return new WaitForSeconds(texttypetime);

        }

        yield return new WaitForSeconds(1.5f);

        Subtext.text = "";
        CanInteract = true;
        TalkPanel.SetActive(false);




    }


}
