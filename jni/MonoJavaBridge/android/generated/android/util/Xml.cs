namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Xml : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Xml()
		{
			InitJNI();
		}
		protected Xml(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Encoding : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Encoding()
			{
				InitJNI();
			}
			internal Encoding(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values13955;
			public static global::android.util.Xml.Encoding[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.util.Xml.Encoding>(@__env.CallStaticObjectMethod(android.util.Xml.Encoding.staticClass, global::android.util.Xml.Encoding._values13955)) as android.util.Xml.Encoding[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf13956;
			public static global::android.util.Xml.Encoding valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.util.Xml.Encoding>(@__env.CallStaticObjectMethod(android.util.Xml.Encoding.staticClass, global::android.util.Xml.Encoding._valueOf13956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.util.Xml.Encoding;
			}
			internal static global::MonoJavaBridge.FieldId _ISO_8859_113957;
			public static global::android.util.Xml.Encoding ISO_8859_1
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.util.Xml.Encoding>(@__env.GetStaticObjectField(global::android.util.Xml.Encoding.staticClass, _ISO_8859_113957)) as android.util.Xml.Encoding;
				}
			}
			internal static global::MonoJavaBridge.FieldId _US_ASCII13958;
			public static global::android.util.Xml.Encoding US_ASCII
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.util.Xml.Encoding>(@__env.GetStaticObjectField(global::android.util.Xml.Encoding.staticClass, _US_ASCII13958)) as android.util.Xml.Encoding;
				}
			}
			internal static global::MonoJavaBridge.FieldId _UTF_1613959;
			public static global::android.util.Xml.Encoding UTF_16
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.util.Xml.Encoding>(@__env.GetStaticObjectField(global::android.util.Xml.Encoding.staticClass, _UTF_1613959)) as android.util.Xml.Encoding;
				}
			}
			internal static global::MonoJavaBridge.FieldId _UTF_813960;
			public static global::android.util.Xml.Encoding UTF_8
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.util.Xml.Encoding>(@__env.GetStaticObjectField(global::android.util.Xml.Encoding.staticClass, _UTF_813960)) as android.util.Xml.Encoding;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.util.Xml.Encoding.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/Xml$Encoding"));
				global::android.util.Xml.Encoding._values13955 = @__env.GetStaticMethodIDNoThrow(global::android.util.Xml.Encoding.staticClass, "values", "()[Landroid/util/Xml/Encoding;");
				global::android.util.Xml.Encoding._valueOf13956 = @__env.GetStaticMethodIDNoThrow(global::android.util.Xml.Encoding.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/util/Xml$Encoding;");
				global::android.util.Xml.Encoding._ISO_8859_113957 = @__env.GetStaticFieldIDNoThrow(global::android.util.Xml.Encoding.staticClass, "ISO_8859_1", "Landroid/util/Xml$Encoding;");
				global::android.util.Xml.Encoding._US_ASCII13958 = @__env.GetStaticFieldIDNoThrow(global::android.util.Xml.Encoding.staticClass, "US_ASCII", "Landroid/util/Xml$Encoding;");
				global::android.util.Xml.Encoding._UTF_1613959 = @__env.GetStaticFieldIDNoThrow(global::android.util.Xml.Encoding.staticClass, "UTF_16", "Landroid/util/Xml$Encoding;");
				global::android.util.Xml.Encoding._UTF_813960 = @__env.GetStaticFieldIDNoThrow(global::android.util.Xml.Encoding.staticClass, "UTF_8", "Landroid/util/Xml$Encoding;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _parse13961;
		public static void parse(java.lang.String arg0, org.xml.sax.ContentHandler arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.util.Xml.staticClass, global::android.util.Xml._parse13961, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _parse13962;
		public static void parse(java.io.Reader arg0, org.xml.sax.ContentHandler arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.util.Xml.staticClass, global::android.util.Xml._parse13962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _parse13963;
		public static void parse(java.io.InputStream arg0, android.util.Xml.Encoding arg1, org.xml.sax.ContentHandler arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.util.Xml.staticClass, global::android.util.Xml._parse13963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _newPullParser13964;
		public static global::org.xmlpull.v1.XmlPullParser newPullParser() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xmlpull.v1.XmlPullParser>(@__env.CallStaticObjectMethod(android.util.Xml.staticClass, global::android.util.Xml._newPullParser13964)) as org.xmlpull.v1.XmlPullParser;
		}
		internal static global::MonoJavaBridge.MethodId _newSerializer13965;
		public static global::org.xmlpull.v1.XmlSerializer newSerializer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xmlpull.v1.XmlSerializer>(@__env.CallStaticObjectMethod(android.util.Xml.staticClass, global::android.util.Xml._newSerializer13965)) as org.xmlpull.v1.XmlSerializer;
		}
		internal static global::MonoJavaBridge.MethodId _findEncodingByName13966;
		public static global::android.util.Xml.Encoding findEncodingByName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.util.Xml.Encoding>(@__env.CallStaticObjectMethod(android.util.Xml.staticClass, global::android.util.Xml._findEncodingByName13966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.util.Xml.Encoding;
		}
		internal static global::MonoJavaBridge.MethodId _asAttributeSet13967;
		public static global::android.util.AttributeSet asAttributeSet(org.xmlpull.v1.XmlPullParser arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.util.AttributeSet>(@__env.CallStaticObjectMethod(android.util.Xml.staticClass, global::android.util.Xml._asAttributeSet13967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.util.AttributeSet;
		}
		internal static global::MonoJavaBridge.MethodId _Xml13968;
		public Xml()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.Xml.staticClass, global::android.util.Xml._Xml13968);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _FEATURE_RELAXED13969;
		public static global::java.lang.String FEATURE_RELAXED
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.util.Xml.staticClass, _FEATURE_RELAXED13969)) as java.lang.String;
			}
			set
			{
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.Xml.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/Xml"));
			global::android.util.Xml._parse13961 = @__env.GetStaticMethodIDNoThrow(global::android.util.Xml.staticClass, "parse", "(Ljava/lang/String;Lorg/xml/sax/ContentHandler;)V");
			global::android.util.Xml._parse13962 = @__env.GetStaticMethodIDNoThrow(global::android.util.Xml.staticClass, "parse", "(Ljava/io/Reader;Lorg/xml/sax/ContentHandler;)V");
			global::android.util.Xml._parse13963 = @__env.GetStaticMethodIDNoThrow(global::android.util.Xml.staticClass, "parse", "(Ljava/io/InputStream;Landroid/util/Xml$Encoding;Lorg/xml/sax/ContentHandler;)V");
			global::android.util.Xml._newPullParser13964 = @__env.GetStaticMethodIDNoThrow(global::android.util.Xml.staticClass, "newPullParser", "()Lorg/xmlpull/v1/XmlPullParser;");
			global::android.util.Xml._newSerializer13965 = @__env.GetStaticMethodIDNoThrow(global::android.util.Xml.staticClass, "newSerializer", "()Lorg/xmlpull/v1/XmlSerializer;");
			global::android.util.Xml._findEncodingByName13966 = @__env.GetStaticMethodIDNoThrow(global::android.util.Xml.staticClass, "findEncodingByName", "(Ljava/lang/String;)Landroid/util/Xml$Encoding;");
			global::android.util.Xml._asAttributeSet13967 = @__env.GetStaticMethodIDNoThrow(global::android.util.Xml.staticClass, "asAttributeSet", "(Lorg/xmlpull/v1/XmlPullParser;)Landroid/util/AttributeSet;");
			global::android.util.Xml._Xml13968 = @__env.GetMethodIDNoThrow(global::android.util.Xml.staticClass, "<init>", "()V");
			global::android.util.Xml._FEATURE_RELAXED13969 = @__env.GetStaticFieldIDNoThrow(global::android.util.Xml.staticClass, "FEATURE_RELAXED", "Ljava/lang/String;");
		}
	}
}
