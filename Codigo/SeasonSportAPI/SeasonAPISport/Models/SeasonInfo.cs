using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Newtonsoft.Json;

namespace SeasonAPISport.Models
{
    public class SeasonInfo
        {
        internal ObservableCollection<Datum> Data;

        public class NameTranslations
    {

        [JsonProperty("en")]
        public string En { get; set; }
    }

    public class Host
    {

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("flag")]
        public string Flag { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }
    }

    public class Fact
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class Sport
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("name_translations")]
        public string NameTranslations { get; set; }
    }

    public class Section
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("name_translations")]
        public string NameTranslations { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }

        [JsonProperty("flag")]
        public string Flag { get; set; }

        [JsonProperty("sport")]
        public IList<Sport> Sport { get; set; }
    }

    public class Venue
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("stadium")]
        public string Stadium { get; set; }

        [JsonProperty("stadium_capacity")]
        public int StadiumCapacity { get; set; }

        [JsonProperty("country_name")]
        public string CountryName { get; set; }

        [JsonProperty("country_flag")]
        public string CountryFlag { get; set; }
    }

    public class Performance
    {

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("wins")]
        public int Wins { get; set; }

        [JsonProperty("draws")]
        public int Draws { get; set; }

        [JsonProperty("losses")]
        public int Losses { get; set; }

        [JsonProperty("goals_scored")]
        public int GoalsScored { get; set; }

        [JsonProperty("goals_conceded")]
        public int GoalsConceded { get; set; }

        [JsonProperty("total_points")]
        public int TotalPoints { get; set; }
    }

    public class Manager
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("name_translations")]
        public string NameTranslations { get; set; }

        [JsonProperty("name_short")]
        public string NameShort { get; set; }

        [JsonProperty("has_photo")]
        public bool HasPhoto { get; set; }

        [JsonProperty("photo")]
        public string Photo { get; set; }

        [JsonProperty("date_birth")]
        public string DateBirth { get; set; }

        [JsonProperty("nationality_code")]
        public string NationalityCode { get; set; }

        [JsonProperty("performance")]
        public Performance Performance { get; set; }

        [JsonProperty("preferred_formation")]
        public string PreferredFormation { get; set; }

        [JsonProperty("sport")]
        public IList<Sport> Sport { get; set; }

        [JsonProperty("team")]
        public IList<object> Team { get; set; }
    }

    public class TennisRanking
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("points")]
        public int Points { get; set; }

        [JsonProperty("ranking")]
        public int Ranking { get; set; }

        [JsonProperty("official_updated_at")]
        public string OfficialUpdatedAt { get; set; }

        [JsonProperty("team")]
        public IList<object> Team { get; set; }
    }

    public class TitleHolderTeam
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("name_translations")]
        public IList<NameTranslations> NameTranslations { get; set; }

        [JsonProperty("name_short")]
        public string NameShort { get; set; }

        [JsonProperty("name_full")]
        public string NameFull { get; set; }

        [JsonProperty("name_code")]
        public string NameCode { get; set; }

        [JsonProperty("has_sub")]
        public bool HasSub { get; set; }

        [JsonProperty("has_logo")]
        public bool HasLogo { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("is_nationality")]
        public bool IsNationality { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("flag")]
        public string Flag { get; set; }

        [JsonProperty("foundation")]
        public string Foundation { get; set; }

        [JsonProperty("details")]
        public IList<Detail> Details { get; set; }

        [JsonProperty("sport")]
        public IList<Sport> Sport { get; set; }

        [JsonProperty("section")]
        public IList<Section> Section { get; set; }

        [JsonProperty("venue")]
        public IList<Venue> Venue { get; set; }

        [JsonProperty("manager")]
        public IList<Manager> Manager { get; set; }

        [JsonProperty("tennis_ranking")]
        public IList<TennisRanking> TennisRanking { get; set; }
    }

    public class Detail
    {
        [JsonProperty("country")]
        public string Country { get; set; }
    }
    public class MostTitlesTeam
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("name_translations")]
        public IList<NameTranslations> NameTranslations { get; set; }

        [JsonProperty("name_short")]
        public string NameShort { get; set; }

        [JsonProperty("name_full")]
        public string NameFull { get; set; }

        [JsonProperty("name_code")]
        public string NameCode { get; set; }

        [JsonProperty("has_sub")]
        public bool HasSub { get; set; }

        [JsonProperty("has_logo")]
        public bool HasLogo { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("is_nationality")]
        public bool IsNationality { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("flag")]
        public string Flag { get; set; }

        [JsonProperty("foundation")]
        public string Foundation { get; set; }

        [JsonProperty("details")]
        public IList<Detail> Details { get; set; }

        [JsonProperty("sport")]
        public IList<Sport> Sport { get; set; }

        [JsonProperty("section")]
        public IList<Section> Section { get; set; }

        [JsonProperty("venue")]
        public IList<Venue> Venue { get; set; }

        [JsonProperty("manager")]
        public IList<Manager> Manager { get; set; }

        [JsonProperty("tennis_ranking")]
        public IList<TennisRanking> TennisRanking { get; set; }
    }

    public class League
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("name_translations")]
        public IList<NameTranslations> NameTranslations { get; set; }

        [JsonProperty("has_logo")]
        public bool HasLogo { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }

        [JsonProperty("host")]
        public Host Host { get; set; }

        [JsonProperty("tennis_points")]
        public int TennisPoints { get; set; }

        [JsonProperty("facts")]
        public IList<Fact> Facts { get; set; }

        [JsonProperty("sport")]
        public IList<Sport> Sport { get; set; }

        [JsonProperty("section")]
        public IList<Section> Section { get; set; }

        [JsonProperty("title_holder_team")]
        public IList<TitleHolderTeam> TitleHolderTeam { get; set; }

        [JsonProperty("most_titles_team")]
        public IList<MostTitlesTeam> MostTitlesTeam { get; set; }

        [JsonProperty("most_titles_team_count")]
        public int MostTitlesTeamCount { get; set; }
    }

    public class Datum
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("year_start")]
        public int YearStart { get; set; }

        [JsonProperty("year_end")]
        public int YearEnd { get; set; }

        [JsonProperty("league")]
        public IList<League> League { get; set; }
    }

    public class SeasonList
    {

        [JsonProperty("data")]
        public IList<Datum> Data { get; set; }
    }

}
}
