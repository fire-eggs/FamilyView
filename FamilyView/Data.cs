using GEDWrap;
using System.Collections.Generic;
using System.Linq;

namespace FamilyView
{
        public struct PData
        {
            public Person who;
            public string Fullname;
            public string Birth;
            public string Death;
            public string DateRange;
            public bool HasParents;
            public bool HasMMarr;
            public string BirthYear { get; set; }
            public string DeathYear { get; set; }
        }

        public struct DataSet
        {
            public PData primary;
            public PData? spouse;
            public PData pDad;
            public PData pMom;
            public PData sDad;
            public PData sMom;
            public string marriage;
            public List<DataSet> children;
        }

    class Data
    {
        public static DataSet? fetchData(Person firstP)
        {
            if (firstP == null)
                return null;

            return fetchData(firstP, true);
        }

        private static DataSet fetchData(Person firstP, bool doParents)
        {
            var baseData = new DataSet();

            baseData.primary = doPerson(firstP);

            var marr = firstP.MarriageUnion;
            if (marr != null)
            {
                var spouse = firstP.MarriageUnion.Spouse(firstP);
                if (spouse != null)
                {
                    baseData.spouse = doPerson(spouse);

                    if (doParents)
                    {
                        var sFam = spouse.ChildIn.FirstOrDefault();
                        if (sFam != null)
                        {
                            if (sFam.Husband != null)
                                baseData.sDad = doPerson(sFam.Husband);
                            if (sFam.Wife != null)
                                baseData.sMom = doPerson(sFam.Wife);
                        }
                    }
                }
                var mDate = marr.MarriageDate;
                baseData.marriage = mDate == null ? "" : mDate.ToString();

                baseData.children = doChildren(marr.Childs);
            }
            else
            {
                baseData.spouse = null;
            }

            if (doParents)
            {
                var fam = firstP.ChildIn.FirstOrDefault();
                if (fam != null)
                {
                    if (fam.Husband != null)
                        baseData.pDad = doPerson(fam.Husband);
                    if (fam.Wife != null)
                        baseData.pMom = doPerson(fam.Wife);
                }
            }
            return baseData;
        }

        private static List<DataSet> doChildren(HashSet<Person> childs)
        {
            var clist = new List<DataSet>();
            foreach (var child in childs)
            {
                clist.Add(fetchData(child, false));
            }
            return clist;
        }

        private static PData doPerson(Person p)
        {
            PData pd = new PData();
            pd.who = p;
            pd.Fullname = p.Name;

            pd.Birth = p.GetDate("BIRT") + ":" + p.GetPlace("BIRT");
            pd.Death = p.GetDate("DEAT") + ":" + p.GetPlace("DEAT");

            pd.DateRange = string.Format("({0}-{1})", p.GetYear("BIRT"), p.GetYear("DEAT"));

            var pFam = p.ChildIn.FirstOrDefault();
            pd.HasParents = pFam != null && pFam.Husband != null && pFam.Wife != null;
            pd.HasMMarr = p.SpouseIn.Count() > 1;

            pd.BirthYear = p.GetYear("BIRT");
            pd.DeathYear = p.GetYear("DEAT");

            return pd;
        }
    }
}
