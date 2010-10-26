namespace org.xmlpull.v1
{
	[global::MonoJavaBridge.JavaClass()]
	public static partial class XmlPullParserConstants 
	{
		internal static global::MonoJavaBridge.FieldId _NO_NAMESPACE35347;
		public static global::java.lang.String NO_NAMESPACE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::org.xmlpull.v1.XmlPullParser_.staticClass, _NO_NAMESPACE35347)) as java.lang.String;
			}
		}
		public static int START_DOCUMENT
		{
			get
			{
				return 0;
			}
		}
		public static int END_DOCUMENT
		{
			get
			{
				return 1;
			}
		}
		public static int START_TAG
		{
			get
			{
				return 2;
			}
		}
		public static int END_TAG
		{
			get
			{
				return 3;
			}
		}
		public static int TEXT
		{
			get
			{
				return 4;
			}
		}
		public static int CDSECT
		{
			get
			{
				return 5;
			}
		}
		public static int ENTITY_REF
		{
			get
			{
				return 6;
			}
		}
		public static int IGNORABLE_WHITESPACE
		{
			get
			{
				return 7;
			}
		}
		public static int PROCESSING_INSTRUCTION
		{
			get
			{
				return 8;
			}
		}
		public static int COMMENT
		{
			get
			{
				return 9;
			}
		}
		public static int DOCDECL
		{
			get
			{
				return 10;
			}
		}
		internal static global::MonoJavaBridge.FieldId _TYPES35359;
		public static global::java.lang.String[] TYPES
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.GetStaticObjectField(global::org.xmlpull.v1.XmlPullParser_.staticClass, _TYPES35359)) as java.lang.String[];
			}
		}
		public static global::java.lang.String FEATURE_PROCESS_NAMESPACES
		{
			get
			{
				return "http://xmlpull.org/v1/doc/features.html#process-namespaces";
			}
		}
		public static global::java.lang.String FEATURE_REPORT_NAMESPACE_ATTRIBUTES
		{
			get
			{
				return "http://xmlpull.org/v1/doc/features.html#report-namespace-prefixes";
			}
		}
		public static global::java.lang.String FEATURE_PROCESS_DOCDECL
		{
			get
			{
				return "http://xmlpull.org/v1/doc/features.html#process-docdecl";
			}
		}
		public static global::java.lang.String FEATURE_VALIDATION
		{
			get
			{
				return "http://xmlpull.org/v1/doc/features.html#validation";
			}
		}
	}
}
