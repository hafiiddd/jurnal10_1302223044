using Microsoft.AspNetCore.Mvc;

namespace jurnal10_1302223044.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MahasiswaController : ControllerBase
    {
        private static List<String> course = new List<string>
        {
            "KPL","PBO","ALPRO"
        };
        private static List<Mahasiswa> mahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa("Hafid AlAkhyar","1302223044",course,2019),
            new Mahasiswa("Ragadhitya Janatantra Khoeshutama","1302223025",course,2019),
            new Mahasiswa("Gina Soraya", "1302223070", course, 2019),
            new Mahasiswa("M.Iqbal Nur Haq", "1302223050", course, 2019),
            new Mahasiswa("Kal El Muhammad Pratama", "1302220096", course, 2019),
        };

        [HttpGet(Name = "GetMahasiswa")]
        public IEnumerable<Mahasiswa> Get()
        {
            return mahasiswa;
        }
        [HttpPost(Name = "postMahasiswa")]
        public void post([FromBody] Mahasiswa mahasiswaa)
        {
            mahasiswa.Add(mahasiswaa);
        }
        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return mahasiswa[id];
        }
        [HttpDelete("{id}")]
        public void delete(int id)
        {
            mahasiswa.RemoveAt(id);
        }
    }
}
