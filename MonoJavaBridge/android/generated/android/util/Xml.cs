namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Xml : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Xml(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Encoding : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal Encoding(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public static global::android.util.Xml.Encoding[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.util.Xml.Encoding._m0.native == global::System.IntPtr.Zero)
					global::android.util.Xml.Encoding._m0 = @__env.GetStaticMethodIDNoThrow(global::android.util.Xml.Encoding.staticClass, "values", "()[Landroid/util/Xml/Encoding;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.util.Xml.Encoding>(@__env.CallStaticObjectMethod(android.util.Xml.Encoding.staticClass, global::android.util.Xml.Encoding._m0)) as android.util.Xml.Encoding[];
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public static global::android.util.Xml.Encoding valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.util.Xml.Encoding._m1.native == global::System.IntPtr.Zero)
					global::android.util.Xml.Encoding._m1 = @__env.GetStaticMethodIDNoThrow(global::android.util.Xml.Encoding.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/util/Xml$Encoding;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.util.Xml.Encoding>(@__env.CallStaticObjectMethod(android.util.Xml.Encoding.staticClass, global::android.util.Xml.Encoding._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.util.Xml.Encoding;
			}
			internal static global::MonoJavaBridge.FieldId _ISO_8859_15457;
			public static global::android.util.Xml.Encoding ISO_8859_1
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.util.Xml.Encoding>(@__env.GetStaticObjectField(global::android.util.Xml.Encoding.staticClass, _ISO_8859_15457)) as android.util.Xml.Encoding;
				}
			}
			internal static global::MonoJavaBridge.FieldId _US_ASCII5458;
			public static global::android.util.Xml.Encoding US_ASCII
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.util.Xml.Encoding>(@__env.GetStaticObjectField(global::android.util.Xml.Encoding.staticClass, _US_ASCII5458)) as android.util.Xml.Encoding;
				}
			}
			internal static global::MonoJavaBridge.FieldId _UTF_165459;
			public static global::android.util.Xml.Encoding UTF_16
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.util.Xml.Encoding>(@__env.GetStaticObjectField(global::android.util.Xml.Encoding.staticClass, _UTF_165459)) as android.util.Xml.Encoding;
				}
			}
			internal static global::MonoJavaBridge.FieldId _UTF_85460;
			public static global::android.util.Xml.Encoding UTF_8
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.util.Xml.Encoding>(@__env.GetStaticObjectField(global::android.util.Xml.Encoding.staticClass, _UTF_85460)) as android.util.Xml.Encoding;
				}
			}
			static Encoding()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.util.Xml.Encoding.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/Xml$Encoding"));
				global::android.util.Xml.Encoding._ISO_8859_15457 = @__env.GetStaticFieldIDNoThrow(global::android.util.Xml.Encoding.staticClass, "ISO_8859_1", "Landroid/util/Xml$Encoding;");
				global::android.util.Xml.Encoding._US_ASCII5458 = @__env.GetStaticFieldIDNoThrow(global::android.util.Xml.Encoding.staticClass, "US_ASCII", "Landroid/util/Xml$Encoding;");
				global::android.util.Xml.Encoding._UTF_165459 = @__env.GetStaticFieldIDNoThrow(global::android.util.Xml.Encoding.staticClass, "UTF_16", "Landroid/util/Xml$Encoding;");
				global::android.util.Xml.Encoding._UTF_85460 = @__env.GetStaticFieldIDNoThrow(global::android.util.Xml.Encoding.staticClass, "UTF_8", "Landroid/util/Xml$Encoding;");
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static void parse(java.lang.String arg0, org.xml.sax.ContentHandler arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Xml._m0.native == global::System.IntPtr.Zero)
				global::android.util.Xml._m0 = @__env.GetStaticMethodIDNoThrow(global::android.util.Xml.staticClass, "parse", "(Ljava/lang/String;Lorg/xml/sax/ContentHandler;)V");
			@__env.CallStaticVoidMethod(android.util.Xml.staticClass, global::android.util.Xml._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static void parse(java.io.Reader arg0, org.xml.sax.ContentHandler arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Xml._m1.native == global::System.IntPtr.Zero)
				global::android.util.Xml._m1 = @__env.GetStaticMethodIDNoThrow(global::android.util.Xml.staticClass, "parse", "(Ljava/io/Reader;Lorg/xml/sax/ContentHandler;)V");
			@__env.CallStaticVoidMethod(android.util.Xml.staticClass, global::android.util.Xml._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static void parse(java.io.InputStream arg0, android.util.Xml.Encoding arg1, org.xml.sax.ContentHandler arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Xml._m2.native == global::System.IntPtr.Zero)
				global::android.util.Xml._m2 = @__env.GetStaticMethodIDNoThrow(global::android.util.Xml.staticClass, "parse", "(Ljava/io/InputStream;Landroid/util/Xml$Encoding;Lorg/xml/sax/ContentHandler;)V");
			@__env.CallStaticVoidMethod(android.util.Xml.staticClass, global::android.util.Xml._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static global::org.xmlpull.v1.XmlPullParser newPullParser()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Xml._m3.native == global::System.IntPtr.Zero)
				global::android.util.Xml._m3 = @__env.GetStaticMethodIDNoThrow(global::android.util.Xml.staticClass, "newPullParser", "()Lorg/xmlpull/v1/XmlPullParser;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xmlpull.v1.XmlPullParser>(@__env.CallStaticObjectMethod(android.util.Xml.staticClass, global::android.util.Xml._m3)) as org.xmlpull.v1.XmlPullParser;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static global::org.xmlpull.v1.XmlSerializer newSerializer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Xml._m4.native == global::System.IntPtr.Zero)
				global::android.util.Xml._m4 = @__env.GetStaticMethodIDNoThrow(global::android.util.Xml.staticClass, "newSerializer", "()Lorg/xmlpull/v1/XmlSerializer;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.xmlpull.v1.XmlSerializer>(@__env.CallStaticObjectMethod(android.util.Xml.staticClass, global::android.util.Xml._m4)) as org.xmlpull.v1.XmlSerializer;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static global::android.util.Xml.Encoding findEncodingByName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Xml._m5.native == global::System.IntPtr.Zero)
				global::android.util.Xml._m5 = @__env.GetStaticMethodIDNoThrow(global::android.util.Xml.staticClass, "findEncodingByName", "(Ljava/lang/String;)Landroid/util/Xml$Encoding;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.util.Xml.Encoding>(@__env.CallStaticObjectMethod(android.util.Xml.staticClass, global::android.util.Xml._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.util.Xml.Encoding;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static global::android.util.AttributeSet asAttributeSet(org.xmlpull.v1.XmlPullParser arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Xml._m6.native == global::System.IntPtr.Zero)
				global::android.util.Xml._m6 = @__env.GetStaticMethodIDNoThrow(global::android.util.Xml.staticClass, "asAttributeSet", "(Lorg/xmlpull/v1/XmlPullParser;)Landroid/util/AttributeSet;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.util.AttributeSet>(@__env.CallStaticObjectMethod(android.util.Xml.staticClass, global::android.util.Xml._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.util.AttributeSet;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public Xml() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.Xml._m7.native == global::System.IntPtr.Zero)
				global::android.util.Xml._m7 = @__env.GetMethodIDNoThrow(global::android.util.Xml.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.Xml.staticClass, global::android.util.Xml._m7);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _FEATURE_RELAXED5461;
		public static global::java.lang.String FEATURE_RELAXED
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetStaticObjectField(global::android.util.Xml.staticClass, _FEATURE_RELAXED5461)) as java.lang.String;
			}
			set
			{
			}
		}
		static Xml()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.Xml.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/Xml"));
			global::android.util.Xml._FEATURE_RELAXED5461 = @__env.GetStaticFieldIDNoThrow(global::android.util.Xml.staticClass, "FEATURE_RELAXED", "Ljava/lang/String;");
		}
	}
}
