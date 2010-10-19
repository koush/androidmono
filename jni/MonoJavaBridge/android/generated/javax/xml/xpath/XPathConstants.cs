namespace javax.xml.xpath
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class XPathConstants : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static XPathConstants()
		{
			InitJNI();
		}
		protected XPathConstants(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.FieldId _NUMBER24688;
		public static global::javax.xml.@namespace.QName NUMBER
		{
			get
			{
				return default(global::javax.xml.@namespace.QName);
			}
		}
		internal static global::MonoJavaBridge.FieldId _STRING24689;
		public static global::javax.xml.@namespace.QName STRING
		{
			get
			{
				return default(global::javax.xml.@namespace.QName);
			}
		}
		internal static global::MonoJavaBridge.FieldId _BOOLEAN24690;
		public static global::javax.xml.@namespace.QName BOOLEAN
		{
			get
			{
				return default(global::javax.xml.@namespace.QName);
			}
		}
		internal static global::MonoJavaBridge.FieldId _NODESET24691;
		public static global::javax.xml.@namespace.QName NODESET
		{
			get
			{
				return default(global::javax.xml.@namespace.QName);
			}
		}
		internal static global::MonoJavaBridge.FieldId _NODE24692;
		public static global::javax.xml.@namespace.QName NODE
		{
			get
			{
				return default(global::javax.xml.@namespace.QName);
			}
		}
		public static global::java.lang.String DOM_OBJECT_MODEL
		{
			get
			{
				return "http://java.sun.com/jaxp/xpath/dom";
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.xpath.XPathConstants.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/xpath/XPathConstants"));
		}
	}
}
