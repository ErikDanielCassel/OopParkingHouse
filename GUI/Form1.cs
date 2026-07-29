using CentralLogic;
using DataAccess;

namespace GUI
{
    public partial class Form1 : Form
    {
        ParkingHouse parkingHouse; //The whole parking garage.
        List<Vehicle> vehicleTemplates = Initalizer.ReadVehicleConfigurationData();
        CzkPerHour czkPerHour = Initalizer.ReadCzkPerHours();
        public Form1()
        {
            InitializeComponent();
            parkingHouse = Initalizer.StartUp();
            foreach (var vehicleType in vehicleTemplates)
            {
                listBoxPickVehicleType.Items.Add(vehicleType.KindOfVehicle);
            }
            numericUpDownNewSpot.Maximum = Initalizer.ReadParkingHouseSize();
            Save.ParkingHouse(parkingHouse);
            UpdateGUI();
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string regNum = textBoxReg.Text;
            try
            {
                int i = parkingHouse.FindVehicle(regNum);
                MessageBox.Show($"Fordon {regNum} är parkerad på plats {i + 1}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            string regNum = textBoxReg.Text;
            string? vehicleType = (string?)listBoxPickVehicleType.SelectedItem;
            if (vehicleType != null)
            {
                try
                {
                    parkingHouse.Park(regNum, vehicleType, vehicleTemplates);
                    MessageBox.Show($"Parkerade {regNum} på plats {parkingHouse.FindVehicle(regNum) + 1}");
                    Save.ParkingHouse(parkingHouse);
                    UpdateGUI();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

            else
            {
                MessageBox.Show("Du behöver välja en fordons typ.");
            }


        }
        private void buttonPickUp_Click(object sender, EventArgs e)
        {
            string regNum = textBoxReg.Text;
            try
            {
                Vehicle vehicle = parkingHouse.PickUp(regNum);
                TimeSpan spanTimeParked = DateTime.Now - vehicle.TimeParked;
                TimeSpan effectivTimeParked = spanTimeParked - TimeSpan.FromMinutes(czkPerHour.FreeMinuits);
                int hourlyRate;
                switch (vehicle.KindOfVehicle)
                {
                    //Add cases as you add more kinds of vehicle to the config files.
                    case "Car":
                        {
                            hourlyRate = czkPerHour.Car;
                            break;
                        }
                    case "MC":
                        {
                            hourlyRate = czkPerHour.MC;
                            break;
                        }
                    default:
                        {
                            hourlyRate = czkPerHour.Car;
                            break;
                        }
                }

                decimal price = Math.Max((Decimal)effectivTimeParked.TotalHours, 0M) * hourlyRate;
                MessageBox.Show($"Hämtade {regNum}. Parkeringen kostade {price} Czk.");
                Save.ParkingHouse(parkingHouse);
                UpdateGUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonMove_Click(object sender, EventArgs e)
        {
            string regNum = textBoxReg.Text;
            int spot = (int)numericUpDownNewSpot.Value;
            try
            {
                parkingHouse.MoveVehicle(regNum, (int)spot - 1);
                MessageBox.Show($"Flyttade {regNum} till plats {spot}");
                Save.ParkingHouse(parkingHouse);
                UpdateGUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void buttonReloadPrices_Click(object sender, EventArgs e)
        {
            czkPerHour = Initalizer.ReadCzkPerHours();
        }
        private void UpdateGUI()
        {
            UpdateTreeViewMap();
        }
        private void UpdateTreeViewMap()
        {
            treeViewMap.Nodes.Clear();
            int spotNum = 1;
            foreach (ParkingSpot parkingSpot in parkingHouse.ParkingSpots)
            {
                var parkingSpotNode = new TreeNode(spotNum.ToString());
                foreach (var vehicle in parkingSpot.ParkedVehicles)
                {
                    var vehicleNode = new TreeNode(vehicle.KindOfVehicle + ": " + vehicle.RegNum.ToString());
                    parkingSpotNode.Nodes.Add(vehicleNode);
                }

                treeViewMap.Nodes.Add(parkingSpotNode);
                spotNum++;
            }
            treeViewMap.ExpandAll();
        }

    }
}