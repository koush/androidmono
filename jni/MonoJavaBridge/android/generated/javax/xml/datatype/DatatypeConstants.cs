namespace javax.xml.datatype
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class DatatypeConstants : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DatatypeConstants()
		{
			InitJNI();
		}
		internal DatatypeConstants(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Field : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Field()
			{
				InitJNI();
			}
			internal Field(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _toString30520;
			public sealed override global::java.lang.String toString() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeConstants.Field._toString30520)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeConstants.Field.staticClass, global::javax.xml.datatype.DatatypeConstants.Field._toString30520)) as java.lang.String;
			}
			public new int Id
			{
				get
				{
					return getId();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getId30521;
			public int getId() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeConstants.Field._getId30521);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeConstants.Field.staticClass, global::javax.xml.datatype.DatatypeConstants.Field._getId30521);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::javax.xml.datatype.DatatypeConstants.Field.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/datatype/DatatypeConstants$Field"));
				global::javax.xml.datatype.DatatypeConstants.Field._toString30520 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeConstants.Field.staticClass, "toString", "()Ljava/lang/String;");
				global::javax.xml.datatype.DatatypeConstants.Field._getId30521 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeConstants.Field.staticClass, "getId", "()I");
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
		internal static global::MonoJavaBridge.FieldId _YEARS30539;
		public static global::javax.xml.datatype.DatatypeConstants.Field YEARS
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::javax.xml.datatype.DatatypeConstants.staticClass, _YEARS30539)) as javax.xml.datatype.DatatypeConstants.Field;
			}
		}
		internal static global::MonoJavaBridge.FieldId _MONTHS30540;
		public static global::javax.xml.datatype.DatatypeConstants.Field MONTHS
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::javax.xml.datatype.DatatypeConstants.staticClass, _MONTHS30540)) as javax.xml.datatype.DatatypeConstants.Field;
			}
		}
		internal static global::MonoJavaBridge.FieldId _DAYS30541;
		public static global::javax.xml.datatype.DatatypeConstants.Field DAYS
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::javax.xml.datatype.DatatypeConstants.staticClass, _DAYS30541)) as javax.xml.datatype.DatatypeConstants.Field;
			}
		}
		internal static global::MonoJavaBridge.FieldId _HOURS30542;
		public static global::javax.xml.datatype.DatatypeConstants.Field HOURS
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::javax.xml.datatype.DatatypeConstants.staticClass, _HOURS30542)) as javax.xml.datatype.DatatypeConstants.Field;
			}
		}
		internal static global::MonoJavaBridge.FieldId _MINUTES30543;
		public static global::javax.xml.datatype.DatatypeConstants.Field MINUTES
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::javax.xml.datatype.DatatypeConstants.staticClass, _MINUTES30543)) as javax.xml.datatype.DatatypeConstants.Field;
			}
		}
		internal static global::MonoJavaBridge.FieldId _SECONDS30544;
		public static global::javax.xml.datatype.DatatypeConstants.Field SECONDS
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::javax.xml.datatype.DatatypeConstants.staticClass, _SECONDS30544)) as javax.xml.datatype.DatatypeConstants.Field;
			}
		}
		internal static global::MonoJavaBridge.FieldId _DATETIME30545;
		public static global::javax.xml.@namespace.QName DATETIME
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::javax.xml.datatype.DatatypeConstants.staticClass, _DATETIME30545)) as javax.xml.@namespace.QName;
			}
		}
		internal static global::MonoJavaBridge.FieldId _TIME30546;
		public static global::javax.xml.@namespace.QName TIME
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::javax.xml.datatype.DatatypeConstants.staticClass, _TIME30546)) as javax.xml.@namespace.QName;
			}
		}
		internal static global::MonoJavaBridge.FieldId _DATE30547;
		public static global::javax.xml.@namespace.QName DATE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::javax.xml.datatype.DatatypeConstants.staticClass, _DATE30547)) as javax.xml.@namespace.QName;
			}
		}
		internal static global::MonoJavaBridge.FieldId _GYEARMONTH30548;
		public static global::javax.xml.@namespace.QName GYEARMONTH
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::javax.xml.datatype.DatatypeConstants.staticClass, _GYEARMONTH30548)) as javax.xml.@namespace.QName;
			}
		}
		internal static global::MonoJavaBridge.FieldId _GMONTHDAY30549;
		public static global::javax.xml.@namespace.QName GMONTHDAY
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::javax.xml.datatype.DatatypeConstants.staticClass, _GMONTHDAY30549)) as javax.xml.@namespace.QName;
			}
		}
		internal static global::MonoJavaBridge.FieldId _GYEAR30550;
		public static global::javax.xml.@namespace.QName GYEAR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::javax.xml.datatype.DatatypeConstants.staticClass, _GYEAR30550)) as javax.xml.@namespace.QName;
			}
		}
		internal static global::MonoJavaBridge.FieldId _GMONTH30551;
		public static global::javax.xml.@namespace.QName GMONTH
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::javax.xml.datatype.DatatypeConstants.staticClass, _GMONTH30551)) as javax.xml.@namespace.QName;
			}
		}
		internal static global::MonoJavaBridge.FieldId _GDAY30552;
		public static global::javax.xml.@namespace.QName GDAY
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::javax.xml.datatype.DatatypeConstants.staticClass, _GDAY30552)) as javax.xml.@namespace.QName;
			}
		}
		internal static global::MonoJavaBridge.FieldId _DURATION30553;
		public static global::javax.xml.@namespace.QName DURATION
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::javax.xml.datatype.DatatypeConstants.staticClass, _DURATION30553)) as javax.xml.@namespace.QName;
			}
		}
		internal static global::MonoJavaBridge.FieldId _DURATION_DAYTIME30554;
		public static global::javax.xml.@namespace.QName DURATION_DAYTIME
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::javax.xml.datatype.DatatypeConstants.staticClass, _DURATION_DAYTIME30554)) as javax.xml.@namespace.QName;
			}
		}
		internal static global::MonoJavaBridge.FieldId _DURATION_YEARMONTH30555;
		public static global::javax.xml.@namespace.QName DURATION_YEARMONTH
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::javax.xml.datatype.DatatypeConstants.staticClass, _DURATION_YEARMONTH30555)) as javax.xml.@namespace.QName;
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.datatype.DatatypeConstants.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/datatype/DatatypeConstants"));
			global::javax.xml.datatype.DatatypeConstants._YEARS30539 = @__env.GetStaticFieldIDNoThrow(global::javax.xml.datatype.DatatypeConstants.staticClass, "YEARS", "Ljavax/xml/datatype/DatatypeConstants$Field;");
			global::javax.xml.datatype.DatatypeConstants._MONTHS30540 = @__env.GetStaticFieldIDNoThrow(global::javax.xml.datatype.DatatypeConstants.staticClass, "MONTHS", "Ljavax/xml/datatype/DatatypeConstants$Field;");
			global::javax.xml.datatype.DatatypeConstants._DAYS30541 = @__env.GetStaticFieldIDNoThrow(global::javax.xml.datatype.DatatypeConstants.staticClass, "DAYS", "Ljavax/xml/datatype/DatatypeConstants$Field;");
			global::javax.xml.datatype.DatatypeConstants._HOURS30542 = @__env.GetStaticFieldIDNoThrow(global::javax.xml.datatype.DatatypeConstants.staticClass, "HOURS", "Ljavax/xml/datatype/DatatypeConstants$Field;");
			global::javax.xml.datatype.DatatypeConstants._MINUTES30543 = @__env.GetStaticFieldIDNoThrow(global::javax.xml.datatype.DatatypeConstants.staticClass, "MINUTES", "Ljavax/xml/datatype/DatatypeConstants$Field;");
			global::javax.xml.datatype.DatatypeConstants._SECONDS30544 = @__env.GetStaticFieldIDNoThrow(global::javax.xml.datatype.DatatypeConstants.staticClass, "SECONDS", "Ljavax/xml/datatype/DatatypeConstants$Field;");
			global::javax.xml.datatype.DatatypeConstants._DATETIME30545 = @__env.GetStaticFieldIDNoThrow(global::javax.xml.datatype.DatatypeConstants.staticClass, "DATETIME", "Ljavax/xml/@namespace/QName;");
			global::javax.xml.datatype.DatatypeConstants._TIME30546 = @__env.GetStaticFieldIDNoThrow(global::javax.xml.datatype.DatatypeConstants.staticClass, "TIME", "Ljavax/xml/@namespace/QName;");
			global::javax.xml.datatype.DatatypeConstants._DATE30547 = @__env.GetStaticFieldIDNoThrow(global::javax.xml.datatype.DatatypeConstants.staticClass, "DATE", "Ljavax/xml/@namespace/QName;");
			global::javax.xml.datatype.DatatypeConstants._GYEARMONTH30548 = @__env.GetStaticFieldIDNoThrow(global::javax.xml.datatype.DatatypeConstants.staticClass, "GYEARMONTH", "Ljavax/xml/@namespace/QName;");
			global::javax.xml.datatype.DatatypeConstants._GMONTHDAY30549 = @__env.GetStaticFieldIDNoThrow(global::javax.xml.datatype.DatatypeConstants.staticClass, "GMONTHDAY", "Ljavax/xml/@namespace/QName;");
			global::javax.xml.datatype.DatatypeConstants._GYEAR30550 = @__env.GetStaticFieldIDNoThrow(global::javax.xml.datatype.DatatypeConstants.staticClass, "GYEAR", "Ljavax/xml/@namespace/QName;");
			global::javax.xml.datatype.DatatypeConstants._GMONTH30551 = @__env.GetStaticFieldIDNoThrow(global::javax.xml.datatype.DatatypeConstants.staticClass, "GMONTH", "Ljavax/xml/@namespace/QName;");
			global::javax.xml.datatype.DatatypeConstants._GDAY30552 = @__env.GetStaticFieldIDNoThrow(global::javax.xml.datatype.DatatypeConstants.staticClass, "GDAY", "Ljavax/xml/@namespace/QName;");
			global::javax.xml.datatype.DatatypeConstants._DURATION30553 = @__env.GetStaticFieldIDNoThrow(global::javax.xml.datatype.DatatypeConstants.staticClass, "DURATION", "Ljavax/xml/@namespace/QName;");
			global::javax.xml.datatype.DatatypeConstants._DURATION_DAYTIME30554 = @__env.GetStaticFieldIDNoThrow(global::javax.xml.datatype.DatatypeConstants.staticClass, "DURATION_DAYTIME", "Ljavax/xml/@namespace/QName;");
			global::javax.xml.datatype.DatatypeConstants._DURATION_YEARMONTH30555 = @__env.GetStaticFieldIDNoThrow(global::javax.xml.datatype.DatatypeConstants.staticClass, "DURATION_YEARMONTH", "Ljavax/xml/@namespace/QName;");
		}
	}
}
