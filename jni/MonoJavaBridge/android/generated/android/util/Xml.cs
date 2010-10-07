namespace android.util
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class Xml : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static Xml()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.util.Xml), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.util.Xml(@__env);
			}
		}
		protected Xml(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class Encoding : java.lang.Enum
		{
			internal new static global::java.lang.Class staticClass;
			static Encoding()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.util.Xml.Encoding), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.util.Xml.Encoding(@__env);
				}
			}
			internal Encoding(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _values8353;
			public static global::android.util.Xml.Encoding[] values() 
			{
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.util.Xml.Encoding.staticClass, global::android.util.Xml.Encoding._values8353));
			}
			internal static global::net.sf.jni4net.jni.MethodId _valueOf8354;
			public static global::android.util.Xml.Encoding valueOf(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.util.Xml.Encoding>(@__env, @__env.CallStaticObjectMethodPtr(android.util.Xml.Encoding.staticClass, global::android.util.Xml.Encoding._valueOf8354, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.FieldId _ISO_8859_18355;
			public static global::android.util.Xml.Encoding ISO_8859_1
			{
				get
				{
					return default(global::android.util.Xml.Encoding);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _US_ASCII8356;
			public static global::android.util.Xml.Encoding US_ASCII
			{
				get
				{
					return default(global::android.util.Xml.Encoding);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _UTF_168357;
			public static global::android.util.Xml.Encoding UTF_16
			{
				get
				{
					return default(global::android.util.Xml.Encoding);
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _UTF_88358;
			public static global::android.util.Xml.Encoding UTF_8
			{
				get
				{
					return default(global::android.util.Xml.Encoding);
				}
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.util.Xml.Encoding.staticClass = @__class;
				global::android.util.Xml.Encoding._values8353 = @__env.GetStaticMethodID(global::android.util.Xml.Encoding.staticClass, "values", "()[Landroid/util/Xml/Encoding;");
				global::android.util.Xml.Encoding._valueOf8354 = @__env.GetStaticMethodID(global::android.util.Xml.Encoding.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/util/Xml$Encoding;");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _parse8359;
		public static void parse(java.lang.String arg0, org.xml.sax.ContentHandler arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.util.Xml.staticClass, global::android.util.Xml._parse8359, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _parse8360;
		public static void parse(java.io.Reader arg0, org.xml.sax.ContentHandler arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.util.Xml.staticClass, global::android.util.Xml._parse8360, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _parse8361;
		public static void parse(java.io.InputStream arg0, android.util.Xml.Encoding arg1, org.xml.sax.ContentHandler arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.util.Xml.staticClass, global::android.util.Xml._parse8361, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _newPullParser8362;
		public static global::org.xmlpull.v1.XmlPullParser newPullParser() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.xmlpull.v1.XmlPullParser>(@__env, @__env.CallStaticObjectMethodPtr(android.util.Xml.staticClass, global::android.util.Xml._newPullParser8362));
		}
		internal static global::net.sf.jni4net.jni.MethodId _newSerializer8363;
		public static global::org.xmlpull.v1.XmlSerializer newSerializer() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<org.xmlpull.v1.XmlSerializer>(@__env, @__env.CallStaticObjectMethodPtr(android.util.Xml.staticClass, global::android.util.Xml._newSerializer8363));
		}
		internal static global::net.sf.jni4net.jni.MethodId _findEncodingByName8364;
		public static global::android.util.Xml.Encoding findEncodingByName(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.util.Xml.Encoding>(@__env, @__env.CallStaticObjectMethodPtr(android.util.Xml.staticClass, global::android.util.Xml._findEncodingByName8364, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _asAttributeSet8365;
		public static global::android.util.AttributeSet asAttributeSet(org.xmlpull.v1.XmlPullParser arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.util.AttributeSet>(@__env, @__env.CallStaticObjectMethodPtr(android.util.Xml.staticClass, global::android.util.Xml._asAttributeSet8365, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Xml8366;
		public Xml()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.util.Xml.staticClass, global::android.util.Xml._Xml8366, this);
		}
		internal static global::net.sf.jni4net.jni.FieldId _FEATURE_RELAXED8367;
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.util.Xml.staticClass = @__class;
			global::android.util.Xml._parse8359 = @__env.GetStaticMethodID(global::android.util.Xml.staticClass, "parse", "(Ljava/lang/String;Lorg/xml/sax/ContentHandler;)V");
			global::android.util.Xml._parse8360 = @__env.GetStaticMethodID(global::android.util.Xml.staticClass, "parse", "(Ljava/io/Reader;Lorg/xml/sax/ContentHandler;)V");
			global::android.util.Xml._parse8361 = @__env.GetStaticMethodID(global::android.util.Xml.staticClass, "parse", "(Ljava/io/InputStream;Landroid/util/Xml$Encoding;Lorg/xml/sax/ContentHandler;)V");
			global::android.util.Xml._newPullParser8362 = @__env.GetStaticMethodID(global::android.util.Xml.staticClass, "newPullParser", "()Lorg/xmlpull/v1/XmlPullParser;");
			global::android.util.Xml._newSerializer8363 = @__env.GetStaticMethodID(global::android.util.Xml.staticClass, "newSerializer", "()Lorg/xmlpull/v1/XmlSerializer;");
			global::android.util.Xml._findEncodingByName8364 = @__env.GetStaticMethodID(global::android.util.Xml.staticClass, "findEncodingByName", "(Ljava/lang/String;)Landroid/util/Xml$Encoding;");
			global::android.util.Xml._asAttributeSet8365 = @__env.GetStaticMethodID(global::android.util.Xml.staticClass, "asAttributeSet", "(Lorg/xmlpull/v1/XmlPullParser;)Landroid/util/AttributeSet;");
			global::android.util.Xml._Xml8366 = @__env.GetMethodID(global::android.util.Xml.staticClass, "<init>", "()V");
		}
	}
}
