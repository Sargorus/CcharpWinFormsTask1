namespace CcharpWinFormsTask1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // считывем значения из настроек
            textBoxHourArrivalTrain.Text = Properties.Settings.Default.arrivalHour.ToString();
            textBoxMinuteArrivalTrain.Text = Properties.Settings.Default.arrivalMinute.ToString();

            textBoxDepartureHourTrain.Text = Properties.Settings.Default.departureHour.ToString();
            textBoxDepartureMinuteTrain.Text = Properties.Settings.Default.departureMinute.ToString();

            textBoxPassengerHour.Text = Properties.Settings.Default.passengerHour.ToString();
            textBoxPassengerMinute.Text = Properties.Settings.Default.passengerMinute.ToString();

        }


        public class Logic
        {
            public static string CompareTrainInStation(int arrivalHour, int arrivalMinute, int departureHour, int departureMinute, int passengerHour, int passengerMinute)
            {
                int timeArrive = arrivalHour * 60 + arrivalMinute;
                int timeDeparture = departureHour * 60 + departureMinute;
                int timePassenger = passengerHour * 60 + passengerMinute;

                if (timeArrive >= timeDeparture) // Нужно сдлеать так, чтобы в 11 вчерера пришел поезд (прошлого дня), а уходит в 2 часа утра, а я пришел в полность (до 2 часов), то я успел и поезд на станции.
                {
                    if ((timePassenger <= 24 * 60 && timePassenger >= timeArrive) || (timePassenger >= 0 && timePassenger <= timeDeparture) )
                    {
                        return "Поезд находится на станции";
                    }

                    /*
                    if (timePassenger <= timeDeparture && timePassenger <= 24*60 || timePassenger)
                    {
                        return "Поезд находится на станции";
                    }
                    */
                    return "Поезд не находится на станции";
                }

                if (timePassenger < timeDeparture && timePassenger > timeArrive)
                {
                    return "Поезд находится на станции";
                }
                else
                {
                    return "Поезд не находится на станции";
                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {


            int arrivalHour, arrivalMinute;
            int departureHour, departureMinute;
            int passengerHour, passengerMinute;
            string resultMSG;



            try
            {


                arrivalHour = int.Parse(this.textBoxHourArrivalTrain.Text);
                arrivalMinute = int.Parse(this.textBoxMinuteArrivalTrain.Text);

                departureHour = int.Parse(this.textBoxDepartureHourTrain.Text);
                departureMinute = int.Parse(this.textBoxDepartureMinuteTrain.Text);


                passengerHour = int.Parse(this.textBoxPassengerHour.Text);
                passengerMinute = int.Parse(this.textBoxPassengerMinute.Text);

            }
            catch (FormatException)
            {
                return;
            }

            //  передаем введенные значения в параметры
            Properties.Settings.Default.arrivalHour = arrivalHour;
            Properties.Settings.Default.arrivalMinute = arrivalMinute;

            Properties.Settings.Default.departureHour = departureHour;
            Properties.Settings.Default.departureMinute = departureMinute;

            Properties.Settings.Default.passengerHour = passengerHour;
            Properties.Settings.Default.passengerMinute = passengerMinute;


            Properties.Settings.Default.Save(); // сохраняем переданные значения, чтобы они восстановились пре очередном запуске


            resultMSG = Logic.CompareTrainInStation(arrivalHour, arrivalMinute, departureHour, departureMinute, passengerHour, passengerMinute);

            // MessageBox.Show("Ура работает! (╯°□°）╯︵ ┻━┻", resultMSG);
            MessageBox.Show($"(╯°□°）╯︵ ┻━┻ {resultMSG}");

        }

    }
}
