import axios from "axios";
import { UserDetailType } from "../../@types/UserDetail";

function getFormattedDate(date: Date) {
    var year = date.getFullYear();

    var month = (1 + date.getMonth()).toString();
    month = month.length > 1 ? month : '0' + month;

    var day = date.getDate().toString();
    day = day.length > 1 ? day : '0' + day;

    return month + '/' + day + '/' + year;
}

async function getUserDetail(path: string) {
    return await axios.get<UserDetailType>(path)
        .then((res) => {
            console.log(res.data)

            // Handle date format
            const dateOfBirth = new Date(res.data.dateOfBirth)
            res.data.dateOfBirth = getFormattedDate(dateOfBirth)
            const joinedDate = new Date(res.data.joinedDate)
            res.data.joinedDate = getFormattedDate(joinedDate)

            return res.data
        })
        .catch((error) => {
            console.log(error)
            return null
        });
}

export default getUserDetail
