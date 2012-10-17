using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreateXMLWithNewEjudgeUsers
{
    static class Utils
    {
        static Random random = new Random();

          public static String generateRundomPassword(int MAX_PASSWORD_LENGTH){
            
		    int randInt = 0;
		    String newPassword = "";
		    String nextSymbol = "";
		    
		    for (int j = 0 ; j < MAX_PASSWORD_LENGTH; j++){
			    randInt = random.Next(3);	

			    if (randInt == 0){
				    nextSymbol = random.Next(10).ToString();
			    }			
			    if (randInt == 1){
                    nextSymbol = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65))).ToString();
			    }
			    if (randInt == 2){
				    nextSymbol = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 97))).ToString();
			    }
			    newPassword+=nextSymbol;
		    }

		    return newPassword;

        }
    }
}
