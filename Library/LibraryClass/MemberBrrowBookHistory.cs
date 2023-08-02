namespace Library.LibraryClass
{
    public class MemberBrrowBookHistory
    {
        public MemberBrrowBookHistory(Member member)
        {
            Member = member;
        }

        public Book Book { get; set; }
        public Member Member { get; set; }
    }
}
