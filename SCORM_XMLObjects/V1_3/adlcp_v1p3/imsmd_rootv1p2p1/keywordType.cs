//
// keywordType.cs.cs
//
// This file was generated by XMLSPY 2004 Enterprise Edition.
//
// YOU SHOULD NOT MODIFY THIS FILE, BECAUSE IT WILL BE
// OVERWRITTEN WHEN YOU RE-RUN CODE GENERATION.
//
// Refer to the XMLSPY Documentation for further details.
// http://www.altova.com/xmlspy
//


using System;
using System.Collections;
using System.Xml;
using Altova.Types;

namespace imsmd_rootv1p2p1
{
	public class keywordType : Altova.Node
	{
		#region Forward constructors
		public keywordType() : base() { SetCollectionParents(); }
		public keywordType(XmlDocument doc) : base(doc) { SetCollectionParents(); }
		public keywordType(XmlNode node) : base(node) { SetCollectionParents(); }
		public keywordType(Altova.Node node) : base(node) { SetCollectionParents(); }
		#endregion // Forward constructors

		public override void AdjustPrefix()
		{
			int nCount;

			nCount = DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "langstring");
			for (int i = 0; i < nCount; i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "langstring", i);
				InternalAdjustPrefix(DOMNode, true);
				new langstringType(DOMNode).AdjustPrefix();
			}
		}


		#region langstring accessor methods
		public int GetlangstringMinCount()
		{
			return 1;
		}

		public int langstringMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GetlangstringMaxCount()
		{
			return Int32.MaxValue;
		}

		public int langstringMaxCount
		{
			get
			{
				return Int32.MaxValue;
			}
		}

		public int GetlangstringCount()
		{
			return DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "langstring");
		}

		public int langstringCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "langstring");
			}
		}

		public bool Haslangstring()
		{
			return HasDomChild(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "langstring");
		}

		public langstringType GetlangstringAt(int index)
		{
			return new langstringType(GetDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "langstring", index));
		}

		public langstringType Getlangstring()
		{
			return GetlangstringAt(0);
		}

		public langstringType langstring
		{
			get
			{
				return GetlangstringAt(0);
			}
		}

		public void RemovelangstringAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "langstring", index);
		}

		public void Removelangstring()
		{
			while (Haslangstring())
				RemovelangstringAt(0);
		}

		public void Addlangstring(langstringType newValue)
		{
			AppendDomElement("http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "langstring", newValue);
		}

		public void InsertlangstringAt(langstringType newValue, int index)
		{
			InsertDomElementAt("http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "langstring", index, newValue);
		}

		public void ReplacelangstringAt(langstringType newValue, int index)
		{
			ReplaceDomElementAt("http://www.imsglobal.org/xsd/imsmd_rootv1p2p1", "langstring", index, newValue);
		}
		#endregion // langstring accessor methods

		#region langstring collection
        public langstringCollection	Mylangstrings = new langstringCollection( );

        public class langstringCollection: IEnumerable
        {
            keywordType parent;
            public keywordType Parent
			{
				set
				{
					parent = value;
				}
			}
			public langstringEnumerator GetEnumerator() 
			{
				return new langstringEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class langstringEnumerator: IEnumerator 
        {
			int nIndex;
			keywordType parent;
			public langstringEnumerator(keywordType par) 
			{
				parent = par;
				nIndex = -1;
			}
			public void Reset() 
			{
				nIndex = -1;
			}
			public bool MoveNext() 
			{
				nIndex++;
				return(nIndex < parent.langstringCount );
			}
			public langstringType  Current 
			{
				get 
				{
					return(parent.GetlangstringAt(nIndex));
				}
			}
			object IEnumerator.Current 
			{
				get 
				{
					return(Current);
				}
			}
    	}
	
        #endregion // langstring collection

        private void SetCollectionParents()
        {
            Mylangstrings.Parent = this; 
	}
}
}
