import React, { createContext, useState } from 'react';
import { manageUserTypeContext } from '../@types/ManageUser';
import { getUserSorting } from '../services/userService/sortUser';
import { getPaginationImpl } from '../services/userService/userInfo';

export const ManageUserContext = createContext<manageUserTypeContext | null>(null);

const ManageUserProvider : React.FC<React.PropsWithChildren> = ({children}) => {

    const [filterContent, setFilterContent] = useState({
        type: [] as number[],
      });
    const options = [1, 2];
    const [selected, setSelected] = useState([] as number[]);

    const [sortModel, setSortModel] = useState([]/* [{field: 'staffCode',sort: 'asc'}] */);
    const [Keyword, setKeyword] = useState("");
    
    const [Type, setType] = useState([]);
    const [SortBy, setSortBy] = useState("");
    const [Ascending, setAscending] = useState(null);
    const [Limit, setLimit] = useState(null);
    const [Page, setPage] = useState(null);
    const [Data, setData] = useState([]);

    
    const isAllSelected =
    options.length > 0 && selected.length === options.length;
    
    function getPagination(){
        getPaginationImpl(Keyword,Type,SortBy,Ascending,Limit,Page).then((res) => {
            setData(res.data.items);
            console.log(res.data.items);
        }).catch((err) => console.log(err))
    }

    function handleChangeSearching(){
        let keywordinput = document.getElementById("input-searching") as HTMLInputElement;
        if(keywordinput)
        setKeyword(keywordinput.value) ;
        setFilterContent({ ...filterContent});
      }
    
      function goSearching(){
        getUserSorting(Keyword).then((res) => {
            setData(res.data.items);
            console.log(res.data.items);
        }).catch((err) => console.log(err))
      }

    return (
        <ManageUserContext.Provider value={{
            Data,
            sortModel,
            Keyword,
            Type,
            SortBy,
            Ascending,
            Limit,
            Page,
            handleChangeSearching,
            goSearching,
            getPagination,
        }}>
            {children}
        </ManageUserContext.Provider>
    );
}

export default ManageUserProvider;
