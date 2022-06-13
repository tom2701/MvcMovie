using System.ComponentModel.DataAnnotations;

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
        public decimal Revenue { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }


    }
}
