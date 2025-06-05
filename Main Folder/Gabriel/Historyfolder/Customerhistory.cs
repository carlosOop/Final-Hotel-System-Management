public class CustomerHistory
{
	public string Name { get; set; }
	public int RoomNumber { get; set; }
	public string RoomType { get; set; }
	public string Bed { get; set; }
	public string Price { get; set; }
	public string MobileNo { get; set; }
	public string Nationality { get; set; }
	public string Gender { get; set; }
	public string Address { get; set; }
	public DateTime DateOfBirth { get; set; }
	public DateTime InDate { get; set; }
	public DateTime OutDate { get; set; }
	public string Status { get; set; } // e.g., "InHotel", "CheckedOut"
}
