using System;
using System.Collections.Generic;


namespace CreateXMLWithNewEjudgeUsers
{
    class SchoolUser{

        private String name;        
        private String surname;
        private String email;
        private String schoolName;
        private String cityName;
        private bool found;

        public SchoolUser(String initialSurName,String initialName){

            this.name = initialName;
            this.surname = initialSurName;
            found = false;
        }


        public SchoolUser(String initialSurName, String initialName,String initialSchoolName,String initialCityName){

            this.name = initialName;
            this.surname = initialSurName;
            this.schoolName = initialSchoolName;
            this.cityName = initialCityName;

            found = false;
        }

         public SchoolUser(String initialName){
            this.name = initialName;
            this.surname = "No surname";
            found = false;
         }

        public String getName(){
            return this.name;
        }

        public String getSurname(){
            return this.surname;
        }

        public void setEmail(String newEmail){
            this.email = newEmail;
        }

        public void setSchoolName(String newSchoolName){
            this.schoolName = newSchoolName;
        }

        public String getEmail(){
            return this.email;
        }

        public String getSchoolName(){

            return this.schoolName;
        }

        public String printFullNameWithEmail(){
            return ("\"" + this.name + " " + this.surname + "\" " + "<" + this.email +">");
        }

        public bool getFound(){

            return this.found;
        }

        public void setFound(bool newFound){
            this.found = newFound;
        }

        public void setCityName(String newCityName) { 

            this.cityName = newCityName;
        }

        public String getCityName() {

            return this.cityName;
        }
    }
}

