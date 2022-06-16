using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    /**
     * データモデルクラス
     * 
     * クラス名とテーブル名を一致させる
     * 各プロパティとテーブルの列名と一致させる
     * Idプロパティがテーブルの主キーとなる
     */
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
       
        public string Genre { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Revenue { get; set; }
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string? Rating { get; set; }

    }
}
