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
			internal static global::MonoJavaBridge.MethodId _values8657;
			public static global::android.util.Xml.Encoding[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.util.Xml.Encoding>(@__env.CallStaticObjectMethod(android.util.Xml.Encoding.staticClass, global::android.util.Xml.Encoding._values8657)) as android.util.Xml.Encoding[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf8658;
			public static global::android.util.Xml.Encoding valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.util.Xml.Encoding.staticClass, global::android.util.Xml.Encoding._valueOf8658, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.util.Xml.Encoding;
			}
			internal static global::MonoJavaBridge.FieldId _ISO_8859_18659;
			public static global::android.util.Xml.Encoding ISO_8859_1
			{
				get
				{
					return default(global::android.util.Xml.Encoding);
				}
			}
			internal static global::MonoJavaBridge.FieldId _US_ASCII8660;
			public static global::android.util.Xml.Encoding US_ASCII
			{
				get
				{
					return default(global::android.util.Xml.Encoding);
				}
			}
			internal static global::MonoJavaBridge.FieldId _UTF_168661;
			public static global::android.util.Xml.Encoding UTF_16
			{
				get
				{
					return default(global::android.util.Xml.Encoding);
				}
			}
			internal static global::MonoJavaBridge.FieldId _UTF_88662;
			public static global::android.util.Xml.Encoding UTF_8
			{
				get
				{
					return default(global::android.util.Xml.Encoding);
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.util.Xml.Encoding.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/Xml$Encoding"));
				global::android.util.Xml.Encoding._values8657 = @__env.GetStaticMethodIDNoThrow(global::android.util.Xml.Encoding.staticClass, "values", "()[Landroid/util/Xml/Encoding;");
				global::android.util.Xml.Encoding._valueOf8658 = @__env.GetStaticMethodIDNoThrow(global::android.util.Xml.Encoding.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/util/Xml$Encoding;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _parse8663;
		public static void parse(java.lang.String arg0, org.xml.sax.ContentHandler arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.util.Xml.staticClass, global::android.util.Xml._parse8663, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _parse8664;
		public static void parse(java.io.Reader arg0, org.xml.sax.ContentHandler arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.util.Xml.staticClass, global::android.util.Xml._parse8664, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _parse8665;
		public static void parse(java.io.InputStream arg0, android.util.Xml.Encoding arg1, org.xml.sax.ContentHandler arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.util.Xml.staticClass, global::android.util.Xml._parse8665, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _newPullParser8666;
		public static global::org.xmlpull.v1.XmlPullParser newPullParser() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xmlpull.v1.XmlPullParser>(@__env.CallStaticObjectMethod(android.util.Xml.staticClass, global::android.util.Xml._newPullParser8666)) as org.xmlpull.v1.XmlPullParser;
		}
		internal static global::MonoJavaBridge.MethodId _newSerializer8667;
		public static global::org.xmlpull.v1.XmlSerializer newSerializer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xmlpull.v1.XmlSerializer>(@__env.CallStaticObjectMethod(android.util.Xml.staticClass, global::android.util.Xml._newSerializer8667)) as org.xmlpull.v1.XmlSerializer;
		}
		internal static global::MonoJavaBridge.MethodId _findEncodingByName8668;
		public static global::android.util.Xml.Encoding findEncodingByName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.util.Xml.staticClass, global::android.util.Xml._findEncodingByName8668, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.util.Xml.Encoding;
		}
		internal static global::MonoJavaBridge.MethodId _asAttributeSet8669;
		public static global::android.util.AttributeSet asAttributeSet(org.xmlpull.v1.XmlPullParser arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.util.AttributeSet>(@__env.CallStaticObjectMethod(android.util.Xml.staticClass, global::android.util.Xml._asAttributeSet8669, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.util.AttributeSet;
		}
		internal static global::MonoJavaBridge.MethodId _Xml8670;
		public Xml()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.Xml.staticClass, global::android.util.Xml._Xml8670);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _FEATURE_RELAXED8671;
		public static global::java.lang.String FEATURE_RELAXED
		{
			get
			{
				return default(global::java.lang.String);
			}
			set
			{
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.Xml.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/Xml"));
			global::android.util.Xml._parse8663 = @__env.GetStaticMethodIDNoThrow(global::android.util.Xml.staticClass, "parse", "(Ljava/lang/String;Lorg/xml/sax/ContentHandler;)V");
			global::android.util.Xml._parse8664 = @__env.GetStaticMethodIDNoThrow(global::android.util.Xml.staticClass, "parse", "(Ljava/io/Reader;Lorg/xml/sax/ContentHandler;)V");
			global::android.util.Xml._parse8665 = @__env.GetStaticMethodIDNoThrow(global::android.util.Xml.staticClass, "parse", "(Ljava/io/InputStream;Landroid/util/Xml$Encoding;Lorg/xml/sax/ContentHandler;)V");
			global::android.util.Xml._newPullParser8666 = @__env.GetStaticMethodIDNoThrow(global::android.util.Xml.staticClass, "newPullParser", "()Lorg/xmlpull/v1/XmlPullParser;");
			global::android.util.Xml._newSerializer8667 = @__env.GetStaticMethodIDNoThrow(global::android.util.Xml.staticClass, "newSerializer", "()Lorg/xmlpull/v1/XmlSerializer;");
			global::android.util.Xml._findEncodingByName8668 = @__env.GetStaticMethodIDNoThrow(global::android.util.Xml.staticClass, "findEncodingByName", "(Ljava/lang/String;)Landroid/util/Xml$Encoding;");
			global::android.util.Xml._asAttributeSet8669 = @__env.GetStaticMethodIDNoThrow(global::android.util.Xml.staticClass, "asAttributeSet", "(Lorg/xmlpull/v1/XmlPullParser;)Landroid/util/AttributeSet;");
			global::android.util.Xml._Xml8670 = @__env.GetMethodIDNoThrow(global::android.util.Xml.staticClass, "<init>", "()V");
		}
	}
}
