namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CitySeedData : DbMigration
    {
        public override void Up()
        {

            //This is the seed data for the City table. It is a long list of cities in Turkey.
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Adana', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Adıyaman', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Afyonkarahisar', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Ağrı', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Amasya', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Ankara', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Antalya', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Artvin', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Aydın', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Balıkesir', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Bilecik', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Bingöl', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Bitlis', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Bolu', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Burdur', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Bursa', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Çanakkale', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Çankırı', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Çorum', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Denizli', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Diyarbakır', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Edirne', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Elazığ', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Erzincan', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Erzurum', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Eskişehir', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Gaziantep', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Giresun', 1)");
            Sql("Insert INTO Cities (CityName, CountryID) VALUES ('Gümüşhane', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Hakkari', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Hatay', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Isparta', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Mersin', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('İstanbul', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('İzmir', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Kars', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Kastamonu', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Kayseri', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Kırklareli', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Kırşehir', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Kocaeli', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Konya', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Kütahya', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Malatya', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Manisa', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Kahramanmaraş', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Mardin', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Muğla', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Muş', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Nevşehir', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Niğde', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Ordu', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Rize', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Sakarya', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Samsun', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Siirt', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Sinop', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Sivas', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Tekirdağ', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Tokat', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Trabzon', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Tunceli', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Şanlıurfa', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Uşak', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Van', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Yozgat', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Zonguldak', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Aksaray', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Bayburt', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Karaman', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Kırıkkale', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Batman', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Şırnak', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Bartın', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Ardahan', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Iğdır', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Yalova', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Karabük', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Kilis', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Osmaniye', 1)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Düzce', 1)");


            //This is the seed data for the City table. It is a long list of cities in America.

            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('New York', 2)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Los Angeles', 2)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Chicago', 2)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Houston', 2)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Philadelphia', 2)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Phoenix', 2)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('San Antonio', 2)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('San Diego', 2)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Dallas', 2)");


            //This is the seed data for the City table. It is a long list of cities in Germany.
            
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Berlin', 3)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Hamburg', 3)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Munich', 3)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Cologne', 3)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Frankfurt', 3)");

            //This is the seed data for the City table. It is a long list of cities in England.

            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('London', 4)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Birmingham', 4)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Leeds', 4)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Glasgow', 4)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Sheffield', 4)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Bradford', 4)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Liverpool', 4)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Edinburgh', 4)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Manchester', 4)");

            //This is the seed data for the City table. It is a long list of cities in France.
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Paris', 5)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Marseille', 5)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Lyon', 5)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Toulouse', 5)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Nice', 5)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Nantes', 5)");
            Sql("INSERT INTO Cities (CityName, CountryID) VALUES ('Strasbourg', 5)");



        }

        public override void Down()
        {
        }
    }
}
