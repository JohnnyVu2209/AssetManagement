import axios from 'axios';
import React from 'react'
import axiosInstance from '../axiosInstance'

var qs = require('qs');

const Asset = "Asset";

const getAssetList = (
    pageNumber:number, 
    pageSize: number, 
    orderBy: string, 
    searching: string,
    state: number[],
    category: number[]) => {
  return axiosInstance.get(`${Asset}/getAssetsList`, {
    params:{
        pageNumber,
        pageSize,
        orderBy,
        searching,
        state,
        category
    },
    paramsSerializer: params => {
      return qs.stringify(params)
    }
  })
}

const getAsset = (id: number) => {
  return axiosInstance.get(`Asset/Detail/${id}`);
}

const getAssetListBySearch = (pageNumber: number,searching: string, orderBy: string) => {
  return axiosInstance.get(`${Asset}/getAssetsList`,{
    params:{
      pageNumber,
      searching,
      orderBy,
      pageSize:5,
      state:[2]
    },
    paramsSerializer: params => {
      return qs.stringify(params)
    }
  })
};
const getAssetBySearch = (searching: string) => {
  return axiosInstance.get(`${Asset}/getAssetsList`,{
    params:{
      searching
    },
    paramsSerializer: params => {
      return qs.stringify(params)
    }
  })
};

const getCategories = () => {
  return axiosInstance.get(`${Asset}/getCategories`);
}
const getStates = () => {
  return axiosInstance.get(`${Asset}/getStates`);
}

const assetService = {
  getAssetList,
  getCategories,
  getStates,
  getAsset,
  getAssetListBySearch,
  getAssetBySearch
}

export default assetService;


