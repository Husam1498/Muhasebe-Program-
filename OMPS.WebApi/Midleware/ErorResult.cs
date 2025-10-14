using Newtonsoft.Json;

namespace OMPS.WebApi.Midleware
{
    public class ErorResult:ErorStatusCode
    {
        public string Message { get; set; }          
    }

    public class ErorStatusCode
    {
        public int StatusCode { get; set; }
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }

    public class  ValidationErorsDetails: ErorStatusCode
    {
        public IEnumerable<string> Erors { get; set; }       
    }

}
