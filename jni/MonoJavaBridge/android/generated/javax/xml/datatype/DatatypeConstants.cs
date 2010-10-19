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
			internal static global::MonoJavaBridge.MethodId _toString24076;
			public sealed override global::java.lang.String toString() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeConstants.Field._toString24076)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeConstants.Field.staticClass, global::javax.xml.datatype.DatatypeConstants.Field._toString24076)) as java.lang.String;
			}
			public new int Id
			{
				get
				{
					return getId();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getId24077;
			public int getId() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeConstants.Field._getId24077);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.xml.datatype.DatatypeConstants.Field.staticClass, global::javax.xml.datatype.DatatypeConstants.Field._getId24077);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::javax.xml.datatype.DatatypeConstants.Field.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/datatype/DatatypeConstants$Field"));
				global::javax.xml.datatype.DatatypeConstants.Field._toString24076 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeConstants.Field.staticClass, "toString", "()Ljava/lang/String;");
				global::javax.xml.datatype.DatatypeConstants.Field._getId24077 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeConstants.Field.staticClass, "getId", "()I");
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
		internal static global::MonoJavaBridge.FieldId _YEARS24078;
		public static global::javax.xml.datatype.DatatypeConstants.Field YEARS
		{
			get
			{
				return default(global::javax.xml.datatype.DatatypeConstants.Field);
			}
		}
		internal static global::MonoJavaBridge.FieldId _MONTHS24079;
		public static global::javax.xml.datatype.DatatypeConstants.Field MONTHS
		{
			get
			{
				return default(global::javax.xml.datatype.DatatypeConstants.Field);
			}
		}
		internal static global::MonoJavaBridge.FieldId _DAYS24080;
		public static global::javax.xml.datatype.DatatypeConstants.Field DAYS
		{
			get
			{
				return default(global::javax.xml.datatype.DatatypeConstants.Field);
			}
		}
		internal static global::MonoJavaBridge.FieldId _HOURS24081;
		public static global::javax.xml.datatype.DatatypeConstants.Field HOURS
		{
			get
			{
				return default(global::javax.xml.datatype.DatatypeConstants.Field);
			}
		}
		internal static global::MonoJavaBridge.FieldId _MINUTES24082;
		public static global::javax.xml.datatype.DatatypeConstants.Field MINUTES
		{
			get
			{
				return default(global::javax.xml.datatype.DatatypeConstants.Field);
			}
		}
		internal static global::MonoJavaBridge.FieldId _SECONDS24083;
		public static global::javax.xml.datatype.DatatypeConstants.Field SECONDS
		{
			get
			{
				return default(global::javax.xml.datatype.DatatypeConstants.Field);
			}
		}
		internal static global::MonoJavaBridge.FieldId _DATETIME24084;
		public static global::javax.xml.@namespace.QName DATETIME
		{
			get
			{
				return default(global::javax.xml.@namespace.QName);
			}
		}
		internal static global::MonoJavaBridge.FieldId _TIME24085;
		public static global::javax.xml.@namespace.QName TIME
		{
			get
			{
				return default(global::javax.xml.@namespace.QName);
			}
		}
		internal static global::MonoJavaBridge.FieldId _DATE24086;
		public static global::javax.xml.@namespace.QName DATE
		{
			get
			{
				return default(global::javax.xml.@namespace.QName);
			}
		}
		internal static global::MonoJavaBridge.FieldId _GYEARMONTH24087;
		public static global::javax.xml.@namespace.QName GYEARMONTH
		{
			get
			{
				return default(global::javax.xml.@namespace.QName);
			}
		}
		internal static global::MonoJavaBridge.FieldId _GMONTHDAY24088;
		public static global::javax.xml.@namespace.QName GMONTHDAY
		{
			get
			{
				return default(global::javax.xml.@namespace.QName);
			}
		}
		internal static global::MonoJavaBridge.FieldId _GYEAR24089;
		public static global::javax.xml.@namespace.QName GYEAR
		{
			get
			{
				return default(global::javax.xml.@namespace.QName);
			}
		}
		internal static global::MonoJavaBridge.FieldId _GMONTH24090;
		public static global::javax.xml.@namespace.QName GMONTH
		{
			get
			{
				return default(global::javax.xml.@namespace.QName);
			}
		}
		internal static global::MonoJavaBridge.FieldId _GDAY24091;
		public static global::javax.xml.@namespace.QName GDAY
		{
			get
			{
				return default(global::javax.xml.@namespace.QName);
			}
		}
		internal static global::MonoJavaBridge.FieldId _DURATION24092;
		public static global::javax.xml.@namespace.QName DURATION
		{
			get
			{
				return default(global::javax.xml.@namespace.QName);
			}
		}
		internal static global::MonoJavaBridge.FieldId _DURATION_DAYTIME24093;
		public static global::javax.xml.@namespace.QName DURATION_DAYTIME
		{
			get
			{
				return default(global::javax.xml.@namespace.QName);
			}
		}
		internal static global::MonoJavaBridge.FieldId _DURATION_YEARMONTH24094;
		public static global::javax.xml.@namespace.QName DURATION_YEARMONTH
		{
			get
			{
				return default(global::javax.xml.@namespace.QName);
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
		}
	}
}
