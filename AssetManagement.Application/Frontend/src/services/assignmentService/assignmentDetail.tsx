import axiosInstance from "../axiosInstance";

function getFormattedDate(date: Date) {
    var year = date.getFullYear();

    var month = (1 + date.getMonth()).toString();
    month = month.length > 1 ? month : '0' + month;

    var day = date.getDate().toString();
    day = day.length > 1 ? day : '0' + day;

    return month + '/' + day + '/' + year;
}

const getAssignmentById = async (id: number)=>{
    await axiosInstance.get(`Assignment/${id}`)
        .then((res) => {
          console.log("show data: ",res.data)
            // Handle date format
            const assignedDate = new Date(res.data.assignedDate)
            res.data.assignedDate = getFormattedDate(assignedDate)
            return res.data
        })
        .catch((error) => {
            console.log("errorr: " + error)
        });
} //not use

export default getAssignmentById;
