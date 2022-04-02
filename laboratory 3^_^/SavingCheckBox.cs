using System.IO;


namespace laboratory_3 {
    public class SavingCheckBox {
        public bool ReadCheckBox() {
            try {
                using (StreamReader file = new StreamReader("CheckBox.txt")) {
                    if (int.Parse(file.ReadLine()) == 1) {
                        return true;
                    }
                    file.Close();
                }
                return false;
            } catch (IOException) {
                using (FileStream file = new FileStream("CheckBox.txt", FileMode.Create)) {
                    StreamWriter fileWriter = new StreamWriter(file);
                    fileWriter.WriteLine(1);
                    fileWriter.Close();
                }
            }
            return true;
        }

        public void ChangeMessageBox(bool showAgain) {
            using (FileStream file = new FileStream("CheckBox.txt", FileMode.Open)) {
                StreamWriter fileWriter = new StreamWriter(file);

                if (showAgain) {
                    fileWriter.WriteLine(1);
                } else {
                    fileWriter.WriteLine(0);
                }
                fileWriter.Close();
            }

        }
    }
}


//public static void ChangeStartMessageFile(bool IsAgain, string filename) {
//    if (IsAgain) {
//        using StreamWriter file = new(filename, false); 
//        file.Write(1);
//    } else {
//        using StreamWriter file = new(filename, false); 
//        file.Write(0);
//    }
//}


//public static bool ReadStartMessageFile(string filename) {
//    using (StreamReader file = new(filename)) {
//        if (int.Parse(file.ReadLine()) == 1) {
//            return true;
//        }
//    }

//    return false;
//}

