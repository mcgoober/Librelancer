namespace LibreLancer.Data.Ini
{
    public interface IIniObserver
    {
        void StartSection(string sectionName);
        void EndSection();
        void StartEntry(string entryName);
        void EndEntry();
        void Value(object value);
        void Comment(string comment);
    }
}
