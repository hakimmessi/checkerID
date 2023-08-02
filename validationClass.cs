using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkerID
{
    public class validationClass
    {
        #region method to verify if the user's input as an ID number is correct and in the right format.
        public bool isIDValid(string ID)
        {
            // check if the ID is null or empty or doesn't have exactly 13 characters.
            if (string.IsNullOrEmpty(ID) || ID.Length != 13)
            {
                // return false as the ID is invalid.
                return false; 
            }

            // extract different parts of the ID for further validation.
            string dateOfBirthPart = ID.Substring(0, 6); 
            string genderPart = ID.Substring(6, 4);
            char citizenshipStatus = ID[10];
            char randomDigit = ID[11];
            char checksumDigit = ID[12];

            // check the format of each part of the ID's number
            bool validDateOfBirth = int.TryParse(dateOfBirthPart, out _);
            bool validGender = int.TryParse(genderPart, out int genderNumber) && genderNumber >= 0 && genderNumber <= 9999;
            bool validCitizenshipStatus = citizenshipStatus == '0' || citizenshipStatus == '1';
            bool validRandomDigit = char.IsDigit(randomDigit);
            bool validChecksumDigit = char.IsDigit(checksumDigit);

            // return true only if all parts have the correct format
            return validDateOfBirth && validGender && validCitizenshipStatus && validRandomDigit && validChecksumDigit;
        }
        #endregion

        #region method to check if the user's input as a Passport number is in a valid format.

        #endregion

    }
}
