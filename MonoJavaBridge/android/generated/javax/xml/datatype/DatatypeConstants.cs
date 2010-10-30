namespace javax.xml.datatype
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class DatatypeConstants : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal DatatypeConstants(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Field : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal Field(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public sealed override global::java.lang.String toString()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::javax.xml.datatype.DatatypeConstants.Field.staticClass, "toString", "()Ljava/lang/String;", ref global::javax.xml.datatype.DatatypeConstants.Field._m0) as java.lang.String;
			}
			public new int Id
			{
				get
				{
					return getId();
				}
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public int getId()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::javax.xml.datatype.DatatypeConstants.Field.staticClass, "getId", "()I", ref global::javax.xml.datatype.DatatypeConstants.Field._m1);
			}
			static Field()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::javax.xml.datatype.DatatypeConstants.Field.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/datatype/DatatypeConstants$Field"));
			}
			internal static void InitJNI()
			{
			}
		}
		public static int JANUARY
		{
			get
			{
				return 1;
			}
		}
		public static int FEBRUARY
		{
			get
			{
				return 2;
			}
		}
		public static int MARCH
		{
			get
			{
				return 3;
			}
		}
		public static int APRIL
		{
			get
			{
				return 4;
			}
		}
		public static int MAY
		{
			get
			{
				return 5;
			}
		}
		public static int JUNE
		{
			get
			{
				return 6;
			}
		}
		public static int JULY
		{
			get
			{
				return 7;
			}
		}
		public static int AUGUST
		{
			get
			{
				return 8;
			}
		}
		public static int SEPTEMBER
		{
			get
			{
				return 9;
			}
		}
		public static int OCTOBER
		{
			get
			{
				return 10;
			}
		}
		public static int NOVEMBER
		{
			get
			{
				return 11;
			}
		}
		public static int DECEMBER
		{
			get
			{
				return 12;
			}
		}
		public static int LESSER
		{
			get
			{
				return -1;
			}
		}
		public static int EQUAL
		{
			get
			{
				return 0;
			}
		}
		public static int GREATER
		{
			get
			{
				return 1;
			}
		}
		public static int INDETERMINATE
		{
			get
			{
				return 2;
			}
		}
		public static int FIELD_UNDEFINED
		{
			get
			{
				return -2147483648;
			}
		}
		internal static global::MonoJavaBridge.FieldId _YEARS7302;
		public static global::javax.xml.datatype.DatatypeConstants.Field YEARS
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.xml.datatype.DatatypeConstants.Field>(@__env.GetStaticObjectField(global::javax.xml.datatype.DatatypeConstants.staticClass, _YEARS7302)) as javax.xml.datatype.DatatypeConstants.Field;
			}
		}
		internal static global::MonoJavaBridge.FieldId _MONTHS7303;
		public static global::javax.xml.datatype.DatatypeConstants.Field MONTHS
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.xml.datatype.DatatypeConstants.Field>(@__env.GetStaticObjectField(global::javax.xml.datatype.DatatypeConstants.staticClass, _MONTHS7303)) as javax.xml.datatype.DatatypeConstants.Field;
			}
		}
		internal static global::MonoJavaBridge.FieldId _DAYS7304;
		public static global::javax.xml.datatype.DatatypeConstants.Field DAYS
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.xml.datatype.DatatypeConstants.Field>(@__env.GetStaticObjectField(global::javax.xml.datatype.DatatypeConstants.staticClass, _DAYS7304)) as javax.xml.datatype.DatatypeConstants.Field;
			}
		}
		internal static global::MonoJavaBridge.FieldId _HOURS7305;
		public static global::javax.xml.datatype.DatatypeConstants.Field HOURS
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.xml.datatype.DatatypeConstants.Field>(@__env.GetStaticObjectField(global::javax.xml.datatype.DatatypeConstants.staticClass, _HOURS7305)) as javax.xml.datatype.DatatypeConstants.Field;
			}
		}
		internal static global::MonoJavaBridge.FieldId _MINUTES7306;
		public static global::javax.xml.datatype.DatatypeConstants.Field MINUTES
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.xml.datatype.DatatypeConstants.Field>(@__env.GetStaticObjectField(global::javax.xml.datatype.DatatypeConstants.staticClass, _MINUTES7306)) as javax.xml.datatype.DatatypeConstants.Field;
			}
		}
		internal static global::MonoJavaBridge.FieldId _SECONDS7307;
		public static global::javax.xml.datatype.DatatypeConstants.Field SECONDS
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<javax.xml.datatype.DatatypeConstants.Field>(@__env.GetStaticObjectField(global::javax.xml.datatype.DatatypeConstants.staticClass, _SECONDS7307)) as javax.xml.datatype.DatatypeConstants.Field;
			}
		}
		internal static global::MonoJavaBridge.FieldId _DATETIME7308;
		public static global::javax.xml.@namespace.QName DATETIME
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::javax.xml.datatype.DatatypeConstants.staticClass, _DATETIME7308)) as javax.xml.@namespace.QName;
			}
		}
		internal static global::MonoJavaBridge.FieldId _TIME7309;
		public static global::javax.xml.@namespace.QName TIME
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::javax.xml.datatype.DatatypeConstants.staticClass, _TIME7309)) as javax.xml.@namespace.QName;
			}
		}
		internal static global::MonoJavaBridge.FieldId _DATE7310;
		public static global::javax.xml.@namespace.QName DATE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::javax.xml.datatype.DatatypeConstants.staticClass, _DATE7310)) as javax.xml.@namespace.QName;
			}
		}
		internal static global::MonoJavaBridge.FieldId _GYEARMONTH7311;
		public static global::javax.xml.@namespace.QName GYEARMONTH
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::javax.xml.datatype.DatatypeConstants.staticClass, _GYEARMONTH7311)) as javax.xml.@namespace.QName;
			}
		}
		internal static global::MonoJavaBridge.FieldId _GMONTHDAY7312;
		public static global::javax.xml.@namespace.QName GMONTHDAY
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::javax.xml.datatype.DatatypeConstants.staticClass, _GMONTHDAY7312)) as javax.xml.@namespace.QName;
			}
		}
		internal static global::MonoJavaBridge.FieldId _GYEAR7313;
		public static global::javax.xml.@namespace.QName GYEAR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::javax.xml.datatype.DatatypeConstants.staticClass, _GYEAR7313)) as javax.xml.@namespace.QName;
			}
		}
		internal static global::MonoJavaBridge.FieldId _GMONTH7314;
		public static global::javax.xml.@namespace.QName GMONTH
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::javax.xml.datatype.DatatypeConstants.staticClass, _GMONTH7314)) as javax.xml.@namespace.QName;
			}
		}
		internal static global::MonoJavaBridge.FieldId _GDAY7315;
		public static global::javax.xml.@namespace.QName GDAY
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::javax.xml.datatype.DatatypeConstants.staticClass, _GDAY7315)) as javax.xml.@namespace.QName;
			}
		}
		internal static global::MonoJavaBridge.FieldId _DURATION7316;
		public static global::javax.xml.@namespace.QName DURATION
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::javax.xml.datatype.DatatypeConstants.staticClass, _DURATION7316)) as javax.xml.@namespace.QName;
			}
		}
		internal static global::MonoJavaBridge.FieldId _DURATION_DAYTIME7317;
		public static global::javax.xml.@namespace.QName DURATION_DAYTIME
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::javax.xml.datatype.DatatypeConstants.staticClass, _DURATION_DAYTIME7317)) as javax.xml.@namespace.QName;
			}
		}
		internal static global::MonoJavaBridge.FieldId _DURATION_YEARMONTH7318;
		public static global::javax.xml.@namespace.QName DURATION_YEARMONTH
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::javax.xml.datatype.DatatypeConstants.staticClass, _DURATION_YEARMONTH7318)) as javax.xml.@namespace.QName;
			}
		}
		public static int MAX_TIMEZONE_OFFSET
		{
			get
			{
				return -840;
			}
		}
		public static int MIN_TIMEZONE_OFFSET
		{
			get
			{
				return 840;
			}
		}
		static DatatypeConstants()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.datatype.DatatypeConstants.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/datatype/DatatypeConstants"));
			global::javax.xml.datatype.DatatypeConstants._YEARS7302 = @__env.GetStaticFieldIDNoThrow(global::javax.xml.datatype.DatatypeConstants.staticClass, "YEARS", "Ljavax/xml/datatype/DatatypeConstants$Field;");
			global::javax.xml.datatype.DatatypeConstants._MONTHS7303 = @__env.GetStaticFieldIDNoThrow(global::javax.xml.datatype.DatatypeConstants.staticClass, "MONTHS", "Ljavax/xml/datatype/DatatypeConstants$Field;");
			global::javax.xml.datatype.DatatypeConstants._DAYS7304 = @__env.GetStaticFieldIDNoThrow(global::javax.xml.datatype.DatatypeConstants.staticClass, "DAYS", "Ljavax/xml/datatype/DatatypeConstants$Field;");
			global::javax.xml.datatype.DatatypeConstants._HOURS7305 = @__env.GetStaticFieldIDNoThrow(global::javax.xml.datatype.DatatypeConstants.staticClass, "HOURS", "Ljavax/xml/datatype/DatatypeConstants$Field;");
			global::javax.xml.datatype.DatatypeConstants._MINUTES7306 = @__env.GetStaticFieldIDNoThrow(global::javax.xml.datatype.DatatypeConstants.staticClass, "MINUTES", "Ljavax/xml/datatype/DatatypeConstants$Field;");
			global::javax.xml.datatype.DatatypeConstants._SECONDS7307 = @__env.GetStaticFieldIDNoThrow(global::javax.xml.datatype.DatatypeConstants.staticClass, "SECONDS", "Ljavax/xml/datatype/DatatypeConstants$Field;");
			global::javax.xml.datatype.DatatypeConstants._DATETIME7308 = @__env.GetStaticFieldIDNoThrow(global::javax.xml.datatype.DatatypeConstants.staticClass, "DATETIME", "Ljavax/xml/namespace/QName;");
			global::javax.xml.datatype.DatatypeConstants._TIME7309 = @__env.GetStaticFieldIDNoThrow(global::javax.xml.datatype.DatatypeConstants.staticClass, "TIME", "Ljavax/xml/namespace/QName;");
			global::javax.xml.datatype.DatatypeConstants._DATE7310 = @__env.GetStaticFieldIDNoThrow(global::javax.xml.datatype.DatatypeConstants.staticClass, "DATE", "Ljavax/xml/namespace/QName;");
			global::javax.xml.datatype.DatatypeConstants._GYEARMONTH7311 = @__env.GetStaticFieldIDNoThrow(global::javax.xml.datatype.DatatypeConstants.staticClass, "GYEARMONTH", "Ljavax/xml/namespace/QName;");
			global::javax.xml.datatype.DatatypeConstants._GMONTHDAY7312 = @__env.GetStaticFieldIDNoThrow(global::javax.xml.datatype.DatatypeConstants.staticClass, "GMONTHDAY", "Ljavax/xml/namespace/QName;");
			global::javax.xml.datatype.DatatypeConstants._GYEAR7313 = @__env.GetStaticFieldIDNoThrow(global::javax.xml.datatype.DatatypeConstants.staticClass, "GYEAR", "Ljavax/xml/namespace/QName;");
			global::javax.xml.datatype.DatatypeConstants._GMONTH7314 = @__env.GetStaticFieldIDNoThrow(global::javax.xml.datatype.DatatypeConstants.staticClass, "GMONTH", "Ljavax/xml/namespace/QName;");
			global::javax.xml.datatype.DatatypeConstants._GDAY7315 = @__env.GetStaticFieldIDNoThrow(global::javax.xml.datatype.DatatypeConstants.staticClass, "GDAY", "Ljavax/xml/namespace/QName;");
			global::javax.xml.datatype.DatatypeConstants._DURATION7316 = @__env.GetStaticFieldIDNoThrow(global::javax.xml.datatype.DatatypeConstants.staticClass, "DURATION", "Ljavax/xml/namespace/QName;");
			global::javax.xml.datatype.DatatypeConstants._DURATION_DAYTIME7317 = @__env.GetStaticFieldIDNoThrow(global::javax.xml.datatype.DatatypeConstants.staticClass, "DURATION_DAYTIME", "Ljavax/xml/namespace/QName;");
			global::javax.xml.datatype.DatatypeConstants._DURATION_YEARMONTH7318 = @__env.GetStaticFieldIDNoThrow(global::javax.xml.datatype.DatatypeConstants.staticClass, "DURATION_YEARMONTH", "Ljavax/xml/namespace/QName;");
		}
		internal static void InitJNI()
		{
		}
	}
}
