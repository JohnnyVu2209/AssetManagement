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
  return axiosInstance.get(`${Asset}/all`, {
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

const getCategories = () => {
  return axiosInstance.get(`${Asset}/getCategories`);
}
const getStates = () => {
  return axiosInstance.get(`${Asset}/getStates`);
}

const assetService = {
  getAssetList,
  getCategories,
  getStates
}

export default assetService;


