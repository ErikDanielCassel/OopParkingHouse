using Microsoft.VisualBasic.Logging;
using System.Net.Http.Headers;
using static ParkingHus.Form1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace ParkingHus
{
    public partial class Form1 : Form
    {
        internal class ParkingSpot
        {
            public bool isCar = false; //Both are false if the parkingspot is empty
            public bool isMC = false;
            public string? reg = null;
            public string? reg2 = null; //Registration of the second MC if there is one.
            public DateTime dateParked = default;
            public DateTime dateParked2 = default; //The time the second MC parked if there is one.
        }
#pragma warning disable IDE0044

        static int parkingLotSize = 100;
        ParkingSpot[] parkingLot = new ParkingSpot[parkingLotSize]; //the whole parkinglot
        List<int> spotsWithOneMC = [];
        int numCars = 0;
        int numMC = 0;
        int numEmpty = parkingLotSize;
#pragma warning restore IDE0044
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < parkingLotSize; i++)
            {
                parkingLot[i] = new ParkingSpot();
            }
            UpdateGUI();
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            (int i, DateTime t, bool b) = FindVehicle(textBoxTools.Text);
            string text; //takes the data about the vehicle and puts it in text
            if (i != -1)
            {
                ParkingSpot spot = parkingLot[i];
                if (spot.reg != null)
                {
                    string vehicleType;
                    if (spot.isCar)
                    {
                        vehicleType = "Car";
                    }
                    else
                    {
                        vehicleType = "MC";
                    }

                    text = $"reg: {textBoxTools.Text}\n{vehicleType}\nParket: {spot.dateParked.ToShortDateString()} : {spot.dateParked.ToShortTimeString()}\nSpot: {i + 1}";
                }
                else
                {
                    text = $"reg: {textBoxTools.Text}\nMC\nParket: {spot.dateParked2.ToShortDateString()} : {spot.dateParked2.ToShortTimeString()}\nSpot: {i + 1}";
                }
                MessageBox.Show(text, "Search Result");
            }
        }
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            RemoveVehicle(textBoxTools.Text);
        }
        private void textBoxReg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) //Checks if enter is pressed in textbox
            {
                ButtonPark_Click(sender, e);
            }
        }

        private void ButtonPark_Click(object sender, EventArgs e)
        {

            if (OKToPark(textBoxReg.Text))
            {
                int lotIndex = Park(textBoxReg.Text, radioButtonMC.Checked);
                if (lotIndex == -1)
                {
                    MessageBox.Show("The parking lot is full");
                }
                else
                {
                    MessageBox.Show($"Park {textBoxReg.Text} at spot {lotIndex + 1}");
                }

            }

        }
        private void buttonPickUp_Click(object sender, EventArgs e)
        {
            (int i, TimeSpan time) = RemoveVehicle(textBoxReg.Text);
            if (i != -1)
            {
                MessageBox.Show($"Vehicle {textBoxReg.Text} was parked at lot {i + 1}\nIt has been parked for {time.Days} days, {time.Hours} hours and {time.Minutes} minutes");
            }
        }
        private void buttonMove_Click(object sender, EventArgs e)
        {
            (int i, DateTime tempdate, bool b) = FindVehicle(textBoxReg.Text);
            if (i != -1) //i is -1 if the vehicle isn't there
            {
                int newIndex = (int)(numericUpDownNewSpot.Value) - 1;

                if (newIndex != i) //makes sure we don't try to move it to its current spot
                {
                    ParkingSpot oldSpot = parkingLot[i];
                    bool isMC = oldSpot.isMC;
                    ParkingSpot newSpot = parkingLot[newIndex];
                    (int removedSpotIndex, TimeSpan t) = RemoveVehicle(textBoxReg.Text);

                    if (Park(textBoxReg.Text, isMC, newIndex) != -1) //puts the vehicle in the new spot
                    {
                        MessageBox.Show($"Moved {textBoxReg.Text} to spot {newIndex + 1} from spot {i + 1}");
                        if (newSpot.reg == textBoxReg.Text)//checks if the vehicle is sharing a spot with another one so we can give the right vehicle its original parking date back.
                        {
                            newSpot.dateParked = tempdate;
                        }
                        else
                        {
                            newSpot.dateParked2 = tempdate;
                        }
                    }
                    else
                    {
                        Park(textBoxReg.Text, isMC, removedSpotIndex); //Puts the vehicle back at the old spot if parking it att the new spot failed.
                        if (oldSpot.reg == textBoxReg.Text) //checks if the vehicle is sharing a spot with another one so we can give the right vehicle its original parking date back.
                        {
                            oldSpot.dateParked = tempdate;
                        }
                        else
                        {
                            oldSpot.dateParked2 = tempdate;
                        }
                        MessageBox.Show("Couldn't move the vehicle to that spot");
                    }
                }
                else
                {
                    MessageBox.Show("You can't move it to the same spot");
                } 
            }
            UpdateGUI();
        }

        private int Park(string reg, bool isMC, int spotIndex= -1)
        {
            //parks and returns the index of the spot, returns -1 if failed parking
            int i;
            if (isMC)
            {
                i = ParkMC(reg, spotIndex);
            }
            else
            {
                i = ParkCar(reg, spotIndex);
            }
            UpdateGUI();
            return i;

        }
        private int ParkMC(string reg, int spotIndex= -1)
        {
            if (spotIndex == -1)
            {
                if (spotsWithOneMC.Count != 0 &&
                    MessageBox.Show("Do you want to share spot with another motorcycle?", "Parking MC", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int lotIndex = spotsWithOneMC[0];
                    spotsWithOneMC.RemoveAt(0);
                    parkingLot[lotIndex].reg2 = reg;
                    parkingLot[lotIndex].dateParked2 = DateTime.Now;
                    numMC++;
                    return lotIndex;
                }
            }
            else if (spotsWithOneMC.Contains(spotIndex))
            {
                spotsWithOneMC.Remove(spotIndex);
                parkingLot[spotIndex].reg2 = reg;
                numMC++;
                return spotIndex;
            }
            //only runs if there is no lots with 1 MC or the user says no to sharing parking space.}
            int i = ParkOwnSpace(reg, true, spotIndex);
            if (i != -1)
            {
                numMC++;
            }
            return i;
        }
        private int ParkCar(string reg, int spotIndex = -1)
        {
            int i = ParkOwnSpace(reg, false, spotIndex);
            if (i != -1)
            {
                numCars++;
            }
            return i;
        }
        private int ParkOwnSpace(string reg, bool isMC, int spotIndex = -1)
        {
            //Loops over all parking spots and parks the car at the first empty spot and returns the index of the spot, returns -1 if no empty space
            if (spotIndex == -1)
            {
                for (int i = 0; i < parkingLotSize; i++)
                {
                    int value = parkSpot(reg, isMC, i);
                    if (value != -1)
                    {
                        return value;
                    }
                }
                return -1;
            }
            else
            {
                return parkSpot(reg, isMC, spotIndex);
            }

            int parkSpot(string reg, bool isMC, int i)
            {
                if (!(parkingLot[i].isCar || parkingLot[i].isMC))
                {
                    if (isMC)
                    {
                        parkingLot[i].isMC = true;
                        spotsWithOneMC.Add(i);
                    }
                    else
                    {
                        parkingLot[i].isCar = true;
                    }
                    parkingLot[i].reg = reg;
                    parkingLot[i].dateParked = DateTime.Now;
                    numEmpty--;
                    return i;

                }

                return -1;
            }
        }
        private bool OKToPark(string reg)
        //Validates if the registration is fully valid and the vehicle can be attemped to be parked.
        {
            if (CorrectReg(reg))
            {
                if (!parkingLot.Any(lot => reg == lot.reg || reg == lot.reg2)) //Checks for no duplicate registration numbers
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("The vehicle is already parked.", "Already parked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
      

        private (int, TimeSpan) RemoveVehicle(string reg, int Index = -1)
        {
            (int i, DateTime time, bool onSecondSpot) = FindVehicle(reg);
            if (i != -1) //Only try to remove vehicle if one was found
            {
                ParkingSpot parkingSpot = parkingLot[i];
                if (parkingSpot.isCar)
                {
                    numCars--;
                }
                else { numMC--; }
                if (onSecondSpot) //the found MC is on the second spot and sharing with another MC
                {
                    parkingSpot.reg2 = null;
                    parkingSpot.dateParked2 = default;
                    spotsWithOneMC.Add(i);
                }
                else if (parkingSpot.reg2 == null) //Vehicle is on the first spot and isn't sharing with another MC
                {
                    parkingSpot.reg = null;
                    parkingSpot.dateParked = default;
                    parkingSpot.isCar = false;
                    parkingSpot.isMC = false;
                    spotsWithOneMC.Remove(i);
                    numEmpty++;
                }
                else //MC is on the first spot and sharing spot with another MC. 
                {
                    parkingSpot.reg = parkingSpot.reg2; //The MC on the second spot gets moved to the first spot
                    parkingSpot.dateParked = parkingSpot.dateParked2;
                    parkingSpot.reg2 = null;
                    parkingSpot.dateParked2 = default;
                    spotsWithOneMC.Add(i); //Spot is made available for spot sharing.
                }
            }
            UpdateGUI();
            return (i, DateTime.Now - time);
        }
        private (int, DateTime, bool) FindVehicle(string reg) //bool is true if the found vehicle is in the second spot.
        {
            DateTime time = default;
            //return the index and time parked for registration in parkinglot or -1 and default timespan value if the reg isn't there
            if (CorrectReg(reg))
            {
                int i = Array.FindIndex(parkingLot, lot => reg == lot.reg);
                if (i == -1)
                {
                    i = Array.FindIndex(parkingLot, lot => reg == lot.reg2);
                    if (i == -1)
                    {
                        MessageBox.Show($"Vehicle {reg} is not parked here");
                        return (i, time, false);
                    }
                    time = parkingLot[i].dateParked2;
                    return (i, time, true);

                }
                else
                {
                    time = parkingLot[i].dateParked;
                    return (i, time, false);
                }
            }
            return (-1, time, false);
        }
        private static bool CorrectReg(string reg)
        {
            bool b = reg.Length == 6 && //checks if that there is no more text after the registration number
            char.IsAsciiLetter(reg[0]) && char.IsAsciiLetter(reg[1]) && char.IsAsciiLetter(reg[2]) && //Check if first 3 are letters
                char.IsNumber(reg[3]) && char.IsNumber(reg[4]) && char.IsNumber(reg[5]); //Checks if last 3 are numbers
            if (!b)
            {
                MessageBox.Show("Incorrect Registration number input.\nIt must be 3 letters and then 3 numbers and nothing else\nTry again",
                    "INPUT ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return b;
        }
        private void UpdateGUI()
        {
            UpdateListBoxUser();
            UpdateListBoxAdmin();
            UpdateDisplayNumbers();
        }
        private void UpdateListBoxUser()
        {
            listBoxUser.Items.Clear();
            for (int i = 0; i < parkingLotSize; i++)
            {
                ParkingSpot spot = parkingLot[i];
                if (spot.reg != null)
                {
                    string vehicleType;
                    if (spot.isCar)
                    {
                        vehicleType = "Car";
                    }
                    else
                    {
                        vehicleType = "MC";
                    }
                    listBoxUser.Items.Add($"{vehicleType}\t{spot.reg}");
                }
                if (spot.reg2 != null)
                {
                    listBoxUser.Items.Add($"MC\t{spot.reg2}");
                }
            }
        }
        private void UpdateListBoxAdmin()
        {
            listBoxAdmin.Items.Clear();
            for (int i = 0; i < parkingLotSize; i++)
            {
                ParkingSpot spot = parkingLot[i];
                if (spot.reg != null)
                {
                    string vehicleType;
                    if (spot.isCar)
                    {
                        vehicleType = "Car";
                    }
                    else
                    {
                        vehicleType = "MC";
                    }
                    listBoxAdmin.Items.Add($"{vehicleType}\t{spot.reg}\t{spot.dateParked.ToShortDateString()} : {spot.dateParked.ToLongTimeString()}\tSpot: {i + 1}");
                }
                if (spot.reg2 != null)
                {
                    listBoxAdmin.Items.Add($"MC\t{spot.reg2}\t{spot.dateParked2.ToShortDateString()} : {spot.dateParked2.ToLongTimeString()}\tSpot: {i + 1}");
                }
            }
        }
        private void UpdateDisplayNumbers()
        {
            textBoxCars.Text = numCars.ToString();
            textBoxMC.Text = numMC.ToString();
            textBoxEmpty.Text = numEmpty.ToString();
        }

    }
}