using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.IO;
using System.Text;

namespace CreateXMLWithNewEjudgeUsers
{
    class ProcessDataToXML
    {

        List<SchoolUser> namesFromCSV = new List<SchoolUser>();
        const char delim = ';';

        public String pathToXML = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + @"\files\userlist_part_schol_2012.xml";
        public String pathToCSV = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + @"\files\Очный_тур_весна_2012_школьники_списки.csv";
        public String pathToPrintFile = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + @"\files\Очный_тур_осень_2012_списки_школьники_для_распечатки.html";
        String OLYMPIAD_NAME = "Международная олимпиада по спортивному программированию среди учащихся 10-11 классов [Очный тур]";

        public int startEjudgeID;
        public int startLoginNumber;
        public String ejudgeLoginPrefix;
        public String CONTEST_ID = "13";
        

        const String defaultEmail = "v.dmitriyev@iitu.kz";
        const int MAX_PASSWORD_LENGTH = 8;


        public ProcessDataToXML() { 

        }

        /*
         * Parsing CSV from file with only names inside         
         */
        public void parseCSV()
        {

            using (StreamReader reader = new StreamReader(pathToCSV))
            {

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(delim);
                    string[] names = parts[1].Split(' ');
                    if (names.Length > 1)
                        this.namesFromCSV.Add(new SchoolUser(names[0], names[1]));
                    else
                        this.namesFromCSV.Add(new SchoolUser(names[0]));

                }

                foreach (SchoolUser su in namesFromCSV)
                {
                    Console.WriteLine(su.getName() + " " + su.getSurname());
                }
                reader.Close();
            }
        }


