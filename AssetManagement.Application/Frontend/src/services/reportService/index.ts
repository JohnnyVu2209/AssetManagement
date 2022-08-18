import axiosInstance from "../axiosInstance"


const getReport = () => {
    return axiosInstance.get("Report");
}

const reportService = {
    getReport
}

export default reportService;