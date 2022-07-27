import axios from "axios";

async function getPaginationImpl(Keyword:string|null, 
  Type:Array<string>|null, SortBy:string|null, 
  Ascending:boolean|null, Limit: number|null, Page: number|null )
{
  /* var object = {
    Keyword: Keyword,
  } */
  var result =  await axios.get("api/Users",{params:{Keyword,Type,SortBy,Ascending,Limit,Page}});
  console.log(result);
  return result;
    /* .then((response) => {
        return response;
    })
    .catch((error) => console.log(error)); */
}

export { getPaginationImpl };
