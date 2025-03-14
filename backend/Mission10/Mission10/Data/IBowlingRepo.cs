using Mission10.Models;

namespace Mission10.Data
{
    //Create bowling interface and bring in method from repo
    public interface IBowlingRepo
    {
        List<APIReturn> AllData();

    }

}
