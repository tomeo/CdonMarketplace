using System.Collections.Generic;
using System.Linq;

namespace CdonMarketplace.Utils
{
    internal class CDataTracker
    {
        private readonly List<CDataPath> _cDataPaths = new List<CDataPath>();
        private int _depth;
        internal bool CdataMode { get; private set; }

        internal void Push(string local)
        {
            foreach (var p in _cDataPaths)
            {
                if (p.IsOnPath)
                {
                    if (local == p.Path[p.PathIndex])
                    {
                        p.PathIndex++;
                        CdataMode = p.PathIndex == p.Path.Length;
                    }
                    else
                    {
                        p.IsOnPath = false;
                    }
                }
            }

            _depth++;
        }

        internal void Pop()
        {
            foreach (var p in _cDataPaths)
            {
                if (p.IsOnPath)
                {
                    p.PathIndex--;
                    CdataMode = false;
                }
                else
                {
                    if (_depth == p.PathIndex + 1)
                        p.IsOnPath = true;
                }
            }

            _depth--;
        }

        internal void Add(IEnumerable<string> path) => 
            _cDataPaths.Add(new CDataPath(path.Select(x => x.ToLower()).ToArray()));

        private class CDataPath
        {
            public readonly string[] Path;
            public bool IsOnPath = true;
            public int PathIndex;

            public CDataPath(string[] path)
            {
                Path = path;
            }
        }
    }
}