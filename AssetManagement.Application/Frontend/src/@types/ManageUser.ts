export type manageUserTypeContext = {
    Data: Array<string>;
    sortModel:Array<string>;
    Keyword:string|null, 
    Type:Array<string>|null;
    SortBy:string|null;
    Ascending:boolean|null;
    Limit: number|null;
    Page: number|null ;
    handleChangeSearching:()=>void;
    goSearching:()=>void;
    getPagination:()=>void;
}

