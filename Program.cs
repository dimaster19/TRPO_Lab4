using System;

namespace TRPO_Lab4
{
     //1)  
        private void setMode(bool mod)
        {
            label1.Enabled = mod;
            button1.Enabled = mod;
            button2.Enabled = mod;
            button3.Enabled = !mod;
            button4.Enabled = !mod;
        }

    //2)  
        return m_driverStatusNames[driver.Status];
      
    //3)  
    uint i = ...;
        ... 
        if (i < 10)
        {
        ...
        }

    //4)  
    var sb = new StringBuilder();
    string destination = null;
    for (int i = 0; i < 13; i++)
    {
        sb += source[i];
    }
    destination = sb.ToString();

    //5)  
    bool IsNumber(string str)
    {
        try
        {
            int number = Convert.ToInt32(str);
            return true;
        }
        catch
        {
            return false;
        }
    }

    //6)  
    foreach (DirectoryInfo dir in dirs.GetDirectories())
    {
        //create folder{16}
        stream.Write(new byte[] { (byte)NetworkMessage.MakeDir }, 0, 1);
        stream.Read(new byte[1], 0, 1);
        stream.Write(BitConverter.GetBytes(Encoding.UTF8.GetBytes(SubFolder.Replace('\\', '/') + dir.Name.Replace('\\', '/')).Length), 0, 4);
        stream.Write(Encoding.UTF8.GetBytes(SubFolder.Replace('\\', '/') + dir.Name.Replace('\\', '/')), 0, Encoding.UTF8.GetBytes(SubFolder.Replace('\\', '/') + dir.Name.Replace('\\', '/')).Length);
        //send folder name
        stream.Read(new byte[1], 0, 1);//Ok
    }
   
    //7)  
    String[] days = new String[7]{"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday","Sunday"};

    //8)  
    Console.WriteLine($"--{DateTime.Now}--");

    //9)  
    return (Counter % 2 != 0);

    //10)  
    if (Connected == 0)
    {
        rez = setup();
    }
    fl_end = true;

    //11)  
    List<int> arr = new List<int>();
    for (int i = 0; i < arr.Count ; i++)
    {
        if (arr[i]<=100)
        arr.RemoveAt(i);
    }

    //12)  
    var ids = form.Keys;
    if (ids.Length != 1)
    {
        throw Exception;
    }

    //13)  
    string[] nameParts = customer.Name.Split(' ');
    string firstName = nameParts[0];
    string lastName = nameParts[1];

    //14)  
    sourceId = Convert.ToInt32(sourceIDs.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)[0]);
    //15)  
    public string generateEMail()
    {
        string eMail = PersonName.Replace(' ', '.');
        if (eMail.Length > 20)
        {
            eMail = eMail.Substring(0, 20);
        }
        eMail += "@domain.ua";
        return eMail;
    }

    //16)  
    sourceId = Convert.ToInt32(sourceIDs.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)[0]);

    //17)  


    //18)  
    private static readonly char SPECIFIER = '$';
    private static readonly char DELIMITER = ':';
    private static readonly char DELIMITER_ARRAY =  DELIMITER;

    //19)  
    string mailTo = ((Config.GetSetting("AdminNotifications_EmailAddress").Length <= 0)) ? "Something went wrong" : Config.GetSetting("AdminNotifications_EmailAddress");

    //20)  
    public bool CheckPath(string path)
    {
        static readonly string[] Dirs = new string[] { "SCLAD", "REAL", "DOSTAVKA" };
        static readonly string[] Files = new string[] { "analit.dbf", "partner.dbf", "SCLAD\\mdoc.dbf".."DOSTAVKA\\zamena.dbf" };

        public bool CheckPath(string path)
        {
            //Проверяем наличие нужных папок;
            foreach (string s in Dirs)
                if (!Directory.Exists(path + s)) return false;

            //Проверяем наличие нужных файлов
            foreach (string s in Files)
                if (!File.Exists(path + s)) return false;

            return true;
        }
    }
    //21)  
    txtContacts.Text = String.Join(";", contacts);

    //22)  
    Game1.clou = !Game1.clou;

}
