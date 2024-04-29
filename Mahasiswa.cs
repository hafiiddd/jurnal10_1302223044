namespace jurnal10_1302223044
{
    public class Mahasiswa
    {
        public string Nama { get; set; }

        public string Nim { get; set; }

        public List<String> course{ get; set; }

        public int Year { get; set; }

        public Mahasiswa(string nama, string nim,List<string> course, int year) { 
            this.Nama = nama;
            this.Nim = nim; 
            this.course = course;
            this.Year = year;
        }
    }
}
