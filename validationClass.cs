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
        public bool isPassportNoValid(string passportNumber)
        {
            // check if the passport number has exactly 9 characters.
            if (passportNumber.Length != 9)
            {
                return false; // return false as the passport number is invalid.
            }

            // check if the first character is a letter and the rest are digits.
            if (!char.IsLetter(passportNumber[0]))
            {
                return false; // return false as the passport number is invalid.
            }

            // check if all characters from index 1 to end are digits.
            for (int i = 1; i < passportNumber.Length; i++)
            {
                if (!char.IsDigit(passportNumber[i]))
                {
                    return false; // return false as the passport number is invalid.
                }
            }

            return true; // return true if the passport number is valid.
        }
        #endregion

        #region method to check if the given vaccination number is in a valid format.
        public bool isVaccinationNoValid(int vaccinationNo)
        {
            bool valid = false;

            // check if the vaccination number has exactly 5 digits.
            if (vaccinationNo == 5 && int.TryParse(Console.ReadLine(), out vaccinationNo))
            {
                valid = true; // if the vaccination number has exactly 5 digits, set the 'valid' variable to true.
            }

            return valid; // return the value of 'valid' (true if the vaccination number is valid, false otherwise).
        }
        #endregion
    }
}