        /*
         * Parsing CSV from file with name+school_name+cityinside         
         */
        public void parseCSVWithShoolAndCity()
        {

            using (StreamReader reader = new StreamReader(pathToCSV))
            {

                string line;
                SchoolUser temp;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(delim);
                    string[] names = parts[0].Split(' ');
                    if (names.Length > 1)
                        temp = new SchoolUser(names[0], names[1]);
                    else
                        temp = new SchoolUser(names[0]);

                    temp.setSchoolName(parts[1]);
                    temp.setCityName(parts[2]);
                    this.namesFromCSV.Add(temp);
                }

                ///*
                foreach (SchoolUser su in namesFromCSV)
                {
                    Console.WriteLine(su.getName() + " " + su.getSurname() + " " + su.getSchoolName() + " " + su.getCityName());
                }
                //*/                
                reader.Close();
            }
        }

        /*
         * Without school and city
         */
        public void generateNewLogins()
        {
            
            int i = 0;

            foreach (SchoolUser su in namesFromCSV)
            {
                uppendToXml(formatLogin(ejudgeLoginPrefix, ((i++) + startLoginNumber), 3),
                            Utils.generateRundomPassword(MAX_PASSWORD_LENGTH),
                            startEjudgeID++,
                            i,
                            su
                 );
            }
        }

        /*
         * With school and city
         */
        public void generateNewLoginsWithSchoolAndCity()
        {
            /*
            int startEjudgeID = int.Parse(txtEjudgeStartID.Text);
            int startLoginNumber = int.Parse(txtEjudgeLoginStartNumber.Text);
            String ejudgeLoginPrefix = txtEjudgeLoginPrefix.Text;
             */
            int i = 0;

            foreach (SchoolUser su in namesFromCSV)
            {
                uppendToXmlWithShoolAndCity(
                            formatLogin(ejudgeLoginPrefix, ((i++) + startLoginNumber), 3),
                            Utils.generateRundomPassword(MAX_PASSWORD_LENGTH),
                            startEjudgeID++,
                            i,
                            su
                 );
            }
        }




        private String formatLogin(String loginPrefix, int number, int numberLength)
        {

            String result = loginPrefix;
            int count = 0;
            int numberTemp = number;

            while (numberTemp != 0)
            {
                count++;
                numberTemp /= 10;
            }

            for (int i = count + 1; i <= numberLength; i++)            
                result += "0";
            
            result += number;

            return result;
        }

        /*
         * Uppending to XML name of the contestant
         * 
         */
        private void uppendToXml(String login, String plainPass, int ejudgeID, int orderNumber, SchoolUser su)
        {

            if (!File.Exists(pathToXML))
            {
                StreamWriter swNew = File.CreateText(pathToXML);
                swNew.Close();
            }

            StreamWriter sw = File.AppendText(pathToXML);
            String output = "";


            output += "<user id=\"" + ejudgeID + "\" registered=\"2011/03/19 10:32:47\" last_login=\"2011/03/19 10:39:11\">\n";
            output += "<login public=\"no\">" + login + "</login>\n";
            output += "<password method=\"plain\">" + plainPass + "</password>\n";
            output += "<email public=\"no\">" + defaultEmail + "</email>\n";
            output += "<contests>\n";
            output += "\t<contest id=\"3\" status=\"ok\" date=\"2011/03/19 10:37:48\"/>\n";
            output += "</contests>\n";
            output += "<cntsinfos>\n";
            output += "\t<cntsinfo contest_id=\"3\" cnts_last_login=\"2011/03/19 10:39:11\" last_info_change=\"2011/03/19 10:38:16\">\n";
            output += "\t\t<name>" + su.getName() + " " + su.getSurname() + "</name>\n";
            output += "\t<contestants>\n";
            output += "\t<member serial=\"763\" create=\"2011/03/19 10:38:16\" last_change=\"2011/03/19 10:38:16\">\n";
            output += "\t\t<inst></inst>\n";
            output += "\t\t<surname>" + su.getSurname() + "</surname>\n";
            output += "\t\t<firstname>" + su.getName() + "</firstname>\n";
            output += "\t</member>\n";
            output += "\t</contestants>\n";
            output += "</cntsinfo>\n";
            output += "</cntsinfos>\n";
            output += "</user>\n";

            sw.Write(output);
            sw.Close();

            uppendPrintFile(login, plainPass, ejudgeID, orderNumber, su);
        }


        /*
         * Uppending to XML name+school_name+city of the contestant         
         */
        private void uppendToXmlWithShoolAndCity(String login,
            String plainPass,
            int ejudgeID,
            int orderNumber,
            SchoolUser su)
        {

            if (!File.Exists(pathToXML))
            {
                StreamWriter swNew = File.CreateText(pathToXML);
                swNew.Close();
            }

            StreamWriter sw = File.AppendText(pathToXML);
            String output = "";


            output += "<user id=\"" + ejudgeID + "\" registered=\"2012/04/20 00:00:00\" last_login=\"2012/04/20 01:00:00\">\n";
            output += "\t" + "<login public=\"no\">" + login + "</login>\n";
            output += "\t" + "<password method=\"plain\">" + plainPass + "</password>\n";
            output += "\t" + "<email public=\"no\">" + defaultEmail + "</email>\n";
            output += "\t" + "<contests>\n";
            output += "\t\t" + "<contest id=\"" + CONTEST_ID + "\" status=\"ok\" date=\"2012/04/21 02:00:00\"/>\n";
            output += "\t" + "</contests>\n";
            output += "\t" + "<cntsinfos>\n";
            output += "\t\t" + "<cntsinfo contest_id=\"" + CONTEST_ID  + "\" cnts_last_login=\"2012/04/21 02:00:00\" last_info_change=\"2012/04/21 02:00:00\">" + "\n";
            output += "\t\t\t" + "<name>" + su.getSurname() + " " + su.getName() + "</name>" + "\n";
            output += "\t\t\t" + "<inst>" + su.getSchoolName() + "</inst>" + "\n";
            output += "\t\t\t" + "<city>" + su.getCityName() + "</city>" + "\n";
            output += "\t\t" + "</cntsinfo>\n";
            output += "\t" + "</cntsinfos>\n";
            output += "</user>\n";

            sw.Write(output);
            sw.Close();

            uppendPrintFile(login, plainPass, ejudgeID, orderNumber, su);
        }


        private void uppendPrintFile(String login, String plainPass, int ejudgeID, int orderNumber, SchoolUser su)
        {

            if (!File.Exists(pathToPrintFile))
            {
                StreamWriter swNew = File.CreateText(pathToPrintFile);
                swNew.WriteLine("<meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\">");
                swNew.Close();
            }

            StreamWriter sw = File.AppendText(pathToPrintFile);

            

            sw.WriteLine("Имя участника: <span style=\"font-weight: bold; text-decoration: underline;\">"
                           + su.getSurname() + " " + su.getName() + "</span>" 
                           + " (" + su.getSchoolName() + " , " + su.getCityName() + ")" +
                          "<br /><br />");

            sw.WriteLine("Доступ на компьютер: <br />");
            sw.WriteLine("<div style=\"margin-left: 40px;\">1. Если компьютер не включен – включите его <br />");
            sw.WriteLine("2. Нажмите <span style=\"font-style: italic;\">Ctrl+Alt+Del </span><br style=\"font-style: italic;\" />");
            sw.WriteLine("3. Для доступа используйте следующее имя пользователя и пароль: <br />");
            sw.WriteLine("<div style=\"margin-left: 40px;\">Пользователь: <span style=\"font-weight: bold;\">IITU\\olymp </span><br />Пароль :<span style=\"font-weight: bold;\"> 123456789 </span><br /></div>");
            sw.WriteLine("4. Все что вам нужно для работы находиться в папке <span style=\"font-weight: bold;\">c:\\Olymp\\ </span><br />");
            sw.WriteLine("5. Рекомендуется все ваши файлы создавать исключительно на рабочем столе <br />");
            sw.WriteLine("6. <span style=\"font-weight: bold;\">Запрещается </span>пользоваться любыми цифровыми носителями<br /><br /></div>");
            sw.WriteLine("Доступ к системе проверки: <br />");
            sw.WriteLine("<div style=\"margin-left: 40px;\">");
            sw.WriteLine("1. Откройте любой браузер (IE,Firefox или Opera) <br />");
            sw.WriteLine("2. Перейдите по ссылке <span style=\"text-decoration: underline;\">http://acm.iitu.kz/</span>. <br />");
            sw.WriteLine("3. Зайдите на турнир “<span style=\"font-style: italic;\">" + OLYMPIAD_NAME + "</span>” <br />");
            sw.WriteLine("4. Для доступа используйте следующий логин и пароль: <br />");
            sw.WriteLine("<div style=\"margin-left: 40px;\">Логин: <span style=\"font-weight: bold;font-family:Consolas;\">" + login + "</span><br />");
            sw.WriteLine("Пароль: <span style=\"font-weight: bold;font-family:Consolas;\">" + plainPass + "</span> </div></div>");

            for (int i = 0; i < 31; i++)
                sw.Write("<br /> ");

            sw.Close();
        }
    }
}
