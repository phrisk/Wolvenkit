using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CDyngResource : CResource
	{
		[Ordinal(0)] [RED("("name")] 		public CString Name { get; set;}

		[Ordinal(0)] [RED("("dyngSkeleton")] 		public CHandle<CSkeleton> DyngSkeleton { get; set;}

		[Ordinal(0)] [RED("("nodeNames", 2,0)] 		public CArray<CString> NodeNames { get; set;}

		[Ordinal(0)] [RED("("nodeParents", 2,0)] 		public CArray<CString> NodeParents { get; set;}

		[Ordinal(0)] [RED("("nodeMasses", 2,0)] 		public CArray<CFloat> NodeMasses { get; set;}

		[Ordinal(0)] [RED("("nodeStifnesses", 2,0)] 		public CArray<CFloat> NodeStifnesses { get; set;}

		[Ordinal(0)] [RED("("nodeDistances", 2,0)] 		public CArray<CFloat> NodeDistances { get; set;}

		[Ordinal(0)] [RED("("nodeTransforms", 2,0)] 		public CArray<CMatrix> NodeTransforms { get; set;}

		[Ordinal(0)] [RED("("linkTypes", 2,0)] 		public CArray<CInt32> LinkTypes { get; set;}

		[Ordinal(0)] [RED("("linkLengths", 2,0)] 		public CArray<CFloat> LinkLengths { get; set;}

		[Ordinal(0)] [RED("("linkAs", 2,0)] 		public CArray<CInt32> LinkAs { get; set;}

		[Ordinal(0)] [RED("("linkBs", 2,0)] 		public CArray<CInt32> LinkBs { get; set;}

		[Ordinal(0)] [RED("("triangleAs", 2,0)] 		public CArray<CInt32> TriangleAs { get; set;}

		[Ordinal(0)] [RED("("triangleBs", 2,0)] 		public CArray<CInt32> TriangleBs { get; set;}

		[Ordinal(0)] [RED("("triangleCs", 2,0)] 		public CArray<CInt32> TriangleCs { get; set;}

		[Ordinal(0)] [RED("("collisionParents", 2,0)] 		public CArray<CString> CollisionParents { get; set;}

		[Ordinal(0)] [RED("("collisionRadiuses", 2,0)] 		public CArray<CFloat> CollisionRadiuses { get; set;}

		[Ordinal(0)] [RED("("collisionHeights", 2,0)] 		public CArray<CFloat> CollisionHeights { get; set;}

		[Ordinal(0)] [RED("("collisionTransforms", 2,0)] 		public CArray<CMatrix> CollisionTransforms { get; set;}

		public CDyngResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CDyngResource(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}