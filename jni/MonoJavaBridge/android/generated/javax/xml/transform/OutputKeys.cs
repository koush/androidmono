namespace javax.xml.transform
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class OutputKeys : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected OutputKeys(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public static global::java.lang.String METHOD
		{
			get
			{
				return "method";
			}
		}
		public static global::java.lang.String VERSION
		{
			get
			{
				return "version";
			}
		}
		public static global::java.lang.String ENCODING
		{
			get
			{
				return "encoding";
			}
		}
		public static global::java.lang.String OMIT_XML_DECLARATION
		{
			get
			{
				return "omit-xml-declaration";
			}
		}
		public static global::java.lang.String STANDALONE
		{
			get
			{
				return "standalone";
			}
		}
		public static global::java.lang.String DOCTYPE_PUBLIC
		{
			get
			{
				return "doctype-public";
			}
		}
		public static global::java.lang.String DOCTYPE_SYSTEM
		{
			get
			{
				return "doctype-system";
			}
		}
		public static global::java.lang.String CDATA_SECTION_ELEMENTS
		{
			get
			{
				return "cdata-section-elements";
			}
		}
		public static global::java.lang.String INDENT
		{
			get
			{
				return "indent";
			}
		}
		public static global::java.lang.String MEDIA_TYPE
		{
			get
			{
				return "media-type";
			}
		}
		static OutputKeys()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.transform.OutputKeys.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/transform/OutputKeys"));
		}
		internal static void InitJNI()
		{
		}
	}
}
