using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace Mehmonxona
{
    public partial class MainWindow : Window
    {
        private HotelManagementSystem hotelSystem;

        public MainWindow()
        {
            InitializeComponent();
            hotelSystem = new HotelManagementSystem();
        }

        private void BtnAddRoom_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateRoomInput())
            {
                int roomId = int.Parse(txtRoomId.Text);
                int howManyParts = int.Parse(txtHowManyParts.Text);
                decimal price = decimal.Parse(txtPrice.Text);

                Room room = new Room(roomId, howManyParts, price);
                hotelSystem.AddRoom(room);
                MessageBox.Show("Xona Muvaffaqiyatli Qo'shildi!");
            }
            else
            {
                MessageBox.Show("Xonaning Ma'lumotlari to'liq kiritilmadi");
            }
        }

        private void BtnBookRoom_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateRoomInput())
            {
                int roomId = int.Parse(txtRoomId.Text);
                hotelSystem.BookRoom(roomId);

                MessageBox.Show("Xona muvaffaqiyatli buyurtma qilindi!");
            }
            else
            {
                MessageBox.Show("Xonaning ma'lumotlari to'liq kiritilmadi");
            }
            
        }

        private void BtnAddUser_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateUserInput())
            {
                string name = txtName.Text;
                int age = int.Parse(txtAge.Text);
                string passportId = txtPassportId.Text;

                User user = new User(name, age, passportId);
                hotelSystem.AddUser(user);
                MessageBox.Show("Foydalanuvchi Muvaffaqiyatli qo'shildi!");
            }
            else
            {
                MessageBox.Show("Foydalanuvchi ma'lumotari to'liq kiritilmadi");
            }
        }

        private void BtnGetAllRooms_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var room in hotelSystem.GetAllRooms())
            {
                sb.AppendLine($"Room ID: {room.RoomId},  Parts: {room.HowManyParts}, Price: {room.Price}");
            }
            MessageBox.Show(sb.ToString(), "All Rooms:");
        }

        private void BtnGetAllUsers_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var user in hotelSystem.GetAllUsers())
            {
                sb.AppendLine($"Name: {user.Name}, Age: {user.Age}, Passport ID: {user.PassportId}");
            }
            MessageBox.Show(sb.ToString(), "All Users:");
        }

        private bool ValidateRoomInput()
        {
            return !string.IsNullOrWhiteSpace(txtRoomId.Text)
                && !string.IsNullOrWhiteSpace(txtHowManyParts.Text)
                && !string.IsNullOrWhiteSpace(txtPrice.Text);
        }

        private bool ValidateUserInput()
        {
            return !string.IsNullOrWhiteSpace(txtName.Text)
                && !string.IsNullOrWhiteSpace(txtAge.Text)
                && !string.IsNullOrWhiteSpace(txtPassportId.Text);
        }

    }
}