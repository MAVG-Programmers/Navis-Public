function OnMouseDown()
{

    if (this.name == "PlayBT")    
    {
		audio.Play();
        Application.LoadLevel("Test");
    }

    if (this.name == "HelpBT")
    {    
		audio.Play();
        Application.LoadLevel("help");
    }
     
	if (this.name == "BackBT") 
	{
		audio.Play();
        Application.LoadLevel("menu");
    }
      
    if (this.name == "QuitBT")
    {
		audio.Play();
        Application.Quit();
    }
}