using System;
using System.Collections.Generic;
using System.Text;

namespace Radio.Model
{
    public class Broadcast
    {
        public string BroadcastName { get; set; }
        public string BroadcasterName { get; set; }
        public string BroadcastDay { get; set; }
        public string BroadcastHour { get; set; }
        public List<Broadcast> GetBroadcasts()
        {
            List<Broadcast> broadcasts = new List<Broadcast>() {
                new Broadcast() {BroadcastName = "Karışık Kaset", BroadcasterName = "Bilge TOPAK", BroadcastDay = "Perşembe", BroadcastHour = "22:00-23:00"},
                new Broadcast() {BroadcastName = "The Human Library", BroadcasterName = "Unknown", BroadcastDay = "Pazar", BroadcastHour = "22:00-23:00"},
                new Broadcast() {BroadcastName = "Etiket", BroadcasterName = "Unknown Unknownoğlu", BroadcastDay = "Pazartesi", BroadcastHour = "00:00-02:00"},
                new Broadcast() {BroadcastName = "A Jarr of Jazz", BroadcasterName = "Güren İçim", BroadcastDay = "Salı", BroadcastHour = "21:00-22:00"},
                new Broadcast() {BroadcastName = "Teachers are Human", BroadcasterName = "Makif Nayman - İrem Efe", BroadcastDay = "Çarşamba", BroadcastHour = "20:00-22:00"},
            };
            return broadcasts;
        }
    }
}
