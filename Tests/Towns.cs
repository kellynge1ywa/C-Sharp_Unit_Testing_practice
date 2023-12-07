namespace Tests;

public class Towns
{
    public List<string> TownNames=new List<string>();

    public void AddTown(string TownName){
        if(string.IsNullOrWhiteSpace(TownName)){
            throw new ArgumentNullException("Please add town name");
        }
        TownNames.Add(TownName);
    }

}
